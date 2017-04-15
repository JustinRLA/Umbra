using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RuneOffenseUI : MonoBehaviour {
	Image image;
	float ratio;
	Image imagefull;
	//public GameObject FullImage;

	public GameObject RuneManager;
	RuneManagerScript myRuneManager;

	// Use this for initialization
	void Start () {
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
			transform.parent.gameObject.SetActive (false);
		}
}
}