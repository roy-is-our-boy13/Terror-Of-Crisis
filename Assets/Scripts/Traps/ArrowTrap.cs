using UnityEngine;

public class ArrowTrap : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] fireballs;
    private float cooldownTimer;

    [Header("SFX")]
    [SerializeField] private AudioClip arrowSound;

    private void Attack()
    {
        SoundManager.instance.PlaySound(arrowSound);
        cooldownTimer = 0;
        fireballs[findFireball()].transform.position = firePoint.position;
        fireballs[findFireball()].GetComponent<EnemyProjectile>().ActivateProjectile();
    }

    private int findFireball()
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

    private void Update()
    {
        cooldownTimer += Time.deltaTime;
        if (cooldownTimer >= attackCooldown)
        {
            Attack();
        }
    }
}
