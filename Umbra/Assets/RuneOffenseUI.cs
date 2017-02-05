using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RuneOffenseUI : MonoBehaviour {
	Image image;
	float ratio;

	public GameObject RuneManager;
	RuneManagerScript myRuneManager;

	// Use this for initialization
	void Start () {
		image = GetComponent<Image> ();
		myRuneManager = RuneManager.GetComponent<RuneManagerScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		ratio = myRuneManager.timerOffense / myRuneManager.ActualOffense;
		image.rectTransform.localScale = new Vector3 (ratio, 1, 1);
	}
}
