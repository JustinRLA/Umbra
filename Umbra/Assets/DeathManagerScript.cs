using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManagerScript : MonoBehaviour {
	public Transform SpawnPointOne;
	public Transform SpawnPointTwo;
	public Transform SpawnPointThree;
	public Transform SpawnPointFour;
	public GameObject checkPointManager;
	public GameObject ThePlayer;




	// Use this for initialization
	void Start () {
		Scene CurrentScene = SceneManager.GetActiveScene();
		string scenename = CurrentScene.name;
		if (scenename == "Niveau_1" ||scenename == "Niveau_1_test" )
			ThePlayer = GameObject.Find ("2DCharacter");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayerDeath()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);

		if (checkPointManager.GetComponent<CheckPointState> ().CheckpointState == 0)
			ThePlayer.transform.position = SpawnPointOne.transform.position;

		if (checkPointManager.GetComponent<CheckPointState> ().CheckpointState == 1)
			ThePlayer.transform.position = SpawnPointTwo.transform.position;

		if (checkPointManager.GetComponent<CheckPointState> ().CheckpointState == 2)
			ThePlayer.transform.position = SpawnPointThree.transform.position;

		if (checkPointManager.GetComponent<CheckPointState> ().CheckpointState == 3)
			ThePlayer.transform.position = SpawnPointFour.transform.position;
		
	}

}
