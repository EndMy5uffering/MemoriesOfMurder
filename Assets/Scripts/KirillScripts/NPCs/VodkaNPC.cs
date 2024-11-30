using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VodkaNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsVodka.Length;
        this.dialogs = DialogTexts.dialogsVodka;
        voiceIndex = Constants.VODKA_INT;
    }
}
