using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTexts : MonoBehaviour
{
    public static Quest[] quests = new Quest[2]
    {
        new Quest("Finde die Lappe um den Toaster sauber zu machen.",
            new List <NpcStatePair>()
            {
                //new NpcStatePair (Constants.TOASTER, 1)
            }
            ),
        new Quest("Erhitze das Wasser im Wasserkocher und bringe es zum Bügeleisen.",
            new List <NpcStatePair>()
            {
                //new NpcStatePair (Constants.TOASTER, 1)
            }
            )
    };
}
