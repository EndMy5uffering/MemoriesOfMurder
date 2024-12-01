using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EvilExitMenuHandle : MonoBehaviour
{

    public GameObject goodImage;
    public GameObject badImage;

    public GameObject returnButton;

    public int StartSceneID = 0;

    public bool triggered;

    void Start()
    {
        triggered = false;
    }

    public void OnHoverTriggerEnter()
    {
        if (triggered)
            return;

        goodImage.SetActive(false);
        badImage.SetActive(true);
        returnButton.SetActive(true);
        AudioManager.Instance.PlayEnding2();

        triggered = true;
    }

    public void OnExitButton()
    {
        AudioManager.Instance.PlayButtonClickSound();
        AudioManager.Instance.TransitionToTitleScreen();
        SceneManager.LoadScene(StartSceneID);
    }


}
