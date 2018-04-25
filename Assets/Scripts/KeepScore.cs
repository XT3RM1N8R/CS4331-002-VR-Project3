using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KeepScore : MonoBehaviour
{
	int score = 0;

	public Text text;



	void Update()
	{
		text.text = "Score: " + score;
		if (Input.GetKeyDown("5")) 
		{
			score = score + 100;
			//Application.LoadLevel("gameOver");
		}
	}
}
