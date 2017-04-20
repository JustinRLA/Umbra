using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeryfyCol : MonoBehaviour {
	public GameObject BeamToTouch;
	public GameObject myRuneMan;

	// Use this for initialization
	void Start () {
		myRuneMan = GameObject.Find ("RuneManager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject == BeamToTouch)
			myRuneMan.GetComponent<LineRendererTest> ().StopThisThing ();
	}
}
