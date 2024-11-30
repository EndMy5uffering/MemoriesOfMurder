using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangensaftNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsOrangensaft.Length;
        this.dialogs = DialogTexts.dialogsOrangensaft;
        voiceIndex = Constants.ORANGENSAFT_INT;
    }
}
