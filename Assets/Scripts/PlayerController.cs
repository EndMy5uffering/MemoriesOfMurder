using System.Linq;
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
    
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        
        Debug.Log("I am: " + this.gameObject);
    }

    void Update()
    {
        HandleMovement();
        HandleRotation();
        
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
            }
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
}