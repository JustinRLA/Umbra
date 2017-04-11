using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTutoEvent : MonoBehaviour {
	//ENNEMY BAIT!!!!!!!!!!!!!!!!
	public GameObject EnnemyTarget;
	public Transform PhantomPoint;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag=="Player")
		{
			EnnemyTarget.GetComponent<EnnnemyPatrolUpgraded> ().PhamomPoint.position = PhantomPoint.position;
			EnnemyTarget.GetComponent<EnnnemyPatrolUpgraded> ().timerState = 13; 
		}

	}
}
