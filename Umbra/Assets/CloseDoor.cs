using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour {
	public GameObject Door;
	public GameObject DoorCol;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Player")
			Door.GetComponent<Animator> ().SetBool ("Play", true);
		DoorCol.SetActive (true);
	}

}
