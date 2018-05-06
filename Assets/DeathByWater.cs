using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathByWater : MonoBehaviour {
  public int endurance = 10000;
  public int resistance = 10;
  public int damage = 1000;
	// Use this for initialization
	void Start () {
		
	}

  // Update is called once per frame
  void Update() {
    if (endurance <= 0) {
      Destroy(this.gameObject);
    }
  }

  void OnParticleCollision(GameObject other) {
    print("Collision");
    if (other.tag == "Water") {
      endurance -= damage / resistance;
      print("Fire being extinguished");
    }
  }
}
