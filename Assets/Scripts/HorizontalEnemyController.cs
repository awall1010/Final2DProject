// #CPSC236-Final Project
// Kenneth Cho, Aiden Wall
// 2325383,2317537
// kecho@chapman.edu
// cpsc236-03
// This is a HorizontalEnemyController script that controls enemies that move horizontally

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalEnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    private float floatingTimer = 0f;
    private float floatingMax = 1.8f;
    private float floatingDir = 0.05f;


    private void FixedUpdate() //constantly moves side to side
    {
        if (floatingTimer < floatingMax)
        {
            transform.position = new Vector2(transform.position.x + floatingDir, transform.position.y);
            floatingTimer += Time.fixedDeltaTime;
        }
        else
        {
            floatingDir *= -1;
            floatingTimer = 0f;
        }
    }
}
