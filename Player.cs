using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    public Transform aimTarget; // The goal at which we intend to land the ball.
    float speed = 3f; // Move speed.
    float force = 10; // Ball impact force.

    bool hitting; // A boolean value indicating whether or not we are successfully making contact with the ball.
    public Transform ball; // Ball. 
    Animator animator;

    Vector3 aimTargetInitialPosition; // The starting location of the aiming gameObject, which is situated at the center of the opposing court.

    ShotManager shotManager; // A reference to the shotmanager component.
    Shot currentShot; // The present shot we are executing in order to access its properties.

    private void Start(){
        animator = GetComponent<Animator>(); // A reference to the animator component.
        aimTargetInitialPosition = aimTarget.position; // Set the initial position of the aim to the center (where it was placed in the editor).
        shotManager = GetComponent<ShotManager>(); // Accessing the ShotManager component.
        currentShot = shotManager.topSpin; // Setting the default shot to topspin.
    }

    void Update(){
        float h = Input.GetAxisRaw("Horizontal"); // Retrieve the horizontal axis of the keyboard.
        float v = Input.GetAxisRaw("Vertical"); // Retrieve the vertical axis of the keyboard.

        if (Input.GetKeyDown(KeyCode.F)){
            hitting = true; // Our objective is to strike the ball and determine where it should land.
            currentShot = shotManager.topSpin; // Assign the current shot to topspin.
        }
        else if (Input.GetKeyUp(KeyCode.F)){
            hitting = false; // We release the key, indicating that we are no longer striking the ball, and as a result, this action ceases.
        }                    // Utilized to alternate between moving the aiming target and our own position.

        if (Input.GetKeyDown(KeyCode.E)){
            hitting = true; // Our goal is to strike the ball and direct it towards the desired landing spot.
            currentShot = shotManager.flat; // We set our current shot to topspin.
        }
        else if (Input.GetKeyUp(KeyCode.E)){
            hitting = false;
        }



        if (hitting){  // If we are attempting to strike the ball.

            aimTarget.Translate(new Vector3(h, 0, 0) * speed * 2 * Time.deltaTime); // Move the aiming gameObject horizontally on the court.
        }


        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) && !hitting){ // Restrict the movement of the aiming gameObject to only forward or backward.
            transform.Translate(new Vector3(0, 0, v) * speed * Time.deltaTime); // Move on the court.
        }

        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) && !hitting){ // Restrict the movement of the aiming gameObject to only left or right.
        
            transform.Translate(new Vector3(h, 0, 0) * speed * Time.deltaTime); // Move on the court.
        }




    }


    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Ball")){ // If we make contact with the ball.

            Vector3 dir = aimTarget.position - transform.position; // Retrieve the direction in which we desire to direct the ball.
            other.GetComponent<Rigidbody>().velocity = dir.normalized * currentShot.hitForce + new Vector3(0, currentShot.upForce, 0);
            // Apply force to the ball, including an upward force corresponding to the type of shot being executed.

            Vector3 ballDir = ball.position - transform.position; // Determine the direction of the ball relative to our position in order to determine if it is:
            if (ballDir.x >= 0){
                animator.Play("forehand");                        // Trigger a forehand animation if the ball is on our right side.
            }else{
                animator.Play("backhand");
            }

            aimTarget.position = aimTargetInitialPosition; // Restore the position of the aiming gameObject to its original location.

        }
    }

}