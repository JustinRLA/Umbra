using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnTONormal : MonoBehaviour {
	public bool isIn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Player")
			isIn = true;
		
	}
	void OnTriggerExit2D (Collider2D col) {
		if (col.tag == "Player")
			isIn = false;

	}
}
