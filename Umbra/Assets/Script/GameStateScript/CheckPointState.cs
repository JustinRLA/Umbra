﻿using UnityEngine;
using System.Collections;

public class CheckPointState : MonoBehaviour {
	public int CheckpointState=0;
	public GameObject savesystem;
	public float timer=3; 
	public bool Testing;
	public Transform SpawnPointOne;
	public Transform SpawnPointTwo;
	public Transform SpawnPointThree;
	public Transform SpawnPointFour;
	public GameObject DeathManager;
	public GameObject OldCheckPointState;
	public int Counter;
	void Awake()
	{		
	}
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
		if(Testing==false)
		{
		savesystem = GameObject.Find ("SaveSystem");
		CheckpointState = savesystem.GetComponent<SaveSystem> ().SavePoint;
	}
		if (Counter >= 1)
		{
			OldCheckPointState=GameObject.Find("CheckPointManager");
			Destroy (OldCheckPointState);
		}

		StartCoroutine (Rename ());


	}
	// Update is called once per frame
	void Update () {
//		if(Testing==false)
//		{
//		timer -= Time.deltaTime;
//
//		if (timer <= 0)
//			savesystem.GetComponent<SaveSystem> ().SavePoint=CheckpointState;
//	}
}
	IEnumerator Rename()
	{
		yield return new WaitForSeconds (2f);
	gameObject.name="OnlyChekPointState";


	
	}
}
