using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletMovement : MonoBehaviour
{

<<<<<<< HEAD
    private Batman batmanPlayer;
    private SpriteRenderer spriteRenderer;
=======
>>>>>>> 6de1bb2e42d8cf25195596635b7a0adea5ab17e4
    private Rigidbody2D rb;
    private AudioSource src;


<<<<<<< HEAD
    public AudioClip[] CatSounds;
    public AudioClip[] DogSounds;
    public AudioClip[] BatmanSounds;

    void Start ()
=======
    void Start()
>>>>>>> 6de1bb2e42d8cf25195596635b7a0adea5ab17e4
    {
        src = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 10);
<<<<<<< HEAD
        Destroy(gameObject, 5);
        spriteRenderer = GetComponent<SpriteRenderer>();
=======
>>>>>>> 6de1bb2e42d8cf25195596635b7a0adea5ab17e4
    }

    void OnTriggerEnter2D(Collider2D col)
    {
<<<<<<< HEAD
        if (col.gameObject.CompareTag("Cat"))
        {
            col.GetComponent<SpriteRenderer>().sprite = deadCat;
            batmanPlayer.src.PlayOneShot(batmanPlayer.batmanSounds[Random.Range(0, batmanPlayer.batmanSounds.Length)]);
            FindObjectOfType<Score>().AddScore(1);
            Destroy(this.gameObject);
        }
        else if (col.gameObject.CompareTag("Dog"))
        {
            col.GetComponent<SpriteRenderer>().sprite = deadDog;
            batmanPlayer.src.PlayOneShot(batmanPlayer.dogSounds[Random.Range(0, batmanPlayer.dogSounds.Length)]);
            FindObjectOfType<Score>().RemoveScore(1);
            Destroy(this.gameObject);
        }
        else if (col.gameObject.CompareTag("Wall"))
=======
        if (col.gameObject.tag == "Cat" || col.gameObject.tag == "Dog" || col.gameObject.tag == "Wall")
>>>>>>> 6de1bb2e42d8cf25195596635b7a0adea5ab17e4
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
