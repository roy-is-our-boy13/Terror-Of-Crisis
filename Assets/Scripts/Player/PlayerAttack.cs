using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] public float attackCooldown;
    [SerializeField] public float punchRange;
    [SerializeField] public float damage;
    [SerializeField] public Transform firePoint;
    [SerializeField] public GameObject[] fireballs;
    [SerializeField] public AudioClip fireballSound;


    public Animator anim;
    public PlayerMovement playerMovement;
    public float cooldownTimer = Mathf.Infinity;
    public int damage2 = 40;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        /*
       if (Input.GetKey(KeyCode.C) && cooldownTimer > attackCooldown && playerMovement.canAttack())
        { 
            Attack();
        }
        else */if (Input.GetKeyDown(KeyCode.Z))
        {
            Punch();
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            Kick();
        }

        cooldownTimer += Time.deltaTime;
    }

/*
    public void Attack()
    {
        SoundManager.instance.PlaySound(fireballSound);
        anim.SetTrigger("attack");
        cooldownTimer = 0;

        fireballs[FindFireball()].transform.position = firePoint.position;
        fireballs[FindFireball()].GetComponent<Projectile>().SetDirection(Mathf.Sign(transform.localScale.x));
      
    }
*/
    private void Punch()
    {
        anim.SetTrigger("punch");
        DealPunchDamage();
    }

    private void Kick()
    {
        anim.SetTrigger("kick");
        DealPunchDamage();
    }

/*
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
*/
     private void DealPunchDamage()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(transform.position, punchRange);
        
        foreach (Collider2D enemy in hitEnemies)
        {
            if (enemy.CompareTag("Enemy") )
            {
                // Deal damage to the enemy
                enemy.GetComponent<Health>().TakeDamage(damage); // Adjust punchDamage as needed
            }
            else if(enemy.CompareTag("Boss"))
            {
                enemy.GetComponent<Health>().TakeDamage(damage);
            }
        }
    }


}
