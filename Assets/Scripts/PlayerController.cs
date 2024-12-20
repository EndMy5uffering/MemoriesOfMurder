using System;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float lookSpeed = 2.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    public CharacterController characterController;
    private Vector3 moveDirection = Vector3.zero;
    private float rotationX = 0.0f;

    public float rayDistance = 10;

    public Camera cam;
    float time = 0;

    public delegate void PlayerInteract(GameObject interacted);
    private PlayerInteract onInteraction;

    private PickupScript picker;

    public AnimationCurve headBob;
    public float bobingspeed = 8;
    private float initHeadY;

    public bool exitMenuOpen = false;
    public GameObject exitMenu;

    public GameObject tabUI;
    public bool tabOpen = false;

    void Awake()
    {
        picker = GetComponent<PickupScript>();
        onInteraction += picker.OnInteract;
        initHeadY = cam.transform.localPosition.y;
    }

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        if(exitMenuOpen || tabOpen) Cursor.lockState = CursorLockMode.None;

        if(HandleEscUI()) return;

        if(HandleTabUI()) return;

        HandleMovement();
        HandleRotation();
        if (Input.GetKeyDown(KeyCode.E))
        {
            HandleInteraction();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            GameScene.onLeftClickEvent?.Invoke();
        }


    }

    public bool HandleEscUI()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) 
        {
            exitMenu.SetActive(!exitMenuOpen);
            if(exitMenuOpen)
            {
                exitMenuOpen = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                exitMenuOpen = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }

        return exitMenuOpen;
    }

    public bool HandleTabUI()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            tabUI.SetActive(!tabOpen);
            if(tabOpen)
            {
                tabOpen = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                tabOpen = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }


        return tabOpen;
    }

    private void HandleInteraction()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            GameObject obj = hit.transform.gameObject;
            Debug.Log(obj);
            if(obj.tag == "Pickable")
            {
                onInteraction?.Invoke(obj);
            }else
            {
                onInteraction?.Invoke(null);
            }

            if(obj.GetComponent<NPC>() != null)
            {
                GameScene.onInteractionWithNpcEvent?.Invoke(obj.GetComponent<NPC>());
            }
        }

    }

    void OnDrawGizmos()
    {
        Gizmos.DrawLine(cam.transform.position, cam.transform.position + cam.transform.forward * rayDistance);
    }

    void HandleMovement()
    {
        if (characterController.isGrounded)
        {
            // We are grounded, so recalculate move direction based on axes
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 move = transform.right * moveHorizontal + transform.forward * moveVertical;
            moveDirection = move * speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
                AudioManager.Instance.PlayOneShotFMOD2D("Jump");
            }

            if(moveDirection.magnitude > 0) HeadWoble();

        }

        // Apply gravity
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);

    }

    void HandleRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * lookSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * lookSpeed;

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90, 90);

        transform.localRotation = Quaternion.Euler(0, transform.localRotation.eulerAngles.y + mouseX, 0);
        Camera.main.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
    }

    private void HeadWoble()
    {
        cam.transform.localPosition = new Vector3(cam.transform.localPosition.x, Mathf.Lerp(initHeadY-0.02f, initHeadY + 0.02f, headBob.Evaluate(0.5f * (math.sin(time)+1.0f))), cam.transform.localPosition.z);
        float oldTime = time;
        time += Time.deltaTime*bobingspeed;
        if (time > Math.PI * 2)
        {
            time = 0;
            AudioManager.Instance.PlayOneShotFMOD2D("Footstep");
        }

        if (time > Math.PI && oldTime < Math.PI)
        {
            AudioManager.Instance.PlayOneShotFMOD2D("Footstep");
        }


    }
}
