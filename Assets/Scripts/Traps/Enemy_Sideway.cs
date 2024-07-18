using UnityEngine;

public class Enemy_Sideway : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private float movementDistance;
    [SerializeField] private float movementSpeed;
    private bool movingLeft;
    private float leftEdge;
    private float rightEdge;

    private void Awake()
    {
        leftEdge = transform.position.x - movementDistance;
        rightEdge = transform.position.x + movementDistance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(damage);

        }
    }

    private void Update()
    {
        if(movingLeft)
        {
            if (transform.position.x > leftEdge)
            {
                transform.position = new Vector3(transform.position.x - movementSpeed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
            {
                movingLeft = false;
            }
        }else
        {
            if (transform.position.x < rightEdge)
            {
                transform.position = new Vector3(transform.position.x + movementSpeed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
            {
                movingLeft = true;
            }
        }
    }
}
