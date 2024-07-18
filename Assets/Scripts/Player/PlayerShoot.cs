using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : PlayerAttack
{
    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    } 


    private void Update()
    {
        if (Input.GetKey(KeyCode.C) && cooldownTimer > attackCooldown && playerMovement.canAttack())
        { 
            Attack();
        }

        cooldownTimer += Time.deltaTime;
    }


    public void Attack()
    {
        SoundManager.instance.PlaySound(fireballSound);
        anim.SetTrigger("attack");
        cooldownTimer = 0;

        fireballs[FindFireball()].transform.position = firePoint.position;
        fireballs[FindFireball()].GetComponent<Projectile>().SetDirection(Mathf.Sign(transform.localScale.x));
      
    }

    public int FindFireball()
    {
        for (int i = 0; i < fireballs.Length; i++)
        {
            if (!fireballs[i].activeInHierarchy)
            {
                return i;
            }
        }
        return 0;
    }

}
