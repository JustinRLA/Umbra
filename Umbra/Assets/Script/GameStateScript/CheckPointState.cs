using UnityEngine;
using System.Collections;

public class CheckPointState : MonoBehaviour {
	public int CheckpointState=0;
	public GameObject savesystem;
	public float timer=3; 
	public bool Testing;
	public Transform SpawnPointOne;
	public Transform SpawnPointTwo;
	public Transform SpawnPointThree;
	public Transform SpawnPointFour;
	public GameObject DeathManager;

	void Awake()
	{		
		DeathManager = GameObject.Find ("deathManager");
		print ("Test");
		DeathManager.GetComponent<DeathManagerScript> ().SpawnPointOne = SpawnPointOne;
		DeathManager.GetComponent<DeathManagerScript> ().SpawnPointTwo = SpawnPointTwo;
		DeathManager.GetComponent<DeathManagerScript> ().SpawnPointThree = SpawnPointThree;
		DeathManager.GetComponent<DeathManagerScript> ().SpawnPointFour = SpawnPointFour;
		//DeathManager.GetComponent<DeathManagerScript> ().ThePlayer = GameObject.Find ("2DCharacter(Clone)");
		DeathManager.GetComponent<DeathManagerScript> ().FirstTime();


	//	if(	DeathManager.GetComponent<DeathManagerScript> ().timeScene<=0)

	DeathManager.GetComponent<DeathManagerScript> ().timeScene++;

			
	}
	// Use this for initialization
	void Start () {

		if(Testing==false)
		{
		savesystem = GameObject.Find ("SaveSystem");
		CheckpointState = savesystem.GetComponent<SaveSystem> ().SavePoint;
	}



	}
	// Update is called once per frame
	void Update () {
//		if(Testing==false)
//		{
//		timer -= Time.deltaTime;
//
//		if (timer <= 0)
//			savesystem.GetComponent<SaveSystem> ().SavePoint=CheckpointState;
//	}
}
}
