using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToasterNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsToaster.Length;
        this.dialogs = DialogTexts.dialogsToaster;
    }
}
