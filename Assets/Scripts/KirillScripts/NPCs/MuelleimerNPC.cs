using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuelleimerNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsMuelleimer.Length;
        this.dialogs = DialogTexts.dialogsMuelleimer;
        voiceIndex = Constants.MUELLEIMER_INT;

    }
}
