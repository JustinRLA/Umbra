using UnityEngine;
using System.Collections;

public class CheckPointChange : MonoBehaviour {
	public GameObject CheckPointManager;
	public int AssignCheckpoint;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player")
			CheckPointManager.GetComponent<CheckPointState> ().CheckpointState = AssignCheckpoint;
	}
}
