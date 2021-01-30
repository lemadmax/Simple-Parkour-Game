using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandle : MonoBehaviour
{

    public PlayerMovement playerMovement;
    public GameManager manager;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            playerMovement.enabled = false;
            manager.endGame();
        }
    }

}
