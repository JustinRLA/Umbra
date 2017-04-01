﻿using UnityEngine;
using System.Collections;

public class checkIfAssassination : MonoBehaviour {
	
	public GameObject AssassinFeedback;
	public bool canAssassinate;
	public GameObject ActualEnnemy;
	public GameObject Playa;

	// Use this for initialization
	void Start () {
		Playa = GameObject.Find("2DCharacter(Clone)");
	}

	// Update is called once per frame
	void Update () {
//		if(Input.GetKeyDown(KeyCode.Alpha1))
//			Playa.GetComponent<DeathEvent> ().chooseSprite ();
		

		if(canAssassinate==true)
		{
			AssassinFeedback.SetActive (true);
			if (Input.GetKeyDown (KeyCode.E))
			{
				Assassination();
			}
		}
		if(canAssassinate==false || ActualEnnemy == null)
			AssassinFeedback.SetActive (false);
		

	}
	void OnTriggerEnter2D (Collider2D col) {

//		else
//			canAssassinate = false;
		

		if (col.tag == "ennemy") {
//		
				canAssassinate = true;
				ActualEnnemy = col.gameObject;

		} 
//		else
//			canAssassinate = false;
	}

	void Assassination()
	{
		Playa.GetComponent<DeathEvent> ().chooseSprite ();
		print ("I kill you");	
		ActualEnnemy.tag = "Dead Ennemy";
		ActualEnnemy.layer = 27;

		ActualEnnemy.GetComponent<Collider2D> ().enabled = false;

		ActualEnnemy.GetComponent<EnnnemyPatrolUpgraded> ().Alert = false;
		ActualEnnemy.GetComponent<EnnnemyPatrolUpgraded> ().isdead = true;
		ActualEnnemy.GetComponent<EnnnemyPatrolUpgraded> ().enabled = false;
		ActualEnnemy.GetComponent<DeadScript> ().enabled = true;
		ActualEnnemy.GetComponent<DeadScript> ().EnnemyDeath();
		AssassinFeedback.SetActive (false);
		canAssassinate = false;


	}

	void OnTriggerExit2D (Collider2D col) {
		if(col.tag=="ennemy")
		{
			canAssassinate=false;

		}
	
		}

		}
