using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeLevel : MonoBehaviour {
	public GameObject GameManager;
	public GameObject ThePLayer;
	public Transform[] SpawnPoint;
	public GameObject[] EnnemyPack;
	public GameObject[] LightPack;




	// Use this for initialization
	void Start () {
		ThePLayer = (GameObject)Resources.Load ("2DCharacter",typeof (GameObject));
		GameManager = GameObject.Find ("CheckPointManager");
		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 0)
			Instantiate (ThePLayer, SpawnPoint [0].position, SpawnPoint [0].rotation);
		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 0)
			Instantiate (ThePLayer, SpawnPoint [1].position, SpawnPoint [1].rotation);
		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 0)
			Instantiate (ThePLayer, SpawnPoint [2].position, SpawnPoint [2].rotation);
		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 0)
			Instantiate (ThePLayer, SpawnPoint [3].position, SpawnPoint [3].rotation);
		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 0)
			Instantiate (ThePLayer, SpawnPoint [4].position, SpawnPoint [4].rotation);
		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 0)
			Instantiate (ThePLayer, SpawnPoint [5].position, SpawnPoint [5].rotation);
		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 0)
			Instantiate (ThePLayer, SpawnPoint [6].position, SpawnPoint [6].rotation);

		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 0)
		{
			EnnemyPack [0].SetActive (true);
	}
		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 1)
		{
			EnnemyPack [1].SetActive (true);
		}	
		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 2)
		{
			EnnemyPack [2].SetActive (true);
		}
		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 3)
		{
			EnnemyPack [3].SetActive (true);
		}

		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 0)
		{
			LightPack [0].SetActive (true);
		}
		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 1)
		{
			LightPack [1].SetActive (true);
		}	
		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 2)
		{
			LightPack [2].SetActive (true);
		}
		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 3)
		{
			LightPack [3].SetActive (true);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
