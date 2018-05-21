using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;

    public List<AudioClip> CatSounds = new List<AudioClip>();
    public List<AudioClip> DogSounds = new List<AudioClip>();
    public List<AudioClip> BatmanSounds = new List<AudioClip>();

    void Start ()
    {
        // konstant speed forward and destroy after 9 seconds
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 3);
        Destroy(gameObject, 9);

        // SoundFolder should be in Assets/Resources 
        CatSounds.Add((AudioClip)Resources.Load(" SoundFolder/youraudioClip1"));
        CatSounds.Add((AudioClip)Resources.Load(" SoundFolder/youraudioClip2"));
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.otherRigidbody.CompareTag("Cat"))
        {
            transform.GetComponent<AudioSource>().clip = CatSounds[Random.Range(0, CatSounds.Count)];
            transform.GetComponent<AudioSource>().Play();

        }
        if (collision.otherRigidbody.CompareTag("Dog"))
        {
            transform.GetComponent<AudioSource>().clip = DogSounds[Random.Range(0, DogSounds.Count)];
            transform.GetComponent<AudioSource>().Play();
        }

    }

}
