using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillenNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsPillen.Length;
        this.dialogs = DialogTexts.dialogsPillen;
        voiceIndex = Constants.PILLEN_INT;
    }
}
