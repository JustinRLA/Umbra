using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterTaken : MonoBehaviour {
	public GameObject CanvatexteFr;
	public GameObject CanvatexteEng;
	public int LetterNumber;
	public GameObject ClosureBase;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.tag=="Player")
		{
			
			if (LetterNumber == 1) {
				PlayerPrefs.SetInt ("LetterOne", 1);
			}
			if (LetterNumber == 2) {
				PlayerPrefs.SetInt ("LetterTwo", 1);
			}
			if (LetterNumber == 3) {
				PlayerPrefs.SetInt ("LetterThree", 1);	
			}
			if (LetterNumber == 4) {
				PlayerPrefs.SetInt ("LetterFour", 1);
			}
			if (LetterNumber == 5) {
				PlayerPrefs.SetInt ("LetterFive", 1);
			}
		Destroy (gameObject);

		}

	}
}
