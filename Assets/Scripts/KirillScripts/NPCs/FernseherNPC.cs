using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FernseherNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsFernseher.Length;
        this.dialogs = DialogTexts.dialogsFernseher;
        voiceIndex = Constants.FERNSEHER_INT;
    }
}
