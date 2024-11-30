using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasserhahnNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsWasserhahn.Length;
        this.dialogs = DialogTexts.dialogsWasserhahn;
        voiceIndex = Constants.WASSERHAHN_INT;
    }
}
