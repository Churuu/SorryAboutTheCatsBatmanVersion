using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;

    public Sprite deadCat;
    public Sprite deadDog;

    public List<AudioClip> CatSounds = new List<AudioClip>();
    public List<AudioClip> DogSounds = new List<AudioClip>();
    public List<AudioClip> BatmanSounds = new List<AudioClip>();

    void Start ()
    {
        // konstant speed forward and destroy after 9 seconds
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 10);
        Destroy(gameObject, 5);

        // SoundFolder should be in Assets/Resources 
        CatSounds.Add((AudioClip)Resources.Load(" SoundFolder/youraudioClip1"));
        CatSounds.Add((AudioClip)Resources.Load(" SoundFolder/youraudioClip2"));
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Cat"))
        {
            //transform.GetComponent<AudioSource>().clip = CatSounds[Random.Range(0, CatSounds.Count)];
            //transform.GetComponent<AudioSource>().Play();
            col.GetComponent<SpriteRenderer>().sprite = deadCat;
            FindObjectOfType<Score>().AddScore(1);
            Destroy(gameObject);
        }
        else if (col.gameObject.CompareTag("Dog"))
        {
            //transform.GetComponent<AudioSource>().clip = dogSounds[Random.Range(0, dogSounds.Count)];
            //transform.GetComponent<AudioSource>().Play();
            col.GetComponent<SpriteRenderer>().sprite = deadDog;
            FindObjectOfType<Score>().RemoveScore(1);
            Destroy(gameObject);
        }
        else if (col.gameObject.CompareTag("Wall"))
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }


}
