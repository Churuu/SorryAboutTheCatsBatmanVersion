using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Variables
    private Rigidbody2D rb2d;
    public int movementSpeed = 3;                  // Standard value: 5
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
        rb2d.velocity = new Vector2((Input.GetAxis("Horizontal") * movementSpeed), 0);
        transform.eulerAngles = new Vector3(0, 0, 90 + Input.GetAxis("Horizontal") * -45);
    }
}
