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

    public void OnHoverTriggerEnter()
    {
        goodImage.SetActive(false);
        badImage.SetActive(true);
        returnButton.SetActive(true);
    }

    public void OnExitButton()
    {
        SceneManager.LoadScene(StartSceneID);
    }


}
