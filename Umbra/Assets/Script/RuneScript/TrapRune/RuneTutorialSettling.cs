using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuneTutorialSettling : MonoBehaviour {
	public GameObject myRuneManager;

	public int defsetter;
	public int tacticSetter;
	public int OffenseSet;
	public GameObject RuneTaken;
	public bool changeOffRune;
	public bool changeDefRune;
	public bool changeTacticRune;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag=="Player")
		{
			print ("BVugfgmgk");
			if (changeOffRune == true) {
				myRuneManager.GetComponent<RuneManagerScript> ().OffenseRune = OffenseSet;

				PlayerPrefs.SetInt ("RuneOffense", OffenseSet);
			}

			if (changeDefRune == true) {
				PlayerPrefs.SetInt ("RuneDefense", defsetter);
				myRuneManager.GetComponent<RuneManagerScript> ().DefFune = defsetter;
			}
			if (changeTacticRune == true) {
				PlayerPrefs.SetInt ("RuneTactic", tacticSetter);

				myRuneManager.GetComponent<RuneManagerScript> ().TacticRune = tacticSetter;
			}
			myRuneManager.GetComponent<RuneManagerScript> ().RuneSetting ();
			if (changeDefRune == true) {
				if (defsetter == 1)
					myRuneManager.GetComponent<RuneManagerScript> ().ImageRuneOmbre.GetComponent<Animator> ().SetBool ("Play", true);
				if (defsetter == 2)
					myRuneManager.GetComponent<RuneManagerScript> ().ImageRuneLeurre.GetComponent<Animator> ().SetBool ("Play", true);
			}
			if (changeOffRune == true) {
				if (OffenseSet == 1)
					myRuneManager.GetComponent<RuneManagerScript> ().ImageRunePiege.GetComponent<Animator> ().SetBool ("Play", true);
				if (OffenseSet == 2)
					myRuneManager.GetComponent<RuneManagerScript> ().ImageRuneMarquage.GetComponent<Animator> ().SetBool ("Play", true);
			}
			if (changeTacticRune == true) {
				if (tacticSetter == 1)
					myRuneManager.GetComponent<RuneManagerScript> ().ImageRuneAccrochage.GetComponent<Animator> ().SetBool ("Play", true);
				if (tacticSetter == 2)
					myRuneManager.GetComponent<RuneManagerScript> ().ImageRuneSolidification.GetComponent<Animator> ().SetBool ("Play", true);
			}
			if (tacticSetter != 0 || defsetter != 0 || OffenseSet != 0) {
				RuneTaken.SetActive (false);
				AkSoundEngine.PostEvent ("PC_Rune_Select", gameObject);
			}
			GetComponent<Collider2D>().enabled = false;

		
					}
		}
	}


