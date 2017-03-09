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

	public int CheckPointState;



	// Use this for initialization
	void Start () {
		Scene CurrentScene = SceneManager.GetActiveScene();
		string scenename = CurrentScene.name;
		if (scenename == "Niveau_1" ||scenename == "Niveau_1_test" )
			ThePlayer = GameObject.Find ("2DCharacter");
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void SpawnPointAssignement()
	{

	}

	public void PlayerDeath()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		ThePlayer = GameObject.Find ("2DCharacter");
		if(CheckPointState==0)
		ThePlayer.transform.position = SpawnPointOne.position;
		if(CheckPointState==1)
			ThePlayer.transform.position = SpawnPointTwo.position;	
		if(CheckPointState==2)
		ThePlayer.transform.position = SpawnPointThree.position;
		if(CheckPointState==3)
		ThePlayer.transform.position = SpawnPointFour.position;


	}



}
