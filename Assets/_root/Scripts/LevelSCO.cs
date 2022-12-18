using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSCO : MonoBehaviour
{
    // The LineRenderer component that will be used to draw the trajectory
    public LineRenderer lineRenderer;

    // The number of points in the trajectory
    public int numPoints = 20;

    // The speed of the object
    public float speed = 10f;

    // The gravity force applied to the object
    public Vector3 gravity = new Vector3(0, -9.81f, 0);

    void Update()
    {
        // Calculate the initial velocity of the object
        Vector3 velocity = transform.forward * speed;

        // Set the position of the first point in the LineRenderer to the current position of the object
        lineRenderer.SetPosition(0, transform.position);

        // Initialize the previous position to the current position
        Vector3 previousPosition = transform.position;

        // Loop through the remaining points in the LineRenderer
        for (int i = 1; i < numPoints; i++)
        {
            // Calculate the position of the point based on the initial velocity, gravity, and the elapsed time
            float elapsedTime = i * Time.deltaTime;
            Vector3 newPosition = transform.position + velocity * elapsedTime + 0.5f * gravity * elapsedTime * elapsedTime;

            // Use Physics.Linecast() to check for collisions between the previous position and the new position
            RaycastHit hit;
            if (Physics.Linecast(previousPosition, newPosition, out hit))
            {
                // If a collision is detected, set the position of the point to the point of collision
                newPosition = hit.point;
            }

            // Set the position of the point in the LineRenderer
            lineRenderer.SetPosition(i, newPosition);

            // Update the previous position to the current position
            previousPosition = newPosition;
        }
    }

}
