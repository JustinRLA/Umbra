using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarkEnnemy : MonoBehaviour {
	public bool CanBeClicked;
	public GameObject myCamOne;
	public GameObject myCamTwo;
	public GameObject myPlayer;
	GameObject FullMark;
	public bool AnythingToMark;
	public GameObject RuneMan;


	// Use this for initialization
	void Start () {
		if (Input.GetMouseButtonDown (1) && AnythingToMark == false)
			cancelFromThere ();
	}
	
	// Update is called once per frame
	void cancelFromThere()
	{
		RuneMan.GetComponent<RuneManagerScript> ().RuneActivated = false;
		RuneMan.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
		Time.timeScale = 1;
		myPlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		myPlayer.GetComponent<PlatformerCharacter2D> ().enabled = true;
		myPlayer.GetComponent<Platformer2DUserControl> ().enabled = true;


		Cursor.visible = false;
		GetComponent<MarkEnnemy> ().enabled = false;

	}
	void Update () {
		
	}
	public void EnemyMarkedStart()
	{		
		if (GameObject.FindGameObjectWithTag ("ennemy") != null) {
			FullMark = GameObject.Find ("MaquageRuneImageFull");
			FullMark.GetComponent<Image> ().enabled = true;
			print ("Blue");
			myCamOne.GetComponent<Grayscale> ().enabled = false;
			myCamTwo.GetComponent<ColorCorrectionCurves> ().enabled = true;
			RuneMan = GameObject.Find ("RuneManager");

			RuneMan.GetComponent<RuneManagerScript> ().RuneActivated = true;
			AnythingToMark = true;

			CanBeClicked = true;

			Cursor.visible = true;
		}
		else
		{
			RuneMan = GameObject.Find ("RuneManager");

			RuneMan.GetComponent<RuneManagerScript> ().RuneActivated = true;

			FullMark = GameObject.Find ("MaquageRuneImageFull");
			FullMark.GetComponent<Image> ().enabled = true;
			myCamOne.GetComponent<Grayscale> ().enabled = false;
			myCamTwo.GetComponent<ColorCorrectionCurves> ().enabled = true;
			Cursor.visible = true;
			AnythingToMark = false;
		}

	}


}
