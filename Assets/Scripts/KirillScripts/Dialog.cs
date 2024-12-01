using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialog
{
    public string npcName;
    public List<string> dialogueLines;
    private List<int> startQuestIds;
    private List<int> endQuestIds;
    private List<NpcStatePair> npcStatePairs;

    public Dialog(string npcName, List<string> dialogueLines, List<int> startQuestIds, List<int> endQuestIds, List<NpcStatePair> npcStatePairs)
    {
        this.npcName = npcName;
        this.dialogueLines = dialogueLines;
        this.startQuestIds = startQuestIds;
        this.endQuestIds = endQuestIds;

        if (npcStatePairs == null )
            npcStatePairs = new List<NpcStatePair>();
        this.npcStatePairs = npcStatePairs;
    }

    public List<Quest> GetStartQuests()
    {
        List<Quest> quests = new List<Quest>();
        if (startQuestIds != null)
        {
            foreach (int i in startQuestIds)
            {
                if (i >= 0 && i < QuestTexts.quests.Length)
                    quests.Add(QuestTexts.quests[i]);
            }
        }
        return quests;
    }

    public List<Quest> GetEndQuests()
    {
        List<Quest> quests = new List<Quest>();
        if (endQuestIds != null)
        {
            foreach (int i in endQuestIds)
            {
                if (i >= 0 && i < QuestTexts.quests.Length)
                    quests.Add(QuestTexts.quests[i]);
            }
        }
        return quests;
    }

    public List<NpcStatePair> GetNpcStatePairs()
    {
        return npcStatePairs;
    }
}
