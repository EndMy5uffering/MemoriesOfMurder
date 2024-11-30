using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestListWindow : MonoBehaviour
{
    [SerializeField]
    private Transform container;

    [SerializeField]
    private GameObject _questWindowPrefab;

    public void LocateQuests(List<Quest> quests)
    {
        ClearChildren(container);
        foreach (Quest quest in quests)
        {
            GameObject go = Instantiate(_questWindowPrefab);
            go.transform.SetParent(container);
            go.GetComponent<QuestWindow>().SetText(quest.GetDescription());
        }
    }

    public void ClearChildren(Transform parent)
    {
        for (int i = parent.transform.childCount - 1; i >= 0; i--)
        {
            Destroy(parent.GetChild(i).gameObject);
        }
    }
}
