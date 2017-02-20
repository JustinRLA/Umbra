using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAlert : MonoBehaviour {
	public GameObject EnnemyBase;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Player") 
		{
			EnnemyBase.GetComponent<EnnnemyPatrolUpgraded> ().Alert=true;
			EnnemyBase.GetComponent<EnnnemyPatrolUpgraded> ().timerState = 30;

		}
		}

}
