﻿using UnityEngine;
using System.Collections;

public class DeadScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("Im Dead");
		gameObject.tag="Dead Ennemy";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void EnnemyDeath()
	{
		print("Im Dead");
		gameObject.tag="Dead Ennemy";
		gameObject.GetComponent<BoxCollider2D> ().isTrigger = true;


	}
}
