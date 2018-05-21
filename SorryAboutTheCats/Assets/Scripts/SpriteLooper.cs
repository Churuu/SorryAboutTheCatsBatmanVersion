using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteLooper : MonoBehaviour
{
    #region Variables
    private Camera mainCam;
    private float basePosition = 11.5f; // Standard value: 8
    private float moveSpeed = 2;
    private float boundry = -11.5f; // Standard value: -8
    private SpriteRenderer spRen;
    private GameController game;
    public Sprite[] tiles = new Sprite[14];
    #endregion

    void Start()
    {
        mainCam = Camera.main;
        game = GameObject.Find("Main Camera").GetComponent<GameController>();
        spRen = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Movement();
        BoundryCheck();
    }

    void BoundryCheck()
    {
        if (transform.position.y < boundry)
        {
            transform.position = new Vector2(0, basePosition);
            RandomTile();
        }
    }

    void Movement()
    {
        transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
    }

    void RandomTile()
    {
        int r = game.getRandom();

        spRen.sprite = tiles[r];
    }
}
