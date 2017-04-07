using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuneTutorialSettling : MonoBehaviour {
	public GameObject myRuneManager;

	public int defsetter;
	public int tacticSetter;
	public int OffenseSet;

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
			PlayerPrefs.SetInt ("RuneOffense", OffenseSet);
			PlayerPrefs.SetInt ("RuneDefense", defsetter);
			PlayerPrefs.SetInt ("RuneTactic", tacticSetter);


			myRuneManager.GetComponent<RuneManagerScript> ().DefFune = defsetter;
			myRuneManager.GetComponent<RuneManagerScript> ().OffenseRune = OffenseSet;
			myRuneManager.GetComponent<RuneManagerScript> ().TacticRune = tacticSetter;
			myRuneManager.GetComponent<RuneManagerScript> ().RuneSetting ();


		}
	}

}
