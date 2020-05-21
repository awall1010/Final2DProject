// #CPSC236-Final Project
// Kenneth Cho, Aiden Wall
// 2325383,2317537
// kecho@chapman.edu
// cpsc236-03
// This is the Tolevel2script that moves player to the second scene. //this script was addded to the doors
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Tolevel2Script : MonoBehaviour 
{
    public int index;
    public string levelName;
    private void OnTriggerEnter2D(Collider2D other) //when the door collides with the player, it loads scene 2
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }
}
