using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteLooper : MonoBehaviour
{
    #region Variables
    private Camera mainCam;
    private float basePosition = 8; // Standard value: 8
    private float moveSpeed = 2;
    private float boundry = -8; // Standard value: -8
    #endregion

    void Start()
    {
        mainCam = Camera.main;
    }

    void Update()
    {
        Movement();
        BoundryCheck();
    }

    void BoundryCheck()
    {
        if (transform.position.y < boundry)
        {
            transform.position = new Vector2(0, basePosition);
        }
    }

    void Movement()
    {
        transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
    }
}
