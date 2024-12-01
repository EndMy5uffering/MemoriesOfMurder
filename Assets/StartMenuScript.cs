using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{

    public int GameScene = 0;
    public int CreditScene = 6;

    public void onStartButton()
    {
        SceneManager.LoadScene(GameScene);
    }

    public void onExit()
    {
        Application.Quit();
    }

    public void onCredits()
    {
        SceneManager.LoadScene(CreditScene);
    }

}
