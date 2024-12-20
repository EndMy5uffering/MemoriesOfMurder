using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasserkocherNPC : NPC
{
    public override void Init()
    {
        this.STATE_AMOUNT = DialogTexts.dialogsWasserkocher.Length;
        this.dialogs = DialogTexts.dialogsWasserkocher;
        voiceIndex = Constants.WASSERKOCHER_INT;
    }

    public void PlayOpenWasserkocher()
    {
        // anim
        if (animator != null)
            animator.SetBool("isOpen", true);
    }

    public void PlayWasserkocherWirdGefuellt()
    {
        // anim
        if (animator != null)
            animator.SetTrigger("Fill");
        StartCoroutine(UpdateWasserkocherStateAfterAusfuellung(3));
    }

    private IEnumerator UpdateWasserkocherStateAfterAusfuellung(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        GameManager.Instance.ChangeNpcState(new NpcStatePair(Constants.WASSERKOCHER, 3));
        GameManager.Instance.ChangeNpcState(new NpcStatePair(Constants.WASSERHAHN, 0));
        GameManager.Instance.ChangeNpcState(new NpcStatePair(Constants.WASSERHAHN, -2));
        PlayCloseWasserkocher();
    }

    private void PlayCloseWasserkocher()
    {
        if (animator != null)
            animator.SetBool("isOpen", false);
    }
}
