using UnityEngine;

public class WASDMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to set the movement speed

    void Update()
    {
        // Get input from keyboard
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction based on input
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Apply movement to the object
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}