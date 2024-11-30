using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickableTrigger : MonoBehaviour
{
    public GameObject requiredItem;

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
        if(other.gameObject.tag == "Player")
        {
            if(other.gameObject.GetComponent<PickupScript>().HasItemInHand() && other.gameObject.GetComponent<PickupScript>().GetHeldItem() == requiredItem)
            {
                other.gameObject.GetComponent<PickupScript>().DestroyItemInHand();
            }
        }
    }
}
