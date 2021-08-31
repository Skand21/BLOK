using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAnimation : MonoBehaviour
{
    public static HeroAnimation HeroAnimationPortal;
    Animator animator;

    private void Awake()
    {
        HeroAnimationPortal = this;
    }

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void Jump()
    {
        animator.Play("jump");
    }
    public void Hit()
    {
        animator.Play("hit");
    }
    public void jump()
    {
        animator.Play("death");
    }
    public void Death()
    {
        //animator.Play("death");
    }
}
