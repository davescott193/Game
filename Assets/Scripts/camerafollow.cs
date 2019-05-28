using UnityEngine;

public class camerafollow : MonoBehaviour {

    public Transform player;
     
    public Vector3 offset;
    //a float of x,y,z
    void Update()
    {
        transform.position = player.position + offset;
        // the camera locks onto the position of the player clinging to it
        // this caused the issue of a first person view and i want it 3rd person
        // to solve this i created the 'offset' so that the camera would be positioned furtherback

    }
}
