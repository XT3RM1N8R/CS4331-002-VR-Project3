using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoseToggle : MonoBehaviour {
  private ParticleSystem fluidParticles;
  [SerializeField]
  private bool sprayEnabled;
	// Use this for initialization
	void Start () {
    fluidParticles = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
    print("We have this component: " + fluidParticles);
    if (!sprayEnabled) {
      if (Input.GetMouseButton(0)) {
        print("Enabled Spray");
        sprayEnabled = true;
        //fluidParticles.emission.enabled = true;
        fluidParticles.Play();
        fluidParticles.enableEmission = true;
      }
    } else {
      if (!Input.GetMouseButton(0)) {
        print("Disabled Spray");
        sprayEnabled = false;
        //fluidParticles.emission.enabled = true;
        fluidParticles.enableEmission = false;
        fluidParticles.Stop();
      }
    }
	}
}
