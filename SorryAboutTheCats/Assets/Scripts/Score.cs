using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int score = 10;
    public float cycleTimer;
    float cycle = 0;
	public Text scoreText;

    public void AddScore(int score)
    {
        this.score += score;
        SetScore();
    }

    public void RemoveScore(int score)
    {
        this.score -= score;
        SetScore();
    }

    void SetScore()
    {
        scoreText.text = this.score.ToString();
    }

    void Update()
    {
        if (Time.time > cycle)
        {
            score--;
			cycle = cycleTimer + Time.time;
            SetScore();
        }
    }
}
