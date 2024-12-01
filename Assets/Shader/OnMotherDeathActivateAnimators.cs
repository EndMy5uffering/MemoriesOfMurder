using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class OnMotherDeathActivateAnimators : MonoBehaviour
{
    public static UnityEvent OnMotherDeathDiscovered;
    private Animator animator;
    void Start()
    {
        OnMotherDeathDiscovered.AddListener(ActivateAnimator);
        animator = GetComponent<Animator>();
    }
    private void ActivateAnimator()
    {
        animator.enabled = true;
        Destroy(this);
        OnMotherDeathDiscovered.RemoveListener(ActivateAnimator);
    }
}
