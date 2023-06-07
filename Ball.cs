using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Ball : MonoBehaviour
{
    

    Vector3 initialPos; // The initial position of the ball.
    private void Start()
    {
        initialPos = transform.position; // Assign the default location of the ball to where we initially placed it in the scene.
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Wall")) // If the ball collides with a wall.
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero; // Set its velocity to 0 to prevent any further movement.
            transform.position = initialPos; // Reset its position.

            Gamescore.scorevalue += 10;

        }
        
    }

}