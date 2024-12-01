using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TabButtonHandler : MonoBehaviour
{
    public enum TabButtonTypes
    {
        none,

        You,
        Dad,
        Granny,
        Neighbour
    }

    public GameObject selectionCircle;
    public TabOverlayHandlerScript tabScript;

    bool Selected = false;

    public TabButtonTypes type = TabButtonTypes.none;

    public void OnCircleHoverEnter()
    {
        selectionCircle.SetActive(true);
    }

    public void OnCircleHoverExit()
    {
        if(!Selected) selectionCircle.SetActive(false);
    }

    public void OnSelect()
    {
        Selected = true;
        selectionCircle.SetActive(true);

        if(tabScript.selected != null)
        {
            tabScript.selected.Selected = false;
            tabScript.selected.selectionCircle.SetActive(false);
        }

        tabScript.selected = this;

    }


}
