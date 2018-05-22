using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Batman : MonoBehaviour
{

    public GameObject batmanPlayer;
    public GameObject gameOver;
    public Sprite batmanSpriteCar;
    public Sprite batmanSpriteDestroyed;
    public Sprite deadCat;
    public Sprite deadDog;
    public AudioClip[] catSounds;
    public AudioClip[] dogSounds;
    public AudioClip[] batmanSounds;


    [HideInInspector] public bool isDead = false;

    private AudioSource src;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        src = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
            spriteRenderer.sprite = batmanSpriteCar;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Cat"))
        {
            col.GetComponent<SpriteRenderer>().sprite = deadCat;
            src.PlayOneShot(batmanSounds[Random.Range(0, batmanSounds.Length)]);
            FindObjectOfType<Score>().AddScore(1);
        }
        else if (col.gameObject.CompareTag("Dog"))
        {
            col.GetComponent<SpriteRenderer>().sprite = deadDog;
            src.PlayOneShot(dogSounds[Random.Range(0, dogSounds.Length)]);
            FindObjectOfType<Score>().RemoveScore(1);
        }
        else if (col.gameObject.CompareTag("Wall"))
        {
            Lose();
        }
    }

    public void Lose()
    {
        spriteRenderer.sprite = batmanSpriteDestroyed;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        gameOver.SetActive(true);
        isDead = true;
    }
}

