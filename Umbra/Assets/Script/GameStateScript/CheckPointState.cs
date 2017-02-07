﻿using UnityEngine;
using System.Collections;

public class CheckPointState : MonoBehaviour {
	public int CheckpointState=0;
	public GameObject savesystem;
	public float timer=3; 
	public bool Testing;

	// Use this for initialization
	void Start () {
		if(Testing==false)
		{
		savesystem = GameObject.Find ("SaveSystem");
		CheckpointState = savesystem.GetComponent<SaveSystem> ().SavePoint;
	}
	}
	// Update is called once per frame
	void Update () {
		if(Testing==false)
		{
		timer -= Time.deltaTime;

		if (timer <= 0)
			savesystem.GetComponent<SaveSystem> ().SavePoint=CheckpointState;
	}
	}
}
