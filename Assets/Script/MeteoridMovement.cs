using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroidMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private Vector3 moveDirection; // Store the random movement direction

    void Start()
    {
        // Choose a random direction when the meteoroid is created
        moveDirection = GetRandomDirection();
    }

    void Update()
    {
        // Move the meteoroid in the chosen random direction
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }

    Vector3 GetRandomDirection()
    {
        // Generate a random integer between 0 and 3 to choose a direction
        int randomDirectionIndex = Random.Range(0, 4);

        // Initialize a vector for each possible direction
        Vector3[] directions = { Vector3.up, Vector3.down, Vector3.left, Vector3.right };

        // Return the selected random direction
        return directions[randomDirectionIndex];
    }
}