using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DialogTexts
{

    public static Dialog[] dialogsBoombox = new Dialog[4]
    {
         new Dialog(Constants.BOOMBOX,
            new List<string>
        {
            "Nichts hilft mehr beim Nachdenken als die richtige Musik!",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.BOOMBOX, 1),
                //new NpcStatePair(Constants.BOOMBOX, -1)
            }
            ),
         new Dialog(Constants.BOOMBOX,
            new List<string>
        {
            "Vielleicht hilft dir ja das mehr beim denken.",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.BOOMBOX, 2)
            }
            ),
         new Dialog(Constants.BOOMBOX,
            new List<string>
        {
            "Oder doch lieber das hier?",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.BOOMBOX, 3)
            }
            ),
         new Dialog(Constants.BOOMBOX,
            new List<string>
        {
            "Das muss der richtige Tune sein."
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.BOOMBOX, 0)
            }
            )
    };
    public static Dialog[] dialogsBuegeleisen = new Dialog[4]
    {
        new Dialog(Constants.BUEGELEISEN,
            new List<string>
        {
            "Mein Mund ist so trocken und kalt ist mir auch.",
            "Kannst du mir nicht ein bisschen heißes Wasser bringen?",
        },
            new List<int>
            {
                1
            },
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.BUEGELEISEN, 1),
                new NpcStatePair(Constants.WASSERKOCHER, 1)
            }
            ),
        new Dialog(Constants.BUEGELEISEN,
            new List<string>
        {
            "Kannst du mir nicht ein bisschen heißes Wasser bringen?",
        },
            null,
            null,
            null
            ),
        new Dialog(Constants.BUEGELEISEN,
            new List<string>
        {
            "Ah... Das tut gut.",
            "Papa war wirklich froh das Mama schnell noch ein Hemd für ihn gebügelt hat.",
            "Ich bin mir auch sicher dass er ihr nie was antuen würde.",
        },
            null,
            new List<int>
            {
                1
            },
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.BUEGELEISEN, 3),
                new NpcStatePair(Constants.WASSERKOCHER, -3)
            }
            ),
        new Dialog(Constants.BUEGELEISEN,
            new List<string>
        {
            "Papa war wirklich froh das Mama schnell noch ein Hemd für ihn gebügelt hat.",
            "Ich bin mir auch sicher dass er ihr nie was antuen würde.",
        },
            null,
            null,
            null
            )
    };
    public static Dialog[] dialogsFernseher = new Dialog[3]
    {
        new Dialog(Constants.FERNSEHER,
            new List<string>
        {
            "Möchtest du wieder die drei Fragezeichen sehen?",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.FERNSEHER, 1)
            }
            ),
        new Dialog(Constants.FERNSEHER,
            new List<string>
        {
            "Wann löst du denn deinen 1. Fall?",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.FERNSEHER, 2)
            }
            ),
        new Dialog(Constants.FERNSEHER,
            new List<string>
        {
            "Sherlock Holmes ist noch nichts für dich."
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.FERNSEHER, 0)
            }
            ),
    };
    public static Dialog[] dialogsHocker = new Dialog[4]
    {
        new Dialog(Constants.HOCKER,
            new List<string>
        {
            "Wo klettern wir denn dieses Mal zusammen hoch?",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.HOCKER, 1)
            }
            ),
        new Dialog(Constants.HOCKER,
            new List<string>
        {
            "Auf ins nächste Abenteuer!",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.HOCKER, 2)
            }
            ),
        new Dialog(Constants.HOCKER,
            new List<string>
        {
            "Hau ruck! Hau ruck! Hau ruck!",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.HOCKER, 3)
            }
            ),
        new Dialog(Constants.HOCKER,
            new List<string>
        {
            "Ganz hoch hinaus!",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.HOCKER, 0)
            }
            ),
    };
    public static Dialog[] dialogsKuehlschrank = new Dialog[2]
    {
        new Dialog(Constants.KUEHLSCHRANK,
            new List<string>
        {
            "Ich öffne mich",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.KUEHLSCHRANK, 1),
                new NpcStatePair(Constants.KUEHLSCHRANK, -1)
            }
            ),
        new Dialog(Constants.KUEHLSCHRANK,
            new List<string>
        {
            "Ich schließe mich.",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.KUEHLSCHRANK, 0),
                new NpcStatePair(Constants.KUEHLSCHRANK, -2)
            }
            ),
    };
    public static Dialog[] dialogsLappe = new Dialog[2]
{
        new Dialog(Constants.LAPPE,
            new List<string>
        {
            "Captain Blitzeblank schläft.",
        },
            null,
            null,
            null),
        new Dialog(Constants.LAPPE,
            new List<string>
        {
            "Captain Blitzeblank zu euren diensten o7"
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.TOASTER, 2),
                new NpcStatePair(Constants.LAPPE, 0),
            })
};
    public static Dialog[] dialogsMuelleimer = new Dialog[3]
    {
        new Dialog(Constants.MUELLEIMER,
            new List<string>
        {
            "Dieser Kuchen war soooo lecker, hast du noch ein Stück?"
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.MUELLEIMER, 1),
            }
            ),
        new Dialog(Constants.MUELLEIMER,
            new List<string>
        {
            "Eigentlich muss ich ja auf meine Figur achten… Aber bei einem ganzen Kuchen, kann ich schwer Nein sagen."
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.MUELLEIMER, 2),
            }
            ),
        new Dialog(Constants.MUELLEIMER,
            new List<string>
        {
            "Ich frage mich warum sie</b> kein Stück wollte. Der sah ja auch gut aus."
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.MUELLEIMER, 0),
            }
            )
    };
    public static Dialog[] dialogsLeiche = new Dialog[2]
    {
         new Dialog(Constants.KIND,
            new List<string>
        {
            "Meine Mutter ist getötet (",
            "Das bedeutet, ich kann ein Detective Spiel anfange, yupiii!"
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.LEICHE, 1),
                new NpcStatePair(Constants.LEICHE, -1)
            }
            ),
         new Dialog(Constants.LEICHE,
            new List<string>
        {
            "...",
        },
            null,
            null,
            null
            ),
    };
    public static Dialog[] dialogsOrangensaft = new Dialog[2]
{
    new Dialog(Constants.ORANGENSAFT,
            new List<string>
        {
            "Hattest du nicht vorhin erst von mir getrunken?",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.ORANGENSAFT, 1)
            }
            ),
    new Dialog(Constants.ORANGENSAFT,
            new List<string>
        {
            "Hab ich dir vorhin so gut geschmeckt?",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.ORANGENSAFT, 0)
            }
            ),
};
    public static Dialog[] dialogsPillen = new Dialog[5]
    {
        new Dialog(Constants.PILLEN,
            new List<string>
        {
            "DU SCHON WIEDER! VERSCHWINDE!",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.PILLEN, 1)
            }
            ),
        new Dialog(Constants.PILLEN,
            new List<string>
        {
            "DU BRAUCHST DOCH KEINE SCHLAFPILLEN!",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.PILLEN, 2)
            }
            ),
        new Dialog(Constants.PILLEN,
            new List<string>
        {
            "5 VON UNS HAST DU BEREITS GEKLAUT UND <b>ERTRÄNKT</b>.",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.PILLEN, 3)
            }
            ),
        new Dialog(Constants.PILLEN,
            new List<string>
        {
            "DU HAST SIE GETÖTET!",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.PILLEN, 4)
            }
            ),
        new Dialog(Constants.PILLEN,
            new List<string>
        {
            "BLEIB NUR WEG MIT DEM <b>ORANGENSAFT</b>.",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.PILLEN, 0)
            }
            ),
    };
    public static Dialog[] dialogsSchluessel = new Dialog[2]
    {
        new Dialog(Constants.SCHLUESSEL,
            new List<string>
        {
            "Sollst du nicht die Finger von uns lassen?",
            "Papa und Mama wollen doch nicht, dass du mit uns spielst."
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.SCHLUESSEL, -1),
                new NpcStatePair(Constants.SCHLUESSEL, 1),
                new NpcStatePair(Constants.SCHRANK, 1)
            }
            ),
        new Dialog(Constants.SCHLUESSEL,
            new List<string>
        {

        },
            null,
            null,
            null
            )
    };
    public static Dialog[] dialogsSchrank = new Dialog[3]
   {
        new Dialog(Constants.SCHRANK,
            new List<string>
        {
            "Ich bin geschlossen.",
            "Aber wenn du den Schlüssel von mir findest, dann öffne ich dir alle Türe dieser Welt."
        },
            null,
            null,
            null
            ),
        new Dialog(Constants.SCHRANK,
            new List<string>
        {
            "YES, DADDY!!",
        },
            null,
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.SCHRANK, 2),
                new NpcStatePair(Constants.SCHRANK, -1)
            }
            ),
       new Dialog(Constants.SCHRANK,
            new List<string>
        {
            "Mhm...",
        },
            null,
            null,
            null
            ),
   };
    public static Dialog[] dialogsTeekanne = new Dialog[1]
    {
        new Dialog(Constants.TEEKANNE,
            new List<string>
        {
            "Es ist schon nach Teezeit. Mama und Oma haben schon ausgetrunken.",
        },
            null,
            null,
            null
            ),
    };
    public static Dialog[] dialogsToaster = new Dialog[4]
    {
        new Dialog(Constants.TOASTER,
            new List<string>
        {
            "*Eugh, Hust*… Zu… *Hust* viele.. Krümell *Hust, Hust*.",
            "Muss… *Urgh* <b>sauber…</b> *Hust* sein."
        },
            new List<int>
            {
                0
            },
            null,
            new List<NpcStatePair>
            {
                new NpcStatePair(Constants.LAPPE, 1),
                new NpcStatePair(Constants.TOASTER, 1)
            }),
        new Dialog(Constants.TOASTER,
            new List<string>
        {
            "Hast du *Hust* eine Lappe *Hust* gebracht?",
        },
            null,
            null,
            null),
        new Dialog(Constants.TOASTER,
            new List<string>
        {
            "Hast du *Hust* eine Lappe *Hust* gebracht?",
            "Oh, ja. Ohhhhhhh...",
            "...",
            "Danke! Hat Mama der Orangensaft eigentlich geschmeckt?"
        },
            null,
            new List<int>
            {
                0
            },
            new List<NpcStatePair>
            { 
                new NpcStatePair (Constants.TOASTER, 3),
                new NpcStatePair (Constants.TOASTER, -1) //set isClean true
            }),
        new Dialog(Constants.TOASTER,
            new List<string>
        {
            "Hat Mama der Orangensaft eigentlich geschmeckt?"
        },
            null,
            null,
            null)
    };
    public static Dialog[] dialogsVase = new Dialog[1]
    {
        new Dialog(Constants.VASE,
            new List<string>
        {
            "Pflanze 1: Boah, habt ihr das schon wieder mitbekommen?",
            "Pflanze 2: Nein? Wovon redest du?",
            "Pflanze 3: Geht es wieder um diese Nachbarin?",
            "Pflanze 1: Jaja, die war gestern schon wieder hier.",
            "Pflanze 2: Ne, was wollt sie denn dieses Mal?",
            "Pflanze 3: Bestimmt wieder mit Papa reden.",
            "Pflanze 1: Ne dieses mal hat sie einen Kuchen mitgebracht. Extra für Mama gebacken.",
            "Pflanze 3: Ich dachte die hasst Mama…"
        },
            null,
            null,
            null)
    };
    public static Dialog[] dialogsVodka = new Dialog[1]
    {
        new Dialog(Constants.VODKA,
            new List<string>
        {
            "Ich schmeck dir doch eh nicht. Lass mich lieber Papa übrig"
        },
            null,
            null,
            null)
    };
    public static Dialog[] dialogsWaschmaschine = new Dialog[3]
    {
        new Dialog(Constants.WASCHMASCHINE,
            new List<string>
        {
            "Grhnnnnn. Schneller……Ahhhhhhhh………",
            "Schneeeeeeeelllllleeeeeeeeer…"
        },
            null,
            null,
            null),
        new Dialog(Constants.WASCHMASCHINE,
            new List<string>
        {
            "Iiiiiiich… biiiiiiiiiin… baaaalld… feeeertiiiiiiiiiiiig"
        },
            null,
            null,
            null),
        new Dialog(Constants.WASCHMASCHINE,
            new List<string>
        { 
            "Weißt du? Auch wenn Oma manchmal etwas grausam zu Mama ist, ist sie doch viel zu <b>lieb</b> um etwas böses zu tun."
        },
            null,
            null,
            null)
    };
    public static Dialog[] dialogsWasserhahn = new Dialog[4]
    {
        new Dialog(Constants.WASSERHAHN,
            new List<string>
        {
            "Ohhh, jaaaa. Das tut gut."
        },
            null,
            null,
            new List<NpcStatePair>
            {
                // Here Action for Wasser Aufmachen

                new NpcStatePair (Constants.WASSERHAHN, 1),
                new NpcStatePair (Constants.WASSERHAHN, -1),
            }),
        new Dialog(Constants.WASSERHAHN,
            new List<string>
        {
            "Nein. Nein. Nein, warte! Ich bin noch nicht fertig."
        },
            null,
            null,
            new List<NpcStatePair>
            {
                // Here Action for Wasser Ausmachen

                new NpcStatePair (Constants.WASSERHAHN, 0),
                new NpcStatePair (Constants.WASSERHAHN, -2),
            }),
        new Dialog(Constants.WASSERHAHN,
            new List<string>
        {

        },
            null,
            null,
            new List<NpcStatePair>
            {
                // Here Action for Wasser Ausmachen
                new NpcStatePair (Constants.WASSERKOCHER, -2),
                new NpcStatePair (Constants.WASSERHAHN, 3),
                new NpcStatePair (Constants.WASSERHAHN, -2),
            }),
        new Dialog(Constants.WASSERHAHN,
            new List<string>
        {

        },
            null,
            null,
            new List<NpcStatePair>
            {
                // Here Action for Wasser Ausmachen
                //new NpcStatePair (Constants.WASSERKOCHER, 3),
                new NpcStatePair (Constants.WASSERHAHN, 1),
                new NpcStatePair (Constants.WASSERHAHN, -1),
                new NpcStatePair (Constants.WASSERKOCHER, -4)
            })
    };
    public static Dialog[] dialogsWasserkocher = new Dialog[5]
    {
        new Dialog(Constants.WASSERKOCHER,
            new List<string>
        {
            "Ich finde deine Worte überflüssig.",
            "Haha, verstanden? Überflüssig! Haha."
        },
            null,
            null,
            null
            ),
        new Dialog(Constants.WASSERKOCHER,
            new List<string>
        {
            "Willst du dir wieder einen Tee machen?"
        },
            null,
            null,
            new List<NpcStatePair>
            {
                // Wasserhahn bereitstellen
                new NpcStatePair (Constants.WASSERHAHN, 2),
                new NpcStatePair (Constants.WASSERKOCHER, -1),
                new NpcStatePair (Constants.WASSERKOCHER, 2)
            }),
        new Dialog(Constants.WASSERKOCHER,
            new List<string>
        {

        },
            null,
            null,
            null),
        new Dialog(Constants.WASSERKOCHER, 
            new List<string>
        {
            "Und wieder in deine Hände, wie süß!"
        },
            null,
            null,
            new List<NpcStatePair>
            {
                // Wasserhahn bereitstellen
                new NpcStatePair (Constants.WASSERKOCHER, -1),
                new NpcStatePair (Constants.WASSERKOCHER, 4),
                new NpcStatePair (Constants.BUEGELEISEN, 2)
            }),
        new Dialog(Constants.WASSERKOCHER,
            new List<string>
        {

        },
            null,
            null,
            null
            ),
    };
}
