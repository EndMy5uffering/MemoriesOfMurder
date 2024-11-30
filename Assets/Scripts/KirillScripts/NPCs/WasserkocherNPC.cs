using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasserkocherNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsWasserkocher.Length;
        this.dialogs = DialogTexts.dialogsWasserkocher;
        voiceIndex = Constants.WASSERKOCHER_INT;
    }
}
