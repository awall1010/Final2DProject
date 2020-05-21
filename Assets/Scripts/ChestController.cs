  
// #CPSC236-Final Project
// Kenneth Cho, Aiden Wall
// 2325383,2317537
// kecho@chapman.edu
// cpsc236-03
// This is the CharacterController2D script
// This is a ChestController script that controls chest interactables in the game

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    PlayerMovement p1;
    public AudioClip ChestClip;
    private bool playerCollision;
    public bool alreadyPlayed = false;
    [SerializeField]
    private SpriteRenderer spriteRenderer; //sprite renderer for chests
    [SerializeField]
    private Sprite openSprite, closedSprite; // sprites for when chest is closed and open
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            playerCollision = true;//player has collided
        }
        if (playerCollision == true && alreadyPlayed == false)
        {
            spriteRenderer.sprite = openSprite; //sprite changes to the open sprite
            AudioSource.PlayClipAtPoint(ChestClip, transform.position); //plays audio when collision occurs with the player
            playerCollision = false;
            alreadyPlayed = true; //used to prevent audio and sprite change reactivating

        }
    }
}
