using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialog
{
    public string npcName;
    public List<string> dialogueLines;
    private int questId;

    public Dialog(string npcName, List<string> dialogueLines, int questId)
    {
        this.npcName = npcName;
        this.dialogueLines = dialogueLines;
        Debug.Log("I try to create Dialog with questId = " + questId);
        this.questId = questId;
        Debug.Log("My quest is: " + questId);
    }

    public Dialog(string npcName, List<string> dialogueLines)
    {
        this.npcName = npcName;
        this.dialogueLines = dialogueLines;
    }

    public Quest GetQuest()
    {
        if (questId == -1 || questId >= QuestTexts.quests.Length)
            return null;
        return QuestTexts.quests[questId];
    }
}
