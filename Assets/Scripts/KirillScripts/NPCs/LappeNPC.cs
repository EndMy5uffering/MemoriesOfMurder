using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LappeNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsLappe.Length;
        this.dialogs = DialogTexts.dialogsLappe;
        voiceIndex = Constants.LAPPE_INT;
    }
}
