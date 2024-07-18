using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanStrikeController : CharaterController
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
        animator.Play("HumanStrike_Punch");
    }

    public void Kick()
    {
       animator.Play("HumanStrike_Kick");
    }

    public void Jump()
    {
        //animator.Play("FlyBronze_Jump");
    }

}

