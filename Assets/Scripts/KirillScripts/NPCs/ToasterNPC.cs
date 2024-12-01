using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToasterNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsToaster.Length;
        this.dialogs = DialogTexts.dialogsToaster;
        voiceIndex = Constants.TOASTER_INT;
    }
    public void PlayCleanAnimation()
    {
        if (animator != null)
            animator.SetBool("isClean", true);
    }
}
