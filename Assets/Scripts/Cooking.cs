using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooking : MonoBehaviour {
	
	public GameObject omelette;
	string lastFood;

	// Use this for initialization
	void Start () {
		lastFood = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col) {
		if (lastFood.Equals ("")) {
			if (col.gameObject.tag == "egg") {
				lastFood = "egg";
			} else if (col.gameObject.tag == "ham") {
				lastFood = "ham";
			}
		} else if (lastFood.Equals ("egg")) {
			if (col.gameObject.tag == "ham") {
				GameObject.Instantiate (omelette, col.transform);
			}
		}
	}
}
