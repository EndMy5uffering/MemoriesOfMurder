using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PickableTrigger : MonoBehaviour
{
    public GameObject requiredItem;

    public UnityEvent<GameObject> onItemDeliverd = new UnityEvent<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "Player") return;
        if(other.gameObject.GetComponent<PickupScript>().HasItemInHand() && other.gameObject.GetComponent<PickupScript>().GetHeldItem() == requiredItem)
        {
            onItemDeliverd?.Invoke(other.gameObject.GetComponent<PickupScript>().GetHeldItem());
        }
    }
}
