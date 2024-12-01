using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchrankNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsSchrank.Length;
        this.dialogs = DialogTexts.dialogsSchrank;
        voiceIndex = Constants.SCHRANK_INT;
    }

    public void Open()
    {
        if (animator != null)
            animator.SetBool("isOpen", true);
    }
}
