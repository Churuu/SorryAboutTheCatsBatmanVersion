using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private int randomNr = 2;

    void Start()
    {
        StartCoroutine(timedRandomize());
    }

    void Update()
    {

    }

    public void Randomize(int min, int max)
    {
        randomNr = Random.Range(min, max);
    }

    public int getRandom()
    {
        return randomNr;
    }

    private IEnumerator timedRandomize()
    {
        yield return new WaitForSeconds(3);
        Randomize(0, 13);
        StartCoroutine(timedRandomize());
    }
}
