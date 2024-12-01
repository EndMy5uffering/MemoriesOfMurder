using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitEndScreenHandler : MonoBehaviour
{

    public int MainMenuID = 0;

    public GameObject image;

    public void OnQuitToEndScreen()
    {
        SceneManager.LoadScene(MainMenuID);
    }

    public void OnHoverEnter()
    {
        image.SetActive(true);
    }

    public void OnHoverExit()
    {
        image.SetActive(false);
    }

}
