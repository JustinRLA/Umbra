﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oeillereChecjBoth : MonoBehaviour {
	bool IsInside;
	public GameObject Base;
	public bool inJudaMode;
	public GameObject feedbackOeillere;
	public GameObject PlayeroNE;

	// Use this for initialization
	void Start () {
		feedbackOeillere=GameObject.Find("feedbackOeillere");
		PlayeroNE=GameObject.Find("2DCharacter");
	}

	// Update is called once per frame
	void Update () {
		if (IsInside && Input.GetKeyDown (KeyCode.E)) 
			inJudaMode = true;

		if(IsInside==true && inJudaMode==false)
			feedbackOeillere.GetComponent<SpriteRenderer>().enabled=true;


		if(inJudaMode==true)
		{
			if(PlayeroNE.transform.position.y<=transform.position.y)
			Base.layer = 2;
			else
				Base.layer = 1;
		}
		else
			Base.layer = 0;

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player")
			IsInside = true;

	} 	void OnTriggerExit2D(Collider2D col)
	{
		feedbackOeillere.GetComponent<SpriteRenderer>().enabled=false;

		if (col.tag == "Player")
		{
			IsInside=false;
			inJudaMode=false;
		} 
	} 



}
