using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PickableTrigger : MonoBehaviour
{
    public GameObject requiredItem;

    public UnityEvent<GameObject> onItemDeliverd = new UnityEvent<GameObject>();

    private GameObject canvas;
    private GameObject image;

    public Sprite displayImage;

    private GameObject player;
    public Vector2 displayScale = Vector2.one;

    void Awake()
    {
        if(!displayImage) return;

        canvas = new GameObject("canvas");
        canvas.AddComponent<RectTransform>();
        canvas.AddComponent<Canvas>();
        canvas.AddComponent<CanvasScaler>();
        canvas.GetComponent<Canvas>().renderMode = RenderMode.WorldSpace;
        canvas.GetComponent<RectTransform>().SetParent(this.transform);
        canvas.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        canvas.GetComponent<RectTransform>().sizeDelta = displayScale;

        image = new GameObject("image");
        image.AddComponent<RectTransform>();
        image.GetComponent<RectTransform>().SetParent(canvas.GetComponent<RectTransform>());
        image.GetComponent<RectTransform>().sizeDelta = displayScale;
        image.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        image.AddComponent<UnityEngine.UI.Image>();
        image.GetComponent<UnityEngine.UI.Image>().sprite = displayImage;

        canvas.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!displayImage) return;

        if(player == null) return;

        Vector3 dir = player.transform.position - transform.position;
        dir.y = 0;
        
        canvas.GetComponent<RectTransform>().LookAt(transform.position + dir, Vector3.up);
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "Player") return;
        if(other.gameObject.GetComponent<PickupScript>().HasItemInHand() && other.gameObject.GetComponent<PickupScript>().GetHeldItem() == requiredItem)
        {
            onItemDeliverd?.Invoke(other.gameObject.GetComponent<PickupScript>().GetHeldItem());
        }

        player = other.gameObject;
        canvas.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag != "Player") return;

        player = null;
        canvas.SetActive(false);
    }
}
