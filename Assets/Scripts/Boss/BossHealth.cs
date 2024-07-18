using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int health = 5;

	public GameObject deathEffect;

	public bool isInvulnerable = false;

	public void TakeDamage(int damage)
	{
		if (isInvulnerable)
		{
			return;
		}

		health -= damage;

		if (health <= 2)
		{
			GetComponent<Animator>().SetBool("isEnranged", true);
		}

		if (health <= 0)
		{
			Die();
		}
	}

	public void Die()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

}
