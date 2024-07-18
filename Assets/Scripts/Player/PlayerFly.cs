using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFly :MonoBehaviour
{
    public float flySpeed = 5f; // Speed of flying
    public float floatSpeed = 2f; // Speed of floating
    public float maxFlyHeight = 10f; // Maximum height the player can fly
    public float gravity = 9.81f; // Gravity applied when not flying

    private CharacterController characterController;
    private bool isFlying = false;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Check for flying input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isFlying = !isFlying;
        }

        // Move the player
        if (isFlying)
        {
            Fly();
        }
        else
        {
            Float();
        }

        // Apply gravity if not flying
        if (!isFlying)
        {
            ApplyGravity();
        }
    }

    void Fly()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate movement direction
        Vector3 moveDirection = transform.forward * verticalInput + transform.right * horizontalInput;

        // Normalize the direction to ensure consistent speed in all directions
        moveDirection.Normalize();

        // Move the player
        characterController.Move(moveDirection * flySpeed * Time.deltaTime);

        // Limit the player's height
        if (transform.position.y > maxFlyHeight)
        {
            transform.position = new Vector3(transform.position.x, maxFlyHeight, transform.position.z);
        }
    }

    void Float()
    {
        // Move the player upwards
        characterController.Move(Vector3.up * floatSpeed * Time.deltaTime);
    }

    void ApplyGravity()
    {
        // Apply gravity to pull the player down
        characterController.Move(Vector3.down * gravity * Time.deltaTime);
    }
}
