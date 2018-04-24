using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChooser : MonoBehaviour {

	public GameObject[] objects;

	public void SwitchSceneToDenver(){
		SceneManager.LoadScene("DenverScene", LoadSceneMode.Single);

	}

	public void SwitchScenetoEllsworth(){
		SceneManager.LoadScene ("EllsworthScene", LoadSceneMode.Single);
	}

	public void SwitchScenetoLubbock(){
		SceneManager.LoadScene ("Lubbock", LoadSceneMode.Single);
	}

	public void ToInstruction(){
		objects [0].SetActive (false);
		objects [1].SetActive (true);
	}

	public void Back(){
		objects [0].SetActive (true);
		objects [1].SetActive (false);
	}
}