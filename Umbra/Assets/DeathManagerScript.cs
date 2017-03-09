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
	public int timeScene=0;
	public int CheckPointState;



	// Use this for initialization
	void Start () {
		Scene CurrentScene = SceneManager.GetActiveScene();
		string scenename = CurrentScene.name;
//		if (scenename == "Niveau_1" || scenename == "Niveau_1_test")
//			timeScene++;
		
			DontDestroyOnLoad (gameObject);
		ThePlayer = (GameObject)Resources.Load ("2DCharacter",typeof (GameObject));
		//ThePlayer = Instantiate(Resources.Load("2DCharacter",typeof (GameObject))) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void SpawnPointAssignement()
	{

	}
	public void FirstTime()
	{
		print ("First!!");

		ThePlayer = (GameObject)Resources.Load ("2DCharacter",typeof (GameObject));
//		if (CheckPointState == 0)

			Instantiate (ThePlayer, SpawnPointOne.position, SpawnPointOne.rotation);

	}

	public void PlayerDeath()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		ThePlayer = (GameObject)Resources.Load ("2DCharacter",typeof (GameObject));

		if (CheckPointState == 0)
			Instantiate (ThePlayer, SpawnPointOne.position, SpawnPointOne.rotation);
		if(CheckPointState==2)
		{
			Instantiate (ThePlayer, SpawnPointTwo.position, SpawnPointTwo.rotation);
			print ("WorkBithces"+CheckPointState);
		}
		if(CheckPointState==3)
			Instantiate (ThePlayer, SpawnPointThree.position, SpawnPointThree.rotation);
		if(CheckPointState==4)
			Instantiate (ThePlayer, SpawnPointFour.position, SpawnPointFour.rotation);
	//	StartCoroutine(Timer());

	}

	IEnumerator Timer()
	{
		yield return new WaitForSeconds (0.1f);

		if (CheckPointState == 0)
			Instantiate (ThePlayer, SpawnPointOne.position, SpawnPointOne.rotation);
		if(CheckPointState==2)
		{
			Instantiate (ThePlayer, SpawnPointTwo.position, SpawnPointTwo.rotation);
			print ("WorkBithces"+CheckPointState);
		}
		if(CheckPointState==3)
			Instantiate (ThePlayer, SpawnPointThree.position, SpawnPointThree.rotation);
		if(CheckPointState==4)
			Instantiate (ThePlayer, SpawnPointFour.position, SpawnPointFour.rotation);


	}

}
