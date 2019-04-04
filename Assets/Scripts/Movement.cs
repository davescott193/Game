
using UnityEngine;

public class Movement : MonoBehaviour { 
    public Rigidbody rb;

    public float forwardforce = 2000f;
    public float sidewaysForce = 500f;

    //deltatime allows for framerate leniancy. 
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

    }
}
