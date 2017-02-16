using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCloneEnnemy : MonoBehaviour {
	public GameObject OriginalEnnemy;
	public GameObject CloneEnnemy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag=="ennemy")
		{
			CloneEnnemy.SetActive (true);
			CloneEnnemy.GetComponent<ClonePatrol> ().timerState = col.GetComponent <EnnnemyPatrol> ().timerState;
			CloneEnnemy.GetComponent<ClonePatrol> ().PhamomPoint=col.GetComponent <EnnnemyPatrol> ().PhamomPoint;
			col.gameObject.SetActive (false);
			gameObject.GetComponent<Collider2D>().enabled=true;
		}
		if(col.tag=="ennemyClone")
		{
			OriginalEnnemy.SetActive (true);
			OriginalEnnemy.GetComponent<EnnnemyPatrol> ().timerState = col.GetComponent <ClonePatrol> ().timerState;
			OriginalEnnemy.GetComponent<EnnnemyPatrol> ().PhamomPoint=col.GetComponent <ClonePatrol> ().PhamomPoint;
			col.gameObject.SetActive (false);
			gameObject.GetComponent<Collider2D>().enabled=true;
		}
	}


}
