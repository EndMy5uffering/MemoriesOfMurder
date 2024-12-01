using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ducktape : MonoBehaviour
{
    public PlayerController player;

    public void OnGrabEvent(bool b)
    {
        player.GetComponent<PickupScript>().OnInteract(this.gameObject);
    }

    public void OnGrabEnd(bool b)
    {
        if(player.GetComponent<PickupScript>().GetHeldItem() == this.gameObject)
            player.GetComponent<PickupScript>().DropItem();
    }
}
