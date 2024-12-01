using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class TabOverlayHandlerScript : MonoBehaviour
{
    public TabButtonHandler selected = null;

    public GameObject tabUI;

    public PlayerController player;

    public GameObject selectionCircle;

    public int goodEnding = 0;
    public int badEnding = 1;

    public void OnAcceptHoverEnter()
    {
        selectionCircle.SetActive(true);
    }

    public void OnAcceptHoverExit()
    {
        selectionCircle.SetActive(false);
    }

    public void OnAccept()
    {

        if(selected == null) return;
        if(selected.type == TabButtonHandler.TabButtonTypes.You)
        {
            SceneManager.LoadScene(badEnding);
        }
        else
        {
            SceneManager.LoadScene(goodEnding);
        }
    }

    public void OnExitClick()
    {
        tabUI.SetActive(false);
        player.tabOpen = false;
        Cursor.lockState = CursorLockMode.None;
    }

}
