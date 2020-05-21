// #CPSC236-Final Project
// Kenneth Cho, Aiden Wall
// 2325383,2317537
// kecho@chapman.edu
// cpsc236-03
// This is the playerMovement script that controls the player

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public int totalScore;
    public CharacterController2D controller;
    public Animator animator;
    public AudioClip deadClip;
    public AudioClip jumpClip;
    public float runSpeed = 25f;
    float horizontalMove = 0f;
    bool jumpFlag = false;
    bool jump = false;



    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed; //enables player to move horizontally

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (jumpFlag)
        {
            jumpFlag = false;
        }

        if (Input.GetButtonDown("Jump"))  //enables user to make the character jump by pressing the space bar
        {
            jump = true;
            AudioSource.PlayClipAtPoint(jumpClip, transform.position);
        }
    }
    public void OnLanding()
    {
        jump = false;
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);

        if (jump)
        {
            jumpFlag = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) //deals with collisions with enemies and doors that lead to other scenes
    {
        if (collision.gameObject.layer == 10) 
        {
            AudioSource.PlayClipAtPoint(deadClip, transform.position);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.layer == 13)
        {
            SceneManager.LoadScene(1);
        }
        if(collision.gameObject.layer == 14)
        {
            SceneManager.LoadScene(2);
        }
        if (collision.gameObject.layer == 9)
        {
            GameObject.Destroy(this.gameObject);
            GameControlScript.health -= 1;
            //GameObject.Destroy(collision.gameObject);
        }
    }
}
