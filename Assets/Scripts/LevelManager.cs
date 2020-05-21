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
