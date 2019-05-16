using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class PlayerCollision : MonoBehaviour {
    public Movement movement;
    public Rigidbody RB;
    public float upwardsforce = 500f;
   // When the player collides with the obstacles this code should occur
    
    private void OnCollisionEnter (Collision collision)
    {
        if (collision.collider.tag == "obstacle")
        {
            // When collision occurs the movement stops
            movement.enabled = false;
            // I have added a feature where once the movement is halted my character gets a burst of speed on the Y axis and gravity is disabled. this is to simulate rag doll physics.
            RB.AddForce(0, upwardsforce, 0 * Time.deltaTime);
            RB.useGravity = false;
            // When the character hits something this sources the "EndGame" code in the game manager
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
