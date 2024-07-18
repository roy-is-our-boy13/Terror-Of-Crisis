using UnityEngine;

public class RangedEnemy : MonoBehaviour
{
    [Header("Attacking Paramenter")]
    [SerializeField] private float attackCooldown;
    [SerializeField] private float range;
    [SerializeField] private int damage;

    [Header("Collider Parameters")]
    [SerializeField] private float colliderDistance;
    [SerializeField] private BoxCollider2D boxCollider;

    [Header("Range Attack")]
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] fireballs;

    [Header("Player Parameters")]
    [SerializeField] private LayerMask playerLayer;
    private float cooldownTimer = Mathf.Infinity;


    [Header("Player Parameters")]
    [SerializeField] private AudioClip fireballSound;
  

    //Reference
    private Animator anim;
    private EnemyPatrol enemyPatrol;


    private void Awake()
    {
        anim = GetComponent<Animator>();
        enemyPatrol = GetComponentInParent<EnemyPatrol>();
    }

    private void Update()
    {
        cooldownTimer += Time.deltaTime;

        //Attack only when player in sight?
        if (PlayerInSight())
        {
            if (cooldownTimer >= attackCooldown)
            {
                //Attack
                cooldownTimer = 0;
                anim.SetTrigger("rangeAttack");
            }
        }

        if (enemyPatrol != null)
        {
            enemyPatrol.enabled = !PlayerInSight();
        }
    }

    private void RangedAttack()
    {
        SoundManager.instance.PlaySound(fireballSound);
        cooldownTimer = 0;
        //shot projectiles
        fireballs[FindFireBalls()].transform.position = firePoint.position;
        fireballs[FindFireBalls()].GetComponent<EnemyProjectile>().ActivateProjectile();
    }

    private int FindFireBalls()
    {
        for (int i = 0; i < fireballs.Length; i++)
        {
            if(!fireballs[i].activeInHierarchy)
            {
                return i;
            }
        }
        return 0;
    }


    private bool PlayerInSight()
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance,
            new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z)
            , 0, Vector2.left, 0, playerLayer);

        return hit.collider != null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(boxCollider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance,
            new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z));
    }

}
