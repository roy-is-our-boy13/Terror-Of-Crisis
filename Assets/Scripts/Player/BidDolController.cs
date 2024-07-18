using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BidDolController : CharaterController
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
        animator.Play("BidDol_Punch");
    }

    public void Kick()
    {
       animator.Play("BidDol_Kick");
    }

    public void Jump()
    {
        //animator.Play("FlitterMouse_Jump");
    }
}
