// #CPSC236-Final Project
// Kenneth Cho, Aiden Wall
// 2325383,2317537
// kecho@chapman.edu
// cpsc236-03
// This is a VerticalEnemyController script that controls enemies that move vertically

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalEnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    private float floatingTimer = 0f;
    private float floatingMax = 1.8f;
    private float floatingDir = 0.05f;


    private void FixedUpdate()//makes the enemy that has this script move up and down constantly
    {
        if (floatingTimer < floatingMax)
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
}
