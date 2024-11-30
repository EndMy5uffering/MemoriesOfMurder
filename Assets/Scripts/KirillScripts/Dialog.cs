using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialog
{
    public string npcName;
    public List<string> dialogueLines;

    public Dialog(string npcName, List<string> dialogueLines)
    {
        this.npcName = npcName;
        this.dialogueLines = dialogueLines;
    }
}
