using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HockerNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsHocker.Length;
        this.dialogs = DialogTexts.dialogsHocker;
        voiceIndex = Constants.HOCKER_INT;
    }
}
