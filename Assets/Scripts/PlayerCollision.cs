﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    // Start is called before the first frame update
     void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);    
        if(collisionInfo.collider.tag=="Obstacle")
        {
            movement.Stop();
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
