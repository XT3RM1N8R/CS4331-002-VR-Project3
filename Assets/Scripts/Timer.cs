﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
	float timeLeft = 180.0f;

	public Text text;



	void Update()
	{
		timeLeft -= Time.deltaTime;
		text.text = "Time Left:" + Mathf.Round(timeLeft);
		if(timeLeft < 0)
		{
			text.text = "GAME OVER";
			//Application.LoadLevel("gameOver");
		}
	}
}