using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomboxNPC : NPC
{
    int curSongId = 0;
    const int SONG_AMOUNT = 3;
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsBoombox.Length;
        this.dialogs = DialogTexts.dialogsBoombox;
        voiceIndex = Constants.BOOMBOX_INT;
    }

    public void SwitchSong()
    {
        curSongId = (curSongId + 1) % SONG_AMOUNT;
    }
}
