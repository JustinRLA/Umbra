﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SolidifcationEnabled : MonoBehaviour {
	public bool CanClickable=false;
//	public GameObject MyCache;
	public GameObject Test;
	public GameObject[] AllShadow;
	GameObject FullRune;
	GameObject RuneManager;
	GameObject PlayerMy;
	// Use this for initialization
	void Start () {
		RuneManager = GameObject.Find ("RuneManager");
		CanClickable=false;
		PlayerMy = GameObject.Find("2DCharacter(Clone)");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SolidificationStart()
	{		
		if(GameObject.FindGameObjectsWithTag ("Ombre") != null && GameObject.FindGameObjectWithTag ("Ombre") != null)
		{
			
			print ("thereis asgadiw");
		Cursor.visible = true;
			Test = GameObject.FindGameObjectWithTag ("Ombre");
		CanClickable = true;
		FullRune = GameObject.Find ("solideImageFull");
		FullRune.GetComponent<Image> ().enabled = true;
		RuneManager = GameObject.Find ("RuneManager");

		AllShadow = GameObject.FindGameObjectsWithTag ("Ombre");

		foreach (GameObject Ombre in AllShadow)
		{
			Ombre.GetComponent<Collider2D> ().isTrigger = false;
			Ombre.layer = 23;
			Ombre.GetComponent<solifyShadow> ().enabled = true;
			Ombre.GetComponent<solifyShadow> ().enable = true;

		}
		RuneManager.GetComponent<RuneManagerScript> ().RuneActivated = true;
		print ("sp;od");
	//MyCache.SetActive (true);
		}
		else
		{
			Time.timeScale = 1;
			RuneManager.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
			PlayerMy.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
			PlayerMy.GetComponent<PlatformerCharacter2D> ().enabled = true;
			PlayerMy.GetComponent<Platformer2DUserControl> ().enabled = true;



		}
	}
}