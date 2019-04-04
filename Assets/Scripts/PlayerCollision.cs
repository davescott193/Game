﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement; 
     private void OnCollisionEnter (Collision collision)
    {
        if (collision.collider.tag == "obstacle")
        {
            movement.enabled = false;
        }
    }
}