using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuneTactUI : MonoBehaviour {
	Image image;
	
	float ratio;
	
	public GameObject RuneManager;
	RuneManagerScript myRuneManager;
	public GameObject Fullimage;
	Image fullImage;

	// Use this for initialization
	void Start () {
		RuneManager = GameObject.Find ("RuneManager");
		image = GetComponent<Image> ();
		fullImage = Fullimage.GetComponent<Image> ();
		myRuneManager = RuneManager.GetComponent<RuneManagerScript> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		ratio = myRuneManager.timerTactic / myRuneManager.ActualTactic;
		//print (ratio);
		image.fillAmount = ratio;
		if (ratio >= 1)
			fullImage.enabled = true;
		else
			fullImage.enabled = false;
	}
}
