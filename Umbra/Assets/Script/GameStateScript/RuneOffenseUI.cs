using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RuneOffenseUI : MonoBehaviour {
	Image image;
	float ratio;
	public GameObject FullImage;
	Image imagefull;
	//public GameObject FullImage;

	public GameObject RuneManager;
	RuneManagerScript myRuneManager;

	// Use this for initialization
	void Start () {
		imagefull = FullImage.GetComponent<Image> ();
		RuneManager = GameObject.Find ("RuneManager");

		image = GetComponent<Image> ();
		myRuneManager = RuneManager.GetComponent<RuneManagerScript> ();

	}
	
	// Update is called once per frame
	void Update () {
		ratio = myRuneManager.timerOffense / myRuneManager.ActualOffense;
//		print (ratio);
		image.fillAmount = ratio;
		if (ratio >= 1)
		{
			imagefull.enabled = true;

		}
		else
		{
			imagefull.enabled = false;		}
	}
}
