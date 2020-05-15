using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    private void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
           // new WaitForSeconds(5);//this doesn't work
         //   movement.enabled = true;
        }
    }
}
