
using UnityEngine;

public class Movement : MonoBehaviour { 
    public Rigidbody rb;
    //these public floats are here so i can adjust the numbers in the unity inspector
    public float forwardforce = 1000f;
    public float sidewaysForce = 500f;
    public float upwardsforce = 90f;
    public float downwardsforce = -50f;

    //deltatime allows for framerate leniancy. 
    void FixedUpdate()
        // I started this with only sideways and forward force but then later realised i could also make a jump/fly and drop force. 
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime, ForceMode.VelocityChange);

        if (Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))

        {
            rb.AddForce(0, upwardsforce, 0 * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))

        {
            rb.AddForce(0, downwardsforce, 0 * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
      }
}
