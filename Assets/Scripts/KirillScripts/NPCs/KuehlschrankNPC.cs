using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KuehlschrankNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsKuehlschrank.Length;
        this.dialogs = DialogTexts.dialogsKuehlschrank;
        voiceIndex = Constants.KUEHLSCHRANK_INT;
    }

    public void Open()
    {
        if (animator != null)
            animator.SetBool("isOpen", true);
    }

    public void Close()
    {
        if (animator != null)
            animator.SetBool("isOpen", false);
    }
}
