using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeLevel : MonoBehaviour {
	//public GameObject GameManager;
	public GameObject ThePlayer;
	public Transform[] SpawnPoint;
	public GameObject[] EnnemyPack;
	public GameObject Cam;
	public GameObject PlayerLight;
	//public GameObject[] LightCam;
	public GameObject[] DOors;
	public GameObject[] ColDOors;
	public GameObject[] DecountEnnemy;
	GameObject raycar;

	void Awake()
	{
		Time.timeScale = 1;
		ThePlayer = (GameObject)Resources.Load ("2DCharacter",typeof (GameObject));

	if (PlayerPrefs.GetInt ("SaveSystem")==0)
			Instantiate (ThePlayer, SpawnPoint [0].position, SpawnPoint [0].rotation);
	if (PlayerPrefs.GetInt ("SaveSystem")==1)
			Instantiate (ThePlayer, SpawnPoint [1].position, SpawnPoint [1].rotation);
	if (PlayerPrefs.GetInt ("SaveSystem")==2)
			Instantiate (ThePlayer, SpawnPoint [2].position, SpawnPoint [2].rotation);
	if (PlayerPrefs.GetInt ("SaveSystem")==3)
			Instantiate (ThePlayer, SpawnPoint [3].position, SpawnPoint [3].rotation);
	if (PlayerPrefs.GetInt ("SaveSystem")==4)
			Instantiate (ThePlayer, SpawnPoint [4].position, SpawnPoint [4].rotation);
	if (PlayerPrefs.GetInt ("SaveSystem")==5)
			Instantiate (ThePlayer, SpawnPoint [5].position, SpawnPoint [5].rotation);
	if (PlayerPrefs.GetInt ("SaveSystem")==6)
			Instantiate (ThePlayer, SpawnPoint [6].position, SpawnPoint [6].rotation);
	}
	// Use this for initialization
	void Start () {
		raycar = GameObject.Find ("raycar");
	//	Cam=GameObject.Find("CamBaseTwo");
//		raycar = (GameObject)Resources.Load ("2DCharacter",typeof (GameObject));
		//GameManager = GameObject.Find ("CheckPointManager");
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 0)
//			Instantiate (raycar, SpawnPoint [0].position, SpawnPoint [0].rotation);
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 1)
//			Instantiate (raycar, SpawnPoint [1].position, SpawnPoint [1].rotation);
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 2)
//			Instantiate (raycar, SpawnPoint [2].position, SpawnPoint [2].rotation);
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 3)
//			Instantiate (raycar, SpawnPoint [3].position, SpawnPoint [3].rotation);
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 4)
//			Instantiate (raycar, SpawnPoint [4].position, SpawnPoint [4].rotation);
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 5)
//			Instantiate (raycar, SpawnPoint [5].position, SpawnPoint [5].rotation);
//		if (GameManager.GetComponent<CheckPointState> ().CheckpointState == 6)
//			Instantiate (raycar, SpawnPoint [6].position, SpawnPoint [6].rotation);
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
			
		EnnemyPack [0].SetActive (false);
		EnnemyPack [1].SetActive (false);
		EnnemyPack [2].SetActive (false);
		EnnemyPack [3].SetActive (false);


		Cam.SetActive (true);
		PlayerLight.SetActive (true);
		if (PlayerPrefs.GetInt ("SaveSystem")==0)
				{
					EnnemyPack [0].SetActive (true);
			if (DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [0] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [0] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [0] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [0];

			if (DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [1] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [1] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [1] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [1];

			if (DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [2] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [2] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [2] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [2];

			if (DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [3] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [3] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [3] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [3];

			if (DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [4] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [4] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [4] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [4];

			if (DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [5] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [5] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [5] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [5];

			if (DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [6] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [6] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [6] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [6];

			if (DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [7] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [7] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [7] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [7];

				}	
		if (PlayerPrefs.GetInt ("SaveSystem")==1)
				{
					EnnemyPack [1].SetActive (true);
			DOors [0].GetComponent<Animator> ().SetBool ("Play", true);
			ColDOors [0].SetActive (true);

			if (DecountEnnemy [1].GetComponent<EnnemyDecount> ().Decount [0] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [0] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [0] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [0];

			if (DecountEnnemy [1].GetComponent<EnnemyDecount> ().Decount [1] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [1] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [1] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [1];

			if (DecountEnnemy [1].GetComponent<EnnemyDecount> ().Decount [2] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [2] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [2] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [2];

			if (DecountEnnemy [1].GetComponent<EnnemyDecount> ().Decount [3] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [3] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [3] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [3];

			if (DecountEnnemy [1].GetComponent<EnnemyDecount> ().Decount [4] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [4] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [4] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [4];

			if (DecountEnnemy [1].GetComponent<EnnemyDecount> ().Decount [5] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [5] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [5] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [5];

			if (DecountEnnemy [1].GetComponent<EnnemyDecount> ().Decount [6] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [6] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [6] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [6];

			if (DecountEnnemy [1].GetComponent<EnnemyDecount> ().Decount [7] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [7] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [7] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [7];


				}
		if (PlayerPrefs.GetInt ("SaveSystem")==2)
				{
			DOors [1].GetComponent<Animator> ().SetBool ("Play", true);
			ColDOors [1].SetActive (true);

					EnnemyPack [2].SetActive (true);

			if (DecountEnnemy [2].GetComponent<EnnemyDecount> ().Decount [0] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [0] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [0] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [0];

			if (DecountEnnemy [2].GetComponent<EnnemyDecount> ().Decount [1] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [1] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [1] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [1];

			if (DecountEnnemy [2].GetComponent<EnnemyDecount> ().Decount [2] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [2] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [2] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [2];

			if (DecountEnnemy [2].GetComponent<EnnemyDecount> ().Decount [3] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [3] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [3] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [3];

			if (DecountEnnemy [2].GetComponent<EnnemyDecount> ().Decount [4] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [4] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [4] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [4];

			if (DecountEnnemy [2].GetComponent<EnnemyDecount> ().Decount [5] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [5] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [5] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [5];

			if (DecountEnnemy [2].GetComponent<EnnemyDecount> ().Decount [6] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [6] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [6] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [6];

			if (DecountEnnemy [2].GetComponent<EnnemyDecount> ().Decount [7] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [7] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [7] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [7];

				}

		if (PlayerPrefs.GetInt ("SaveSystem")==2)
		{
			DOors [2].GetComponent<Animator> ().SetBool ("Play", true);
			ColDOors [2].SetActive (true);

			EnnemyPack [3].SetActive (true);

			if (DecountEnnemy [3].GetComponent<EnnemyDecount> ().Decount [0] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [0] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [0] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [0];

			if (DecountEnnemy [3].GetComponent<EnnemyDecount> ().Decount [1] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [1] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [1] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [1];

			if (DecountEnnemy [3].GetComponent<EnnemyDecount> ().Decount [2] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [2] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [2] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [2];

			if (DecountEnnemy [3].GetComponent<EnnemyDecount> ().Decount [3] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [3] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [3] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [3];

			if (DecountEnnemy [3].GetComponent<EnnemyDecount> ().Decount [4] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [4] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [4] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [4];

			if (DecountEnnemy [3].GetComponent<EnnemyDecount> ().Decount [5] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [5] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [5] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [5];

			if (DecountEnnemy [3].GetComponent<EnnemyDecount> ().Decount [6] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [6] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [6] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [6];

			if (DecountEnnemy [3].GetComponent<EnnemyDecount> ().Decount [7] == null)
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [7] = null;
			else
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [7] = DecountEnnemy [0].GetComponent<EnnemyDecount> ().Decount [7];

		}

	
	


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
