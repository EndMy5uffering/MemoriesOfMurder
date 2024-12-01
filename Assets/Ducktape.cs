using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ducktape : MonoBehaviour
{
    public PlayerController player;

    public void OnGrabEvent(bool b)
    {
        if(!b) 
            player.GetComponent<PickupScript>().OnInteract(this.gameObject);
        else
        {
            if(player.GetComponent<PickupScript>().GetHeldItem() == this.gameObject)
                player.GetComponent<PickupScript>().DropItem();
        }
    }

    public void OnGrabEnd(bool b)
    {
        
    }
}
