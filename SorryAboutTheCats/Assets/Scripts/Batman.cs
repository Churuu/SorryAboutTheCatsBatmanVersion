using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Batman : MonoBehaviour
{

    public GameObject BatmanPlayer;
    public Sprite BatmanSpriteCar;
    public Sprite BatmanSpriteDestroyed;
    private SpriteRenderer spriteRenderer;
    public Score score;

    public List<AudioClip> CatSounds = new List<AudioClip>();
    public List<AudioClip> DogSounds = new List<AudioClip>();
    public List<AudioClip> BatmanSounds = new List<AudioClip>();
    

    void Start()
    {
        // SoundFolder should be in Assets/Resources 
        CatSounds.Add((AudioClip)Resources.Load(" SoundFolder/youraudioClip1"));
        CatSounds.Add((AudioClip)Resources.Load(" SoundFolder/youraudioClip2"));
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
            spriteRenderer.sprite = BatmanSpriteCar;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.otherRigidbody.CompareTag("Cat"))
        {
            transform.GetComponent<AudioSource>().clip = CatSounds[Random.Range(0, CatSounds.Count)];
            transform.GetComponent<AudioSource>().Play();
            FindObjectOfType<Score>().AddScore(1);
        }
        if (collision.otherRigidbody.CompareTag("Dog"))
        {
            transform.GetComponent<AudioSource>().clip = DogSounds[Random.Range(0, DogSounds.Count)];
            transform.GetComponent<AudioSource>().Play();
            FindObjectOfType<Score>().RemoveScore(1);
        }

    }
    void ChangeNOW()
    {
        if (spriteRenderer.sprite == BatmanSpriteCar) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            
            spriteRenderer.sprite = BatmanSpriteDestroyed;
        }
        else
        {
            spriteRenderer.sprite = BatmanSpriteCar; // otherwise change it back to sprite1
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Hello");
            ChangeNOW();
        }
    }
}

