using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLay : MonoBehaviour {


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Time.timeScale = 1;
        }
    }
}
