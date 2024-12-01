using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeicheNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsLeiche.Length;
        this.dialogs = DialogTexts.dialogsLeiche;
        voiceIndex = Constants.TOASTER_INT;
    }
}
