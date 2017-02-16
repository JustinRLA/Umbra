using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCondition : MonoBehaviour {
	public GameObject SetRunner;
	public GameObject myStart;
	SetRune mySetRune;

	// Use this for initialization
	void Start () {
		Cursor.visible = true;
		mySetRune = SetRunner.GetComponent<SetRune> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (mySetRune.TemporaryDefRune != 0 && mySetRune.TemporaryOffenseRune != 0 && mySetRune.TemporaryTacticRune != 0)
			myStart.SetActive (true);
	}
}
