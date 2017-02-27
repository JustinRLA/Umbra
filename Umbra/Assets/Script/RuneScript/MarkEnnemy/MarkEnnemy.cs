using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkEnnemy : MonoBehaviour {
	public GameObject Cache;
	public bool CanBeClicked;
	public GameObject myCamOne;
	public GameObject myCamTwo;
	public GameObject myPlayer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void EnemyMarkedStart()
	{		
		print ("Blue");
		myCamOne.GetComponent<Grayscale> ().enabled = false;
		myCamTwo.GetComponent<ColorCorrectionCurves> ().enabled = true;


		CanBeClicked = true;

		//print ("Done");
		Cache.SetActive (true);
		Cursor.visible = true;


	}


}
