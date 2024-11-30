using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private BoomboxNPC boombox;
    [SerializeField]
    private BuegeleisenNPC buegeleisen;
    [SerializeField]
    private FernseherNPC fernseher;
    [SerializeField]
    private HockerNPC hocker;
    [SerializeField]
    private KuehlschrankNPC kuehlschrank;
    [SerializeField]
    private LappeNPC lappe;
    [SerializeField]
    private MuelleimerNPC muelleimer;
    [SerializeField]
    private OrangensaftNPC orangensaft;
    [SerializeField]
    private PillenNPC pillen;
    [SerializeField]
    private SchluesselNPC schluessel;
    [SerializeField]
    private TeekanneNPC teekanne;
    [SerializeField]
    private ToasterNPC toaster;
    [SerializeField]
    private VaseNPC vase;
    [SerializeField]
    private VodkaNPC vodka;
    [SerializeField]
    private WaschmaschineNPC waschmaschine;
    [SerializeField]
    private WasserhahnNPC wasserhahn;
    [SerializeField]
    private WasserkocherNPC wasserkocher;

    public static GameManager Instance;
    // Start is called before the first frame update

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeNpcState(NpcStatePair npcStatePair)
    {
        switch (npcStatePair.npc) 
        {
            case Constants.BOOMBOX:
                if (npcStatePair.state == -1)
                {
                    boombox.SwitchSong();
                }
                boombox.ChangeState(npcStatePair.state);
                break;
            case Constants.BUEGELEISEN:
                buegeleisen.ChangeState(npcStatePair.state);
                break;
            case Constants.FERNSEHER:
                fernseher.ChangeState(npcStatePair.state);
                break;
            case Constants.HOCKER:
                hocker.ChangeState(npcStatePair.state);
                break;
            case Constants.KUEHLSCHRANK:
                kuehlschrank.ChangeState(npcStatePair.state);
                break;
            case Constants.LAPPE:
                lappe.ChangeState(npcStatePair.state);
                break;
            case Constants.MUELLEIMER:
                muelleimer.ChangeState(npcStatePair.state);
                break;
            case Constants.ORANGENSAFT:
                orangensaft.ChangeState(npcStatePair.state);
                break;
            case Constants.PILLEN:
                pillen.ChangeState(npcStatePair.state);
                break;
            case Constants.SCHLUESSEL:
                schluessel.ChangeState(npcStatePair.state);
                break;
            case Constants.TEEKANNE:
                teekanne.ChangeState(npcStatePair.state);
                break;
            case Constants.TOASTER:
                toaster.ChangeState(npcStatePair.state);
                break;
            case Constants.VASE:
                vase.ChangeState(npcStatePair.state);
                break;
            case Constants.VODKA:
                vodka.ChangeState(npcStatePair.state);
                break;
            case Constants.WASCHMASCHINE:
                waschmaschine.ChangeState(npcStatePair.state);
                break;
            case Constants.WASSERHAHN:
                wasserhahn.ChangeState(npcStatePair.state);
                break;
            case Constants.WASSERKOCHER:
                wasserkocher.ChangeState(npcStatePair.state);
                break;
            default:
                break;
        }
    }
}
