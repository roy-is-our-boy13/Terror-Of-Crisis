using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlitterMouseController : CharaterController
{
    
public void OnEnable()
    {
        gameObject.name = "HumanStrike";

        Attack1 += Punch;
        Attack2 += Kick;
        JumpUp += Jump;

    }

    public void OnDisable()
    {
        Attack1 -= Punch;
        Attack2 -= Kick;
        JumpUp -= Jump;
    }

    public void Punch()
    {
        animator.Play("FlitterMouse_Punch");
    }

    public void Kick()
    {
       animator.Play("FlitterMouse_Kick");
    }

    public void Jump()
    {
        animator.Play("FlitterMouse_Jump");
    }
}
