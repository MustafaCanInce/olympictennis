using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private GameObject player;
    private GameObject player_2;
    private Vector3 initialPos; // The initial position of the ball.
    private AudioSource _audioSource;
    public static bool point_1;
    public static bool point_2;
    private bool hasCollided = false;

    private void Start()
    {
        initialPos = transform.position; // Assign the default location of the ball to where we initially placed it in the scene.
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {

       if (!hasCollided) // If collision has not occurred yet
        {
            _audioSource.Play();
            //Debug.Log("Sound");
           
        }

        if (collision.transform.CompareTag("Player"))
        {

            //Debug.Log("player");
        }

        if (collision.transform.CompareTag("Wall")) // If the ball collides with a wall.
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero; // Set its velocity to 0 to prevent any further movement.
            transform.position = initialPos; // Reset its position.
            
            
            
                 
                if(Player.lasthit_player == true)
                {
                    Gamescore.scorevalue_player += 15; // Increase the score of the first player.
                    //Debug.Log("Do something here");
                    Player.lasthit_player = false;
                    point_1 = true;
                    


                }
                if(Player_2.lasthit_player_2 == true)
                {
                    Gamescore_2.scorevalue_player_2 += 15; // Increase the score of the first player.
                    //Debug.Log("Do something here");
                    Player_2.lasthit_player_2 = false;
                    point_2 = true;
                }
                
                    
                
                 
                
                    //Gamescore_2.scorevalue_player_2 += 15; // Increase the score of the second player.
                    //Gamescore_2.scorevalue_player_2 -= 15;
                    //Debug.Log("Do something here");
                
            
        }
    }
}
