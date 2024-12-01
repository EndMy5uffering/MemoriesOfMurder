using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameScene : MonoBehaviour
{
    // It is the main script, you will have to interact with.
    // Other scripts, that I created, that you have to read and understand: 
    // 
    [HideInInspector]
    public static UnityEvent onLeftClickEvent = new UnityEvent(); // Callback for left click. It will continue the dialog.
    [HideInInspector]
    public static UnityEvent<NPC> onInteractionWithNpcEvent = new UnityEvent<NPC>(); // Callback for interaction with NPC. 

    private void Awake()
    {
        onInteractionWithNpcEvent.AddListener(StartDialog);
        onLeftClickEvent.AddListener(ContinueDialog);
    }

    private void ContinueDialog()
    {
        if (DialogManager.Instance.isDialogActive)
            DialogManager.Instance.DisplayNextSentence();
    }

    private void StartDialog(NPC npc)
    {
        DialogManager.Instance.StartDialogue(npc);
    }
}
