using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathByWater : MonoBehaviour {
  public int endurance = 10000;
  public int resistance = 10;
  public int damage = 1000;
  private bool isAlive = true;
	// Use this for initialization
	void Start () {
		
	}

  // Update is called once per frame
  void Update() {
    if (endurance <= 0 && isAlive) {
      isAlive = false;
      print("Fire is Extinguished");
      foreach(Transform child in this.transform) {
        ParticleSystem particleSystem = child.gameObject.GetComponent<ParticleSystem>();
        if(particleSystem) {
          particleSystem.enableEmission = false;
          particleSystem.Stop();
        } else {
          child.gameObject.SetActive(false);
        }
      }
    }
  }

  void OnParticleCollision(GameObject other) {
    if (other.tag == "Water") {
      endurance -= damage / resistance;
    }
  }
}
