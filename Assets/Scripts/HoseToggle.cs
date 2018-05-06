using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoseToggle : MonoBehaviour {
  private ParticleSystem fluidParticles;
	private AudioSource audio;
  [SerializeField]
  private bool sprayEnabled;
	// Use this for initialization
	void Start () {
    fluidParticles = GetComponent<ParticleSystem>();
		audio = GetComponent<AudioSource> ();
		audio.volume = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
    print("We have this component: " + fluidParticles);
    if (!sprayEnabled) {
      if (Input.GetMouseButton(0)) {
        print("Enabled Spray");
        sprayEnabled = true;
		audio.volume = 1.0f;
        //fluidParticles.emission.enabled = true;
        fluidParticles.Play();
        fluidParticles.enableEmission = true;
      }
    } else {
      if (!Input.GetMouseButton(0)) {
        print("Disabled Spray");
        sprayEnabled = false;
		audio.volume = 0.0f;
        //fluidParticles.emission.enabled = true;
        fluidParticles.enableEmission = false;
        fluidParticles.Stop();
      }
    }
	}
}
