using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Run : StateMachineBehaviour
{
    [SerializeField] string currentPlayer;

    public float speed = 2.5f;
    public float attackRange = 3f;

    Transform player;
    Rigidbody2D rb;
    Vector2 target, newPos;
    Boss boss;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       player = GameObject.FindGameObjectWithTag(currentPlayer).transform;
       rb = animator.GetComponent<Rigidbody2D>();
       boss = animator.GetComponent<Boss>();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        boss.LookAtPlayer();

        target = new Vector2(player.position.x, rb.position.y);
        newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
        rb.MovePosition(newPos);

        if (Vector2.Distance(player.position, rb.position) <= attackRange)
        {
            animator.SetTrigger("Attack");
        } 
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack");
    }

    
}
