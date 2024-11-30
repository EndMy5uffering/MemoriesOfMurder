using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DialogTexts
{
    public static Dialog[] dialogsToaster = new Dialog[2]
    {
        new Dialog("Toaster", new List<string>
        {
            "dialog 1 text 1",
            "dialog 1 text 2"
        }, 0),
        new Dialog("Toaster", new List<string>
        {
            "dialog 2 text 1",
            "dialog 2 text 2"
        })
    };
}
