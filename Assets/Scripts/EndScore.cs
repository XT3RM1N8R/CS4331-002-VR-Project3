using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndScore : MonoBehaviour {

	public int score = 0;
	public Text text;

	// Use this for initialization
	void Start () {
		text.text = "Score: " + score;
		
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " + score;
		
	}



	public void endscore(int points) {
		score = points;
	}
}
