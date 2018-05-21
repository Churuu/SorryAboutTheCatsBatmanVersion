using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

	public int score;

	public void AddScore(int score)
	{
		this.score += score;
	}

	public void RemoveScore(int score)
	{
		this.score -= score;
	}
}
