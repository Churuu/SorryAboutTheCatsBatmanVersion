using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Batman : MonoBehaviour
{

    public GameObject batmanPlayer;
    public Sprite batmanSpriteCar;
    public Sprite batmanSpriteDestroyed;
    public Sprite deadCat;
    public Sprite deadDog;
    public List<AudioClip> catSounds = new List<AudioClip>();
    public List<AudioClip> dogSounds = new List<AudioClip>();
    public List<AudioClip> batmanSounds = new List<AudioClip>();

    [HideInInspector] public bool isDead = false;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // SoundFolder should be in Assets/Resources 
        catSounds.Add((AudioClip)Resources.Load(" SoundFolder/youraudioClip1"));
        catSounds.Add((AudioClip)Resources.Load(" SoundFolder/youraudioClip2"));
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
            spriteRenderer.sprite = batmanSpriteCar;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Cat"))
        {
            //transform.GetComponent<AudioSource>().clip = CatSounds[Random.Range(0, CatSounds.Count)];
            //transform.GetComponent<AudioSource>().Play();
            col.GetComponent<SpriteRenderer>().sprite = deadCat;
            FindObjectOfType<Score>().AddScore(1);
        }
        else if (col.gameObject.CompareTag("Dog"))
        {
            //transform.GetComponent<AudioSource>().clip = dogSounds[Random.Range(0, dogSounds.Count)];
            //transform.GetComponent<AudioSource>().Play();
            col.GetComponent<SpriteRenderer>().sprite = deadDog;
            FindObjectOfType<Score>().RemoveScore(1);
        }
        else if (col.gameObject.CompareTag("Wall"))
        {
            Lose();
        }
    }

    void Lose()
    {
        spriteRenderer.sprite = batmanSpriteDestroyed;
        FindObjectOfType<PlayerMovement>().movementSpeedX = 0;
        FindObjectOfType<PlayerMovement>().movementSpeedY = 0;
        isDead = true;
    }

    void ChangeNOW()
    {
        if (spriteRenderer.sprite == batmanSpriteCar) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {

            spriteRenderer.sprite = batmanSpriteDestroyed;
        }
        else
        {
            spriteRenderer.sprite = batmanSpriteCar; // otherwise change it back to sprite1
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

