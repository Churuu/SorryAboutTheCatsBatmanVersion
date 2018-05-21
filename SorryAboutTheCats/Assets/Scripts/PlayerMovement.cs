using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Variables
    private Rigidbody2D rb2d;
    public float movementSpeedX;
    public float movementSpeedY;
    public Transform mainCamera;
    private int rotationAngle = 30;
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
        mainCamera.position = new Vector3(0, transform.position.y + 4, -10);
        rb2d.velocity = new Vector2((Input.GetAxis("Horizontal") * movementSpeedX), movementSpeedY);
        transform.eulerAngles = new Vector3(0, 0, 90 + Input.GetAxis("Horizontal") * -rotationAngle);
    }
}
