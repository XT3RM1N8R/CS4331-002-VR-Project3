﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KeepScore : MonoBehaviour {
  public int score = 0;
	public Text text;
  public int scoreMultiplier = 1;
	private GameObject sendScore;

	void Start(){
		sendScore = GameObject.Find("Timer");
		text.text = "Score: " + score;
	}

  void Update() {
		text.text = "Score: " + score;
		if (Input.GetKeyDown("5")) 
		{
			score = score + 100;
		}
		sendScore.GetComponent<Timer>().sendscore(score);
	}

  public void updateScore(int newScore) {
    score = newScore;
  }

  public void addToScore(int points) {
    updateScore(score + (points * scoreMultiplier));
  }

  public void subtractFromScore(int points) {
    updateScore(score - points);
  }
}
