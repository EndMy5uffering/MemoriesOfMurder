using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsVase.Length;
        this.dialogs = DialogTexts.dialogsVase;
        voiceIndex = Constants.VASE_INT;
    }
}
