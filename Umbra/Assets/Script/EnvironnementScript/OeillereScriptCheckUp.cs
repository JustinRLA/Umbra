﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OeillereScriptCheckUp : MonoBehaviour {
	bool IsInside;
	public GameObject Base;
	public bool inJudaMode;
	public GameObject feedbackOeillere;

	// Use this for initialization
	void Start () {
		feedbackOeillere=GameObject.Find("feedbackOeillere");

	}
	
	// Update is called once per frame
	void Update () {
		if (IsInside && Input.GetKeyDown (KeyCode.E)) 
			inJudaMode = true;

		if(IsInside==true && inJudaMode==false)
			feedbackOeillere.GetComponent<SpriteRenderer>().enabled=true;
		else
			feedbackOeillere.GetComponent<SpriteRenderer>().enabled=false;


		if(inJudaMode==true)
		{
			Base.layer = 2;
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
		if (col.tag == "Player")
		{
			IsInside=false;
			inJudaMode=false;
		} 
	} 



}
