using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoomSettle : MonoBehaviour {
	public GameObject LastEnnemi;
	public GameObject NextEnnemy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D col) {
		if(col.tag=="Player")
		{
			LastEnnemi.SetActive (false);
			NextEnnemy.SetActive (true);

		}

	}
}
