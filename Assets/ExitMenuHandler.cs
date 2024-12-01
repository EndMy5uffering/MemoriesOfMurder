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
        AudioManager.Instance.PlayButtonClickSound();
        playerController.exitMenuOpen = false;
        playerController.exitMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnQuitGame()
    {
        AudioManager.Instance.PlayButtonClickSound();
        Application.Quit();
    }

    public void OnReturnToMenuButton()
    {
        AudioManager.Instance.PlayButtonClickSound();
        AudioManager.Instance.TransitionToTitleScreen();
        SceneManager.LoadScene(mainMenuScene);
    }

}
