using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBronzeController1 : CharaterController
{

    public void OnEnable()
    {
        gameObject.name = "FlyBronze";

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
        animator.Play("FlyBronze_Punch");
    }

    public void Kick()
    {
        animator.Play("FlyBronze_Kick");
    }

    public void Jump()
    {
        animator.Play("FlyBronze_Jump");
    }

}
