using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{

    public int GameScene = 0;

    public void onStartButton()
    {
        AudioManager.Instance.PlayButtonClickSound();
        AudioManager.Instance.TransitionToGame();
        SceneManager.LoadScene(GameScene);

    }

    public void onExit()
    {
        AudioManager.Instance.PlayButtonClickSound();
        Application.Quit();
    }

    public void onCredits()
    {
        AudioManager.Instance.PlayButtonClickSound();
    }

}
