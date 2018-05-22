using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private AudioSource src;


    void Start()
    {
        src = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 10);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Cat" || col.gameObject.tag == "Dog" || col.gameObject.tag == "Wall")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }



        var score = FindObjectOfType<Score>();
        if (col.gameObject.CompareTag("Cat"))
            score.AddScore(1);
        else if (col.gameObject.CompareTag("Dog"))
            score.RemoveScore(1);
    }
}
