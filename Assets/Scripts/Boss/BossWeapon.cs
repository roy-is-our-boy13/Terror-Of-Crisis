using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon :MeleeEnemy
{
    public int attackDamage = 20;
	public int enragedAttackDamage = 40;

	public Vector3 attackOffset;
	public float attackRange = 1f;
	public LayerMask attackMask;
/*
	[Header("Collider Parameters")]
    [SerializeField] private float colliderDistance;
    [SerializeField]private BoxCollider2D boxCollider;

    [Header("Player Parameters")]
    [SerializeField] private LayerMask playerLayer;
    private float cooldownTimer = Mathf.Infinity;*/

	public void Attack()
	{
		Vector3 pos = transform.position;
		pos += transform.right * attackOffset.x;
		pos += transform.up * attackOffset.y;

		Collider2D colInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);
		
		/*
		if (colInfo != null)
		{
			colInfo.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
		}*/
	}

	public void EnragedAttack()
	{
		Vector3 pos = transform.position;
		pos += transform.right * attackOffset.x;
		pos += transform.up * attackOffset.y;

		Collider2D colInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);
		/*if (colInfo != null)
		{
			colInfo.GetComponent<PlayerHealth>().TakeDamage(enragedAttackDamage);
		}*/
	}
    
	void OnDrawGizmosSelected()
	{
		Vector3 pos = transform.position;
		pos += transform.right * attackOffset.x;
		pos += transform.up * attackOffset.y;

		Gizmos.DrawWireSphere(pos, attackRange);
	}
}
