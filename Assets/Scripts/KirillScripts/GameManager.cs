using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

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
    private LeicheNPC leiche;
    [SerializeField]
    private MuelleimerNPC muelleimer;
    [SerializeField]
    private OrangensaftNPC orangensaft;
    [SerializeField]
    private PillenNPC pillen;
    [SerializeField]
    private SchluesselNPC schluessel;
    [SerializeField]
    private SchrankNPC schrank;
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

    public UnityEvent<bool> onTakeWasserkocherEvent = new UnityEvent<bool>();
    public UnityEvent<bool> onTakeKeyEvent = new UnityEvent<bool>();
    public UnityEvent<bool> onTakeLappenEvent = new UnityEvent<bool>();

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
                if (npcStatePair.state < 0)
                {
                    if (npcStatePair.state == -1)
                        kuehlschrank.Open();
                    if (npcStatePair.state == -2)
                        kuehlschrank.Close();
                }
                else
                    kuehlschrank.ChangeState(npcStatePair.state);
                break;
            case Constants.LAPPE:
                if (npcStatePair.state < 0)
                {
                    if (npcStatePair.state == -1)
                        onTakeLappenEvent.Invoke(true);
                    if (npcStatePair.state == -2)
                        onTakeLappenEvent.Invoke(false);
                }
                else
                    lappe.ChangeState(npcStatePair.state);
                break;
            case Constants.LEICHE:
                if (npcStatePair.state < 0)
                {
                    if (npcStatePair.state == -1)
                    {
                        if (OnMotherDeathActivateAnimators.OnMotherDeathDiscovered != null)
                            OnMotherDeathActivateAnimators.OnMotherDeathDiscovered.Invoke();
                    }
                }
                else
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
                if (npcStatePair.state < 0)
                {
                    if (npcStatePair.state == -1)
                        onTakeKeyEvent.Invoke(true);
                    if (npcStatePair.state == -2)
                        Destroy(schluessel.gameObject);
                }
                else
                    schluessel.ChangeState(npcStatePair.state);
                break;
            case Constants.SCHRANK:
                if (npcStatePair.state < 0)
                {
                    if (npcStatePair.state == -1)
                        schrank.Open();
                }
                else
                    schrank.ChangeState(npcStatePair.state);
                break;
            case Constants.TEEKANNE:
                teekanne.ChangeState(npcStatePair.state);
                break;
            case Constants.TOASTER:
                if (npcStatePair.state < 0)
                {
                    if (npcStatePair.state != -1)
                        toaster.PlayCleanAnimation();
                }
                else
                    toaster.ChangeState(npcStatePair.state);
                break;
            case Constants.VASE:
                vase.ChangeState(npcStatePair.state);
                break;
            case Constants.VODKA:
                vodka.ChangeState(npcStatePair.state);
                break;
            case Constants.WASCHMASCHINE:
                if (npcStatePair.state < 0)
                {
                    if (npcStatePair.state == -1)
                        waschmaschine.IncrementTask();
                }
                else
                    waschmaschine.ChangeState(npcStatePair.state);
                break;
            case Constants.WASSERHAHN:
                if (npcStatePair.state < 0)
                {
                    if (npcStatePair.state == -1)
                        wasserhahn.WasserhahnOn(true);
                    if (npcStatePair.state == -2)
                        wasserhahn.WasserhahnOn(false);
                }
                else
                    wasserhahn.ChangeState(npcStatePair.state);
                break;
            case Constants.WASSERKOCHER:
                if (npcStatePair.state < 0)
                {
                    if (npcStatePair.state == -1)
                        onTakeWasserkocherEvent.Invoke(true);
                    if (npcStatePair.state == -2)
                    {
                        wasserkocher.PlayOpenWasserkocher();
                        onTakeWasserkocherEvent.Invoke(false);
                    }
                    if (npcStatePair.state == -3)
                        Destroy(wasserkocher.gameObject);
                    if (npcStatePair.state == -4)
                        wasserkocher.PlayWasserkocherWirdGefuellt();
                }
                else
                    wasserkocher.ChangeState(npcStatePair.state);
                break;
            default:
                break;
        }
    }
}
