using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRise : MonoBehaviour {
  public float fast = 2;
  public float slow = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    if (this.transform.position.y <= 195) {
      this.transform.position = this.transform.position + new Vector3(0, fast / slow, 0);
    }
	}
}
