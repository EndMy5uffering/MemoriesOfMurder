using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditBackButtonScript : MonoBehaviour
{
    public GameObject underlineImage;

    public int startMenu = 1;

    public void OnButtonHoverEnter()
    {
        underlineImage.SetActive(true);
    }

    public void OnButtonHoverExit()
    {
        underlineImage.SetActive(false);
    }

    public void OnButtonClick()
    {
        underlineImage.SetActive(false);
        SceneManager.LoadScene(startMenu);
    }
}
