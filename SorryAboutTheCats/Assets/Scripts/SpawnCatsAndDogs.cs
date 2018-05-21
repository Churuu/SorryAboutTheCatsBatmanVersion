using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCatsAndDogs : MonoBehaviour
{

    public float timeOffset;
    float cycleTimer = 0;

    public GameObject[] cats;
    public GameObject dog;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ChooseAnimalToSpawn();
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
