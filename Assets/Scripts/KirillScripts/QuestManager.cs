using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static QuestManager Instance;

    [HideInInspector]
    public List<Quest> quests;

    [SerializeField]
    private QuestListWindow questListWindow;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void StartQuest(Quest quest)
    {
        quests.Add(quest);
        questListWindow.LocateQuests(quests);
    }
    public void EndQuest(Quest quest)
    {
        quests.Remove(quest);
        questListWindow.LocateQuests(quests);
    }

}
