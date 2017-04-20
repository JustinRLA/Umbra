using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearViewTrigger : MonoBehaviour {
	public GameObject MySight;
	public GameObject EnnemyBase;
	public bool inSigght;
	SightListenerTemplate mySightList;
	EnnnemyPatrolUpgraded myPatrol;
	// Use this for initialization
	void Start () {
		mySightList = MySight.GetComponent<SightListenerTemplate> ();
		myPatrol = EnnemyBase.GetComponent<EnnnemyPatrolUpgraded> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(mySightList.iSeeYou==true && inSigght==true)
		{
			//			EnnemyBase.GetComponent<EnnnemyPatrolUpgraded> ().timerState = 30;
			//			EnnemyBase.GetComponent<EnnnemyPatrolUpgraded> ().Alert = true;
			mySightList.throwSuspicious=false;

			mySightList.throwAlert=true;
			myPatrol.timerState = 24;
		}

	}
	void OnTriggerEnter2D (Collider2D col) {
		//print ("fuckkkkkkkkk");
		if (col.tag == "Player"  )
		{
			inSigght = true;
			//print ("fuckkkkkkkkk");
		}
		if (col.tag == "LurePlayer"  )
		{
			mySightList.IsawTheLure = true;
			//print ("fuckkkkkkkkk");
		}
	}
		
	void OnTriggerExit2D (Collider2D col) {
		//print ("fuckkkkkkkkk");
		if (col.tag == "Player")
		{
			inSigght = false;
		}

	}

}
