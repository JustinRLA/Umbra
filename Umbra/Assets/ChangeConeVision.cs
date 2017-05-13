using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeConeVision : MonoBehaviour {
	public GameObject myEnnemy;
	EnnnemyPatrolUpgraded myPat;
	public GameObject ConeAlerte;
	public GameObject ConeNormal;
	public GameObject ConeSuspicious;

	// Use this for initialization
	void Start () {
		myPat = myEnnemy.GetComponent<EnnnemyPatrolUpgraded> ();
		InvokeRepeating ("CheckCone",1,0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CheckCone()
	{
		if (myPat.Alert == true) {
			ConeAlerte.SetActive (true);
			ConeNormal.SetActive (false);
			ConeSuspicious.SetActive (false);
		}
		if (myPat.Suspicious == true) {
			ConeAlerte.SetActive (false);
			ConeNormal.SetActive (false);
			ConeSuspicious.SetActive (true);
		}

		if (myPat.Suspicious == false && myPat.Alert==false) {
			ConeAlerte.SetActive (false);
			ConeNormal.SetActive (true);
			ConeSuspicious.SetActive (false);
		}

	}
	 
}
