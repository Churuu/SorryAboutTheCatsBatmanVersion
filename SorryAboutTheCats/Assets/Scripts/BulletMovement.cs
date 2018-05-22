using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletMovement : MonoBehaviour {

    private Batman batmanPlayer;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;

    public Sprite deadCat;
    public Sprite deadDog;

    public AudioClip[] CatSounds;
    public AudioClip[] DogSounds;
    public AudioClip[] BatmanSounds;

    void Start ()
    {
        // konstant speed forward and destroy after 9 seconds
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 10);
        Destroy(gameObject, 5);
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
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
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }


}
