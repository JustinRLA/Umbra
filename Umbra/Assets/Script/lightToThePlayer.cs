﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightToThePlayer : MonoBehaviour {
	public GameObject thePlayer;
	public float lightDistance;
	// Use this for initialization
	void Start () {
		thePlayer = GameObject.Find("2DCharacter(Clone)");

		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = thePlayer.transform.position ;
		transform.position = new Vector3(thePlayer.transform.position.x, thePlayer.transform.position.y,lightDistance);
	}
}
