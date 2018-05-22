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
    private float edgeBorder = 3f;
    public ParticleSystem p1, p2;
    #endregion

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!FindObjectOfType<Batman>().isDead)
            Movement();
    }

    void Movement()
    {
        mainCamera.position = new Vector3(0, transform.position.y + 2, -10);
        rb2d.velocity = new Vector2((Input.GetAxis("Horizontal") * movementSpeedX), movementSpeedY);
        transform.eulerAngles = new Vector3(0, 0, 90 + Input.GetAxis("Horizontal") * -rotationAngle);

        if(Input.GetAxis("Horizontal") != 0)
        {
            p1.Play();
            p2.Play();
        } else if(Input.GetAxis("Horizontal") == 0)
        {
            p1.Stop();
            p2.Stop();
        }

        if (transform.position.x < -edgeBorder)
        {
            transform.position = new Vector2(-edgeBorder, transform.position.y);
        }
        else if (transform.position.x > edgeBorder)
        {
            transform.position = new Vector2(edgeBorder, transform.position.y);
        }
    }
}
