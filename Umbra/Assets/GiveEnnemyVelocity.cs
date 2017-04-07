using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveEnnemyVelocity : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D col) {
		if(col.tag=="ennemy"){
			col.GetComponent<EnnnemyPatrolUpgraded> ().timerState = 10;
			col.GetComponent<EnnnemyPatrolUpgraded> ().speed = 150;
			Destroy (gameObject);

		
		}
		}
}
