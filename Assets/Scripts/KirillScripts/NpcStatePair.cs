using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcStatePair
{
    public readonly string npc;
    public readonly int state;

    public NpcStatePair(string npc, int state)
    {
        this.npc = npc;
        this.state = state;
    }
}
