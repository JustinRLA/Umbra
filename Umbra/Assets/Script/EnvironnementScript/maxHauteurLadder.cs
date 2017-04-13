using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxHauteurLadder : MonoBehaviour {
	public Transform MaxHauteur;
	public Transform MinHauteur;
	public bool TouchShadow;
	public bool CheckRight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player")
			TouchShadow = true;
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player")
			TouchShadow = false;
	}
}
