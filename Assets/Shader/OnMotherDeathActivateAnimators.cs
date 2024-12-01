using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class OnMotherDeathActivateAnimators : MonoBehaviour
{
    public static UnityEvent OnMotherDeathDiscovered;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        OnMotherDeathDiscovered.AddListener(ActivateAnimator);
        animator = GetComponent<Animator>();
    }
    
    
    private void ActivateAnimator()
    {
        animator.enabled = true;
        Destroy(this);
    }
}
