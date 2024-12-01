using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuegeleisenNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsBuegeleisen.Length;
        this.dialogs = DialogTexts.dialogsBuegeleisen;
        voiceIndex = Constants.BUEGELEISEN_INT;
    }
}
