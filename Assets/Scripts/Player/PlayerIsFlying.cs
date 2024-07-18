using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIsFlying : PlayerMovement
{
   
    [Header("Flying")]
    [SerializeField] private float flySpeed;

    private bool isFlying = false;

    Vector3 moveDirection = Vector3.zero;
    public float gravity = 20.0f;

    public void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space) && !isFlying)
        //{

           if (!isFlying)
                moveDirection.y -= gravity * Time.deltaTime;
            else
            {
            if (Input.GetKey(KeyCode.Space)) // if space is held
            {
                moveDirection.y += flySpeed * Time.deltaTime;
            }
            else if (Input.GetKey("Descend")) // if descend button is held
             {
                moveDirection.y -= flySpeed * Time.deltaTime;
            }
}
        //}
    }

    public void Fly()
    {
        if (isFlying == true)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            body.velocity = new Vector2(body.velocity.x, flySpeed);

            if (horizontalInput > 0.01f)
                transform.localScale = new Vector3(XAxis, YAxis, ZAxis);
            else if (horizontalInput < -0.01f)
                transform.localScale = new Vector3(-XAxis, YAxis, ZAxis);
        }
    }
}
