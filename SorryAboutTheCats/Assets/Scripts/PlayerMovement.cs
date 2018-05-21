using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Variables
    private Rigidbody2D rb2d;
    private int movementSpeed = 5;                  // Standard value: 5
    private int gameSpeed = 2;                      // Standard value: 3
    #endregion

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        rb2d.velocity = new Vector2((Input.GetAxis("Horizontal") * movementSpeed), gameSpeed);
    }
}
