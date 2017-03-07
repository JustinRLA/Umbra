using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuneTutorialSettling : MonoBehaviour {
	public GameObject myRuneManager;

	public GameObject OffenseRuneUI;
	public GameObject DefRuneUI;
	public GameObject TacticRuneUI;
	public bool DeavtivaedOffense;
	public bool DeavtivaeDefe;
	public bool DeavtivaeTactic;

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
			myRuneManager.GetComponent<RuneManagerScript> ().DefFune = defsetter;
			myRuneManager.GetComponent<RuneManagerScript> ().OffenseRune = OffenseSet;
			myRuneManager.GetComponent<RuneManagerScript> ().TacticRune = tacticSetter;
			OffenseRuneUI.GetComponent<Image> ().enabled = DeavtivaedOffense;
			DefRuneUI.GetComponent<Image> ().enabled = DeavtivaeDefe;
			TacticRuneUI.GetComponent<Image> ().enabled = DeavtivaeTactic;


		}
	}

}
