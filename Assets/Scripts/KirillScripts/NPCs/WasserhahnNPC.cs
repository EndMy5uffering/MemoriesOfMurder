using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasserhahnNPC : NPC
{
    bool isOn = false;
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsWasserhahn.Length;
        this.dialogs = DialogTexts.dialogsWasserhahn;
        voiceIndex = Constants.WASSERHAHN_INT;
    }

    public void WasserhahnOn(bool isOn)
    {
        this.isOn = isOn;
        if (animator != null)
            animator.SetBool("isOn", isOn);
    }
}
