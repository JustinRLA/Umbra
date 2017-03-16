using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeLevel : MonoBehaviour {
	//public GameObject GameManager;
	public GameObject ThePLayer;
	public Transform[] SpawnPoint;
	public GameObject[] EnnemyPack;
	public GameObject Cam;
	public GameObject PlayerLight;
	//public GameObject[] LightCam;
	public GameObject[] DOors;
	public GameObject[] ColDOors;



	void Awake()
	{
		ThePLayer = (GameObject)Resources.Load ("2DCharacter",typeof (GameObject));

	if (PlayerPrefs.GetInt ("SaveSystem")==0)
		Instantiate (ThePLayer, SpawnPoint [0].position, SpawnPoint [0].rotation);
	if (PlayerPrefs.GetInt ("SaveSystem")==1)
		Instantiate (ThePLayer, SpawnPoint [1].position, SpawnPoint [1].rotation);
	if (PlayerPrefs.GetInt ("SaveSystem")==2)
		Instantiate (ThePLayer, SpawnPoint [2].position, SpawnPoint [2].rotation);
	if (PlayerPrefs.GetInt ("SaveSystem")==3)
		Instantiate (ThePLayer, SpawnPoint [3].position, SpawnPoint [3].rotation);
	if (PlayerPrefs.GetInt ("SaveSystem")==4)
		Instantiate (ThePLayer, SpawnPoint [4].position, SpawnPoint [4].rotation);
	if (PlayerPrefs.GetInt ("SaveSystem")==5)
		Instantiate (ThePLayer, SpawnPoint [5].position, SpawnPoint [5].rotation);
	if (PlayerPrefs.GetInt ("SaveSystem")==6)
		Instantiate (ThePLayer, SpawnPoint [6].position, SpawnPoint [6].rotation);
	}
	// Use this for initialization
	void Start () {
	//	Cam=GameObject.Find("CamBaseTwo");
//		ThePLayer = (GameObject)Resources.Load ("2DCharacter",typeof (GameObject));
		//GameManager = GameObject.Find ("CheckPointManager");
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 0)
//			Instantiate (ThePLayer, SpawnPoint [0].position, SpawnPoint [0].rotation);
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 1)
//			Instantiate (ThePLayer, SpawnPoint [1].position, SpawnPoint [1].rotation);
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 2)
//			Instantiate (ThePLayer, SpawnPoint [2].position, SpawnPoint [2].rotation);
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 3)
//			Instantiate (ThePLayer, SpawnPoint [3].position, SpawnPoint [3].rotation);
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 4)
//			Instantiate (ThePLayer, SpawnPoint [4].position, SpawnPoint [4].rotation);
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 5)
//			Instantiate (ThePLayer, SpawnPoint [5].position, SpawnPoint [5].rotation);
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 6)
//			Instantiate (ThePLayer, SpawnPoint [6].position, SpawnPoint [6].rotation);
//
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 0)
//		{
//			EnnemyPack [0].SetActive (true);
//	}
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 1)
//		{
//			EnnemyPack [1].SetActive (true);
//		}	
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 2)
//		{
//			EnnemyPack [2].SetActive (true);
//		}
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 3)
//		{
//			EnnemyPack [3].SetActive (true);
//		}
	//PlayerPrefs.SetInt ("SaveSystem",0);
			
		Cam.SetActive (true);
		PlayerLight.SetActive (true);
		if (PlayerPrefs.GetInt ("SaveSystem")==0)
				{
					EnnemyPack [0].SetActive (true);
				}	
		if (PlayerPrefs.GetInt ("SaveSystem")==1)
				{
					EnnemyPack [1].SetActive (true);
				}
		if (PlayerPrefs.GetInt ("SaveSystem")==2)
				{
					EnnemyPack [2].SetActive (true);
				}

		if (PlayerPrefs.GetInt ("SaveSystem")==1)
		{
			DOors [0].GetComponent<Animator> ().SetBool ("Play", true);
			ColDOors [0].SetActive (true);

		}	

		if (PlayerPrefs.GetInt ("SaveSystem")==2)
		{
			DOors [1].GetComponent<Animator> ().SetBool ("Play", true);
			ColDOors [1].SetActive (true);

		}

		if (PlayerPrefs.GetInt ("SaveSystem")==3)
		{
			DOors [2].GetComponent<Animator> ().SetBool ("Play", true);
			ColDOors [2].SetActive (true);

		}

//		if (PlayerPrefs.GetInt ("SaveSystem")==0)
//		{
//			LightCam [0].SetActive (true);
//		}	
//		if (PlayerPrefs.GetInt ("SaveSystem")==1)
//		{
//			LightCam [1].SetActive (true);
//		}
//		if (PlayerPrefs.GetInt ("SaveSystem")==2)
//		{
//			LightCam [2].SetActive (true);
//		}
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 0)
//		{
//			EnnemyPack [0].SetActive (true);
//		}
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 1)
//		{
//			EnnemyPack [1].SetActive (true);
//		}	
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 2)
//		{
//			EnnemyPack [2].SetActive (true);
//		}
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 3)
//		{
//			EnnemyPack [3].SetActive (true);
//		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
