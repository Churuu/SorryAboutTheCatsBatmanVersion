using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullets : MonoBehaviour
{

    public GameObject bullet;

	void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
            CreateBullet();
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
