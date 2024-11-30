using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaschmaschineNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsWaschmaschine.Length;
        this.dialogs = DialogTexts.dialogsWaschmaschine;
        voiceIndex = Constants.WASCHMASCHINE_INT;
    }
}
