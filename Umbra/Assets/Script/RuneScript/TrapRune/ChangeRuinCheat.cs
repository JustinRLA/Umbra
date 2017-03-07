using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRuinCheat : MonoBehaviour {
	public GameObject myRuneManager;

	// Use this for initialization
	void Start () {
		myRuneManager = GameObject.Find ("RuneManager");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha4))
			myRuneManager.GetComponent<RuneManagerScript> ().DefFune = 1;
		if (Input.GetKeyDown (KeyCode.Alpha5))
			myRuneManager.GetComponent<RuneManagerScript> ().DefFune = 2;
		if (Input.GetKeyDown (KeyCode.Alpha6))
			myRuneManager.GetComponent<RuneManagerScript> ().OffenseRune = 1;
		if (Input.GetKeyDown (KeyCode.Alpha7))
			myRuneManager.GetComponent<RuneManagerScript> ().OffenseRune = 2;
		if (Input.GetKeyDown (KeyCode.Alpha8))
			myRuneManager.GetComponent<RuneManagerScript> ().TacticRune = 1;
		if (Input.GetKeyDown (KeyCode.Alpha9))
			myRuneManager.GetComponent<RuneManagerScript> ().TacticRune = 2;
		
		
		
	}
}
