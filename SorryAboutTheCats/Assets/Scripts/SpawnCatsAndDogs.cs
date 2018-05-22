﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCatsAndDogs : MonoBehaviour
{

    public float timeOffset;
    float cycleTimer = 0;
    float wallTimer;
    float wallTimeOffset = 3;

    public GameObject[] cats;
    public GameObject dog;
    public GameObject[] wall;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ChooseAnimalToSpawn();
        if (WallTimeCheck())
            SpawnWall();
        
    }

    void ChooseAnimalToSpawn()
    {
        if (Time.time > cycleTimer)
        {
            cycleTimer = Time.time + timeOffset;
            float rng = Random.value;
            if (rng < 0.7f)
                SpawnCat();
            else
                SpawnDog();
        }
    }

    private bool WallTimeCheck()
    {
        if (Time.time > wallTimer)
        {
            wallTimer = Time.time + wallTimeOffset;
            return true;
        }
        else
        {
            return false;
        }
    }

    void SpawnWall()
    {
        var col = GetComponent<Collider2D>();
        GameObject wallTemp = Instantiate(wall[Random.Range(0, wall.Length)], RandomSpawnPos(col.bounds.center, col.bounds.size), Quaternion.Euler(0, 0, -90)) as GameObject;

        if (Time.time % 5 == 0 && wallTimeOffset > 0.5f)
            wallTimeOffset -= 0.2f;

    }

    void SpawnCat()
    {
        var col = GetComponent<Collider2D>();
        GameObject catTemp = Instantiate(cats[Random.Range(0, cats.Length)], RandomSpawnPos(col.bounds.center, col.bounds.size), Quaternion.Euler(0, 0, -90)) as GameObject;
        //catTemp.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -350 * Time.deltaTime);
    }
    void SpawnDog()
    {
        var col = GetComponent<Collider2D>();
        GameObject catTemp = Instantiate(dog, RandomSpawnPos(col.bounds.center, col.bounds.size), Quaternion.Euler(0, 0, -90)) as GameObject;
        //catTemp.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -350 * Time.deltaTime);
    }

    Vector2 RandomSpawnPos(Vector2 center, Vector2 size)
    {
        return center + new Vector2(
            (Random.value - 0.5f) * size.x,
            (Random.value - 0.5f) * size.y
            );
    }
}
