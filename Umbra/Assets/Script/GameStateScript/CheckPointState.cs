using UnityEngine;
using System.Collections;

public class CheckPointState : MonoBehaviour {
	public int CheckpointState=0;
	public GameObject savesystem;
	public float timer=3; 

	// Use this for initialization
	void Start () {
		savesystem = GameObject.Find ("SaveSystem");
		CheckpointState = savesystem.GetComponent<SaveSystem> ().SavePoint;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer <= 0)
			savesystem.GetComponent<SaveSystem> ().SavePoint=CheckpointState;
	}
}
