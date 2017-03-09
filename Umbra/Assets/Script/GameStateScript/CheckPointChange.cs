using UnityEngine;
using System.Collections;

public class CheckPointChange : MonoBehaviour {
	public GameObject CheckPointManager;
	public int AssignCheckpoint;
	public GameObject DeathManager;
	// Use this for initialization
	void Start () {
		DeathManager=GameObject.Find("deathManager");

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		//print ("Check");

		if (col.tag == "Player")
		{
			CheckPointManager.GetComponent<CheckPointState> ().CheckpointState = AssignCheckpoint;
			//print ("Check");
			DeathManager.GetComponent<DeathManagerScript>().CheckPointState=CheckPointManager.GetComponent<CheckPointState> ().CheckpointState = AssignCheckpoint;
		}

	}
}
