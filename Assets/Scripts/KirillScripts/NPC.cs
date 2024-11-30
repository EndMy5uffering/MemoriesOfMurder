using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPC : MonoBehaviour // Inheritance of MonoBehaviour here only because you cant inherit 2 abstract classes
{
    protected int STATE_AMOUNT;
    protected Dialog[] dialogs;
    private int state = 0;
    private Animator animator;

    private void Awake()
    {
        gameObject.TryGetComponent<Animator>(out animator);
        Init();
    }
    public abstract void Init();

    public Dialog getDialog()
    {
        Dialog dialog = dialogs[state];
        if (dialog != null)
        {
            return dialog;
        }
        else
        {
            Debug.LogError("The dialog with currest state was not found.");
            return null;
        }
    }

    public void ChangeState (int newState)
    {
        if (newState < 0 || newState >= STATE_AMOUNT)
        {
            Debug.LogError("Cant load new state with this number");
        }
        state = newState;
    }

    public void SetAnimator(bool isAnimatorPlaying)
    {
        if (animator != null)
            animator.SetBool("isTalking", isAnimatorPlaying);
    }
}
