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
        AudioManager.Instance.PlayButtonHoverSound();
        selectionCircle.SetActive(true);
    }

    public void OnAcceptHoverExit()
    {
        selectionCircle.SetActive(false);
    }

    public void OnAccept()
    {
        AudioManager.Instance.PlayButtonClickSound();
        if (selected.type == TabButtonHandler.TabButtonTypes.You)
        {
            AudioManager.Instance.StopMainBGM();
            SceneManager.LoadScene(badEnding);
        }
        else
        {
            AudioManager.Instance.TransitionToEnding1();
            SceneManager.LoadScene(goodEnding);
        }
    }

    public void OnExitClick()
    {
        AudioManager.Instance.PlayButtonClickSound();
        tabUI.SetActive(false);
        player.tabOpen = false;
        Cursor.lockState = CursorLockMode.None;
    }

}
