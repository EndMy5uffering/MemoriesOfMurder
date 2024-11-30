using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchluesselNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsSchluessel.Length;
        this.dialogs = DialogTexts.dialogsSchluessel;
        voiceIndex = Constants.SCHLUESSEL_INT;
    }
}
