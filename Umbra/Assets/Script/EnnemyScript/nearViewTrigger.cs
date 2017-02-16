using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearViewTrigger : MonoBehaviour {
	public GameObject MySight;
	public GameObject EnnemyBase;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D col) {
		//print ("fuckkkkkkkkk");
		if (col.tag == "Player" && MySight.GetComponent<SightListenerTemplate>().iSeeYou==true) {
			EnnemyBase.GetComponent<EnnnemyPatrol> ().Alert = true;
			EnnemyBase.GetComponent<EnnnemyPatrol> ().timerState = 30;
	}
	}
}
