using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeekanneNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsTeekanne.Length;
        this.dialogs = DialogTexts.dialogsTeekanne;
        voiceIndex = Constants.TEEKANNE_INT;
    }
}
