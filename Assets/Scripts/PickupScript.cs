using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{

    public Transform hand;

    private GameObject pickedItem;
    private Transform prevParent;

    bool wasKinematic = false;
    bool usedGraviety = false;
    bool hadRigidbody = false;


    int prevLayer = -1;

    public void OnInteract(GameObject obj)
    {
        bool isSame = pickedItem == obj;
        if(HasItemInHand() || obj == null) 
        {
            DropItem();
            if(isSame) return;
        }

        Quaternion offsetRot = Quaternion.identity;
        Vector3 offsetPos = Vector3.zero;

        if(obj.GetComponent<Pickable>() != null)
        {
            if(obj.GetComponent<Pickable>().offset != null)
            {
                offsetRot = obj.GetComponent<Pickable>().offset.localRotation;
                offsetPos = obj.GetComponent<Pickable>().offset.localPosition;
            }
        }

        prevLayer = obj.layer;
        prevParent = obj.transform.parent;
        obj.layer = LayerMask.NameToLayer("Picked");
        obj.transform.parent = hand;
        obj.transform.rotation = hand.rotation * Quaternion.Inverse(offsetRot);
        obj.transform.position = hand.position - offsetPos;
        pickedItem = obj;
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        hadRigidbody = rb != null;
        if(hadRigidbody) 
        {
            wasKinematic = rb.isKinematic;
            usedGraviety = rb.useGravity;
            obj.GetComponent<Rigidbody>().isKinematic = true;
            obj.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    public void DropItem()
    {
        if(pickedItem == null) return;
        pickedItem.layer = prevLayer;
        pickedItem.transform.parent = prevParent;

        if(hadRigidbody)
        {
            pickedItem.GetComponent<Rigidbody>().useGravity = usedGraviety;
            pickedItem.GetComponent<Rigidbody>().isKinematic = wasKinematic;
        }

        pickedItem = null;

    }

    public bool HasItemInHand()
    {
        return pickedItem != null;
    }

    public GameObject GetHeldItem()
    {
        return this.pickedItem;
    }

    public void DestroyItemInHand()
    {
        GameObject.Destroy(pickedItem);
        pickedItem = null;
    }

}
