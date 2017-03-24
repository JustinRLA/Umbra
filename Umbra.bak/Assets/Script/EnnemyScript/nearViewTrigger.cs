using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearViewTrigger : MonoBehaviour {
	public GameObject MySight;
	public GameObject EnnemyBase;
	public GameObject mySignListener;
	public bool inSigght;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(MySight.GetComponent<SightListenerTemplate>().iSeeYou==true && inSigght==true)
		{
			//			EnnemyBase.GetComponent<EnnnemyPatrolUpgraded> ().timerState = 30;
			//			EnnemyBase.GetComponent<EnnnemyPatrolUpgraded> ().Alert = true;
			mySignListener.GetComponent <SightListenerTemplate>().throwSuspicious=false;

			mySignListener.GetComponent <SightListenerTemplate>().throwAlert=true;
			EnnemyBase.GetComponent<EnnnemyPatrolUpgraded> ().timerState = 24;

		}

	}
	void OnTriggerEnter2D (Collider2D col) {
		//print ("fuckkkkkkkkk");
		if (col.tag == "ViewTrigger")
		{
			inSigght = true;
			print ("fuckkkkkkkkk");

		}
	}
	void OnTriggerExit2D (Collider2D col) {
		//print ("fuckkkkkkkkk");
		if (col.tag == "ViewTrigger")
		{
			inSigght = false;
		}
	}

}
