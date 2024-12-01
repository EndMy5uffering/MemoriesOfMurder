using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoverTriggerHandle : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void onButtonHoverEnter(BaseEventData bed)
    {
        AudioManager.Instance.PlayButtonHoverSound();
        obj.SetActive(true);
    }

    public void onButtonHoverExit(BaseEventData bed)
    {
        obj.SetActive(false);
    }
}
