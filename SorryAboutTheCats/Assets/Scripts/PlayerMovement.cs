using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Variables
    private Rigidbody2D rb2d;
    private int movementSpeed = 5; // 5 standard value
    #endregion

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        KeyboardInput();
    }

    void KeyboardInput()
    {
        rb2d.velocity = new Vector2((Input.GetAxis("Horizontal") * movementSpeed), 0);
    }
}
