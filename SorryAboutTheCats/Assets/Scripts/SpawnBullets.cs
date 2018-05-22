using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullets : MonoBehaviour
{
    public GameObject bullet;
    public float cycle;
    float currentCycle = 0;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > currentCycle)
        {
            currentCycle = Time.time + cycle;
            CreateBullet();
        }
    }

    void CreateBullet()
    {
        //spawn bullets
        Vector2 pos = new Vector2(transform.position.x + 0.3f, transform.position.y + 0.2f);
        Vector2 pos2 = new Vector2(transform.position.x - 0.3f, transform.position.y + 0.2f);
        Instantiate(bullet, pos, Quaternion.identity);
        Instantiate(bullet, pos2, Quaternion.identity);
    }

}
