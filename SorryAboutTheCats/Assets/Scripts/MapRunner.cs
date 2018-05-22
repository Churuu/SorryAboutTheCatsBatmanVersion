using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRunner : MonoBehaviour
{
    public float sizeVertical = 12.375f;
    public Transform player;
    public Sprite[] tiles = new Sprite[14];

    private Camera mainCam;
    private SpriteRenderer spRen;
    private GameController game;

    void Start()
    {
        mainCam = Camera.main;
        game = GameObject.Find("Main Camera").GetComponent<GameController>();
        spRen = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        BoundryCheck();
    }

    void BoundryCheck()
    {
        if (transform.position.y < player.position.y - sizeVertical)
        {
            transform.position = new Vector2(0, player.position.y + sizeVertical);
            RandomTile();
        }
    }

    void RandomTile()
    {
        spRen.sprite = tiles[Random.Range(0, tiles.Length)];
    }
}
