using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
	public GameObject[] objects;
	float timeLeft = 150.0f;

	public Text text;
	public int score = 0;

	private GameObject sendScore;



	void Update()
	{
		score = score;
		timeLeft -= Time.deltaTime;
		text.text = "Time Left:" + Mathf.Round (timeLeft);
		if (timeLeft < 0) {
			text.text = "GAME OVER";
			Screen.lockCursor = false;
			objects [0].SetActive (false);
			objects [1].SetActive (true);
			objects [2].SetActive (false);
			objects [3].SetActive (true);
			sendScore = GameObject.Find ("EndScore");
			sendScore.GetComponent<EndScore> ().endscore (score);
			Screen.lockCursor = false;

			//Application.LoadLevel("gameOver");
		}
	}

		public void sendscore(int points) {
			score = points;
		}

}