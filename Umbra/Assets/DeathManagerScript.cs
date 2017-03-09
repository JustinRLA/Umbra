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
	}
	


	public void PlayerDeath()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);

	}


}
