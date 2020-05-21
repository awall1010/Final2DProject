// #CPSC236-Final Project
// Kenneth Cho, Aiden Wall
// 2325383,2317537
// kecho@chapman.edu
// cpsc236-03
// This is the CameraFollow script for this project

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followTransform; //position of object that we would like to follow
    private Vector3 smoothPos;
    private float smoothSpeed = 0.5f;

    public GameObject cameraLeftBorder; //left of the camera border
    public GameObject cameraRightBorder; //right of the camera border

    private float cameraHalfWidth; //where the camera will be positioned(half length of width)
    // Start is called before the first frame update
    void Start()
    {
        cameraHalfWidth = Camera.main.orthographicSize * Camera.main.aspect; //gets the half size of camera
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float borderLeft = cameraLeftBorder.transform.position.x + cameraHalfWidth; //left border
        float borderRight = cameraRightBorder.transform.position.x + cameraHalfWidth; //border right

        smoothPos = Vector3.Lerp(this.transform.position, //lerp gives a midpoint for moving from point a to point be(makes it smoother)
            new Vector3(Mathf.Clamp(followTransform.position.x, borderLeft, borderRight),
            this.transform.position.y,             //constantly defines new position
            this.transform.position.z), smoothSpeed);
        this.transform.position = smoothPos;
    }
}
