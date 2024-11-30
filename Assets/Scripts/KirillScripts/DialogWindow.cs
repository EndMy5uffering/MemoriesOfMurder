using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogWindow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private TextMeshProUGUI messageText;
    public void SetTitle(string title)
    {
        titleText.text = title;
    }

    public void SetMessage(string message)
    {
        messageText.text = message;
    }
}
