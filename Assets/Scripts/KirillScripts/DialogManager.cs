using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public static DialogManager Instance;

    [SerializeField]
    private DialogWindow dialogWindow;

    private Queue<string> sentences;

    private bool isDialogActive = false;
    private NPC curNpc;
    private Dialog curDialog;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        sentences = new Queue<string>();
    }

    public void StartDialogue(NPC npc)
    {
        if (!isDialogActive)
        {
            curDialog = npc.getDialog();

            if (curDialog != null)
            {
                curNpc = npc;
                npc.SetAnimator(true);

                isDialogActive = true;
                dialogWindow.gameObject.SetActive(true);
                sentences.Clear();

                foreach (string line in curDialog.dialogueLines)
                {
                    sentences.Enqueue(line);
                }

                dialogWindow.SetTitle(curDialog.npcName);
                DisplayNextSentence();
            }
        }
    }

    public void DisplayNextSentence()
    {
        if (!isDialogActive)
        {
            Debug.LogError("There is no dialog active, but you try to coninue the dialog!");
        }
        else
        {
            if (sentences.Count == 0)
            {
                EndDialog();
                return;
            }

            string sentence = sentences.Dequeue();
            dialogWindow.SetMessage(sentence);
        }
    }

    private void EndDialog()
    {
        if (curNpc != null)
            curNpc.SetAnimator(false);
        curNpc = null;
        Quest quest = curDialog.GetQuest();
        if (quest != null)
            QuestManager.Instance.StartQuest(quest);
        Debug.Log(quest);
        curDialog = null;

        dialogWindow.SetTitle("");
        dialogWindow.SetMessage("");
        dialogWindow.gameObject.SetActive(false);
        isDialogActive = false;
    }
}
