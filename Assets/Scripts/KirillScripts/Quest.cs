using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Quest
{
    private string description;
    private List<NpcStatePair> effect;

    public Quest(string description, List<NpcStatePair> effect) {
        this.description = description;
        this.effect = effect;
    }

    public string GetDescription()
    {
        return description;
    }

    public void StartQuest()
    {

    }

    public void EndQuest()
    {
        foreach (NpcStatePair pair in effect)
        {
            GameManager.Instance.ChangeNpcState(pair);
        }
    }
}
