using UnityEngine;
using System.Collections;

public class FIreTrap : MonoBehaviour
{
    [Header("Firetrap Timers")]
    [SerializeField] private float activationDelay;
    [SerializeField] private float activeTime;
    [SerializeField] private float damage;
    private Animator anim;
    private SpriteRenderer spriteRend;

    [Header ("SFX")]
    [SerializeField] private AudioClip firetrapSound;

    private bool triggered;
    private bool active;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!triggered)
            {
                //trigger the fire
                StartCoroutine(ActivateFireTrap());
            }
            if (active)
            {
                collision.GetComponent<Health>().TakeDamage(damage);
            }
        }
    }

    private IEnumerator ActivateFireTrap()
    {
        // turn the trap to red and trigger the trap
        triggered = true;
        spriteRend.color = Color.red;

        //wait for delay, turn on animation, return color back to normal
        yield return new WaitForSeconds(activationDelay);
        SoundManager.instance.PlaySound(firetrapSound);
        spriteRend.color = Color.white;
        active = true;
        anim.SetBool("activated", true);

        // wait for the active time and deactivate the trap
        yield return new WaitForSeconds(activeTime);
        triggered = false;
        active = false;
        anim.SetBool("activated", false);
    }
}
