using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaschmaschineNPC : NPC
{
    int tasks = 0;
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsWaschmaschine.Length;
        this.dialogs = DialogTexts.dialogsWaschmaschine;
        voiceIndex = Constants.WASCHMASCHINE_INT;
    }

    public void IncrementTask()
    {
        // implement beep when ready (isReady, true)
        tasks++;
        if (tasks == 1)
        {
            GameManager.Instance.ChangeNpcState(new NpcStatePair(Constants.WASCHMASCHINE, 1));
        }
        if (tasks == 2)
        {
            GameManager.Instance.ChangeNpcState(new NpcStatePair(Constants.WASCHMASCHINE, 2));
            if (animator != null)
                animator.SetBool("isReady", true);
        }
    }
}
