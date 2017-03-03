using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearViewTrigger : MonoBehaviour {
	public GameObject MySight;
	public GameObject EnnemyBase;
	public GameObject mySignListener;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D col) {
		//print ("fuckkkkkkkkk");
		if (col.tag == "ViewTrigger" && MySight.GetComponent<SightListenerTemplate>().iSeeYou==true) {
//			EnnemyBase.GetComponent<EnnnemyPatrolUpgraded> ().timerState = 30;
//			EnnemyBase.GetComponent<EnnnemyPatrolUpgraded> ().Alert = true;
			mySignListener.GetComponent <SightListenerTemplate>().throwAlert=true;

			print ("fuckkkkkkkkk");
	}
	}
}
