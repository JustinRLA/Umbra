using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointOnLoad : MonoBehaviour {
	public GameObject DeathManager;
	public Transform SpawnPointOne;
	public Transform SpawnPointTwo;
	public Transform SpawnPointThree;
	public Transform SpawnPointFour;

	// Use this for initialization
	void Start () {
		DeathManager = GameObject.Find ("deathManager");
		if (DeathManager.GetComponent<DeathManagerScript> ().CheckPointState == 0)
			transform.position = SpawnPointOne.transform.position;
		if (DeathManager.GetComponent<DeathManagerScript> ().CheckPointState == 1)
			transform.position = SpawnPointTwo.transform.position;
		if (DeathManager.GetComponent<DeathManagerScript> ().CheckPointState == 2)
			transform.position = SpawnPointThree.transform.position;	
		if (DeathManager.GetComponent<DeathManagerScript> ().CheckPointState == 3)
			transform.position = SpawnPointFour.transform.position;	
		if (DeathManager.GetComponent<DeathManagerScript> ().CheckPointState == 1)
			transform.position = SpawnPointOne.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
