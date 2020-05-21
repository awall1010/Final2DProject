using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public int totalScore = 0;
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
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (jumpFlag)
        {
            jumpFlag = false;
        }

        if (Input.GetButtonDown("Jump"))
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            AudioSource.PlayClipAtPoint(deadClip, transform.position);
            SceneManager.LoadScene("GameOver");
            Destroy(this.gameObject);
            FindObjectOfType<GameControlScript>().EndGame();
            //SceneManager.LoadScene(3);
        }

        if (collision.gameObject.layer == 13)
        {
            SceneManager.LoadScene("level2");
        }
        if(collision.gameObject.layer == 14)
        {
            SceneManager.LoadScene("level3");
        }
        if (collision.gameObject.layer == 15) //bring player to final scene
        {
            SceneManager.LoadScene("Win");
        }

            if (collision.gameObject.layer == 12)
        {
            totalScore += 5;
        }
    }
}
