using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCatsAndDogs : MonoBehaviour
{

    public float timeOffset;
    public float wallTimeOffset = 3;
    float cycleTimer = 0;
    float wallTimer;

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
            if (timeOffset > 1)
                timeOffset -= 0.1f;

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
            if (wallTimeOffset > 1)
                wallTimeOffset -= 0.1f;
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
        GameObject wallTemp = Instantiate(wall[Random.Range(0, wall.Length)], RandomSpawnPos(col.bounds.center, col.bounds.size), Quaternion.Euler(0, 0, Random.Range(0, 361))) as GameObject;
        if (wallTimeOffset > 0.5f)
            wallTimeOffset -= 0.1f;

    }

    void SpawnCat()
    {
        var col = GetComponent<Collider2D>();
        GameObject catTemp = Instantiate(cats[Random.Range(0, cats.Length)], RandomSpawnPos(col.bounds.center, col.bounds.size), Quaternion.Euler(0, 0, -90)) as GameObject;
    }
    void SpawnDog()
    {
        var col = GetComponent<Collider2D>();
        GameObject catTemp = Instantiate(dog, RandomSpawnPos(col.bounds.center, col.bounds.size), Quaternion.Euler(0, 0, -90)) as GameObject;
    }

    Vector2 RandomSpawnPos(Vector2 center, Vector2 size)
    {
        return center + new Vector2(
            (Random.value - 0.5f) * size.x,
            (Random.value - 0.5f) * size.y
            );
    }
}
