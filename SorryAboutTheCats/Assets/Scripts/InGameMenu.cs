using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenu : MonoBehaviour {

    public Transform Canvas;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }
    public void Pause()
    {
        if
            (Canvas.gameObject.activeInHierarchy == false)

        {
            Canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            print("Paused");
        }
        else if (Canvas.gameObject.activeInHierarchy == true)
        {
            Canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            print("Unpaused");
        }
    }
}
