// #CPSC236-Final Project
// Kenneth Cho, Aidan Wall
// 2325383,2317537
// kecho@chapman.edu
//awall@chapman.edu
// cpsc236-03
// This is the level manager that controls changing between levels


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("level1");
    }

    public void quitGame()
    {
        Application.Quit();
    }
    
}
