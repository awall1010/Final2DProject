// #CPSC236-Final Project
// Kenneth Cho, Aiden Wall
// 2325383,2317537
// kecho@chapman.edu
// cpsc236-03
// This is a CoinController script that controls chest interactables in the game

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public AudioClip pickupClip; // clip that is played when coin is picked up
    private float floatingTimer = 0f;
    private float floatingMax = 1f;
    private float floatingDir = 0.01f;


    private void FixedUpdate() //this part gives the coin an up and down bobbing movement
    {
        if(floatingTimer < floatingMax)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + floatingDir);
            floatingTimer += Time.fixedDeltaTime;
        }
        else
        {
            floatingDir *= -1;
            floatingTimer = 0f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) //when this collides with the player, it destroys itself
    {
        if(collision.gameObject.layer == 9)
        {
// <<<<<<< HEAD
//             AudioSource.PlayClipAtPoint(pickupClip, transform.position);
//             //PlayerMovement.totalScore += 5;
// =======
            AudioSource.PlayClipAtPoint(pickupClip, transform.position); //generates the pickup clip sound
// >>>>>>> fb964b599301a4dae1dc4bfc804476b188bf4a86
            Destroy(this.gameObject);
        }
        //if (collision.gameObject.layer == 12)
        //{

        //}
    }
}
