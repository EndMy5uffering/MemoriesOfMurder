using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMenuHandler : MonoBehaviour
{

    public int mainMenuScene = 0;

    public PlayerController playerController;

    public void OnContinueButton()
    {
        playerController.exitMenuOpen = false;
        playerController.exitMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnQuitGame()
    {
        Application.Quit();
    }

    public void OnReturnToMenuButton()
    {
        SceneManager.LoadScene(mainMenuScene);
    }

}
