﻿using UnityEngine;
using System.Collections;

public class FlappyBirdKiller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter(Collision collision) {
		Debug.Log (collision.gameObject.name + " passed through these here parts!");
		if (collision.gameObject.CompareTag("Flappy")) {
			GameObject.Destroy(collision.gameObject);
		}
	}
}
