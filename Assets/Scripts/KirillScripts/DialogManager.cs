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
            Dialog dialog = npc.getDialog();

            if (dialog != null)
            {
                isDialogActive = true;
                dialogWindow.gameObject.SetActive(true);
                sentences.Clear();

                foreach (string line in dialog.dialogueLines)
                {
                    sentences.Enqueue(line);
                }

                dialogWindow.SetTitle(dialog.npcName);
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
                EndDialogue();
                return;
            }

            string sentence = sentences.Dequeue();
            dialogWindow.SetMessage(sentence);
        }
    }

    private void EndDialogue()
    {
        dialogWindow.SetTitle("");
        dialogWindow.SetMessage("");
        dialogWindow.gameObject.SetActive(false);
        isDialogActive = false;
    }
}
