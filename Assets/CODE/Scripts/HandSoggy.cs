using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandSoggy : MonoBehaviour
{
    public float speed;
    Animator animator;
    private float gripTarget;
    private float scissorsTarget;
    private float gripCurrent;
    private float scissorsCurrent;

    private string animatorGripParam = "Grip";
    private string animatorScissorsParam = "Scissors";
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimateHand();
    }

    internal void SetGrip(float v)
    {
        gripTarget = v;
    }

    internal void SetScissors(float v)
    {
        scissorsTarget = v;
    }

    void AnimateHand() 
    {
        if (gripCurrent != gripTarget)
        {
            gripCurrent = Mathf.MoveTowards(gripCurrent, gripTarget, Time.deltaTime * speed);
            animator.SetFloat(animatorGripParam, gripCurrent);
        }
        if (scissorsCurrent != gripTarget)
        {
            scissorsCurrent = Mathf.MoveTowards(scissorsCurrent, gripTarget, Time.deltaTime * speed);
            animator.SetFloat(animatorScissorsParam, scissorsCurrent);
        }

    }
}
