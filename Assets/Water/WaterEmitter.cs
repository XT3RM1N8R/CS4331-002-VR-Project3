using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEmitter : MonoBehaviour {
  public bool canEmit = true;
  public int emitAmount = 1;
  public int countDown = 1000;
  public int emitVelocity = 100;
  public Rigidbody sourceObject;
  public int currentCount;
	// Use this for initialization
	void Start () {
    if (emitAmount < 1) {
      emitAmount = 1;
    }
    if (countDown < 0) {
      countDown = 0;
    }
    if (emitVelocity < 0) {
      emitVelocity = 0;
    }
    currentCount = countDown;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentCount <= 0 && canEmit) {
      for (int i = emitAmount; i > 0; i--) {
        Rigidbody waterSphere = (Rigidbody)Instantiate(sourceObject, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation, transform);
        waterSphere.velocity = new Vector3(0, emitVelocity * -1, 0);
      }
      currentCount = countDown;
    } else {
      if (currentCount > 0) {
        currentCount--;
      }
    }
	}
}
