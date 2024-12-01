using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTexts : MonoBehaviour
{
    public static Quest[] quests = new Quest[2]
    {
        new Quest("Finde die Lappe und mache den Toaster sauber.",
            new List <NpcStatePair>()
            {
                new NpcStatePair (Constants.WASCHMASCHINE, -1)
            }
            ),
        new Quest("Gie�e das Wasser in den Wasserkocher rein und bringe ihn zum B�geleisen.",
            new List <NpcStatePair>()
            {
                new NpcStatePair (Constants.WASCHMASCHINE, -1)
            }
            )
    };
}
