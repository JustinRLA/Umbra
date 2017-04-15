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
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void EnemyMarkedStart()
	{		
		FullMark = GameObject.Find ("MaquageRuneImageFull");
		FullMark.GetComponent<Image> ().enabled = true;
		print ("Blue");
		myCamOne.GetComponent<Grayscale> ().enabled = false;
		myCamTwo.GetComponent<ColorCorrectionCurves> ().enabled = true;


		CanBeClicked = true;

		Cursor.visible = true;


	}


}
