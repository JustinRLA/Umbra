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
	public GameObject FirstSection;
	public GameObject SecondSection;
	public GameObject ThirdSection;
	public GameObject[] BackGround;


	int decoountNumber;
	GameObject raycar;

	void Awake()
	{
		
		decoountNumber = PlayerPrefs.GetInt ("SaveSystem");

		Time.timeScale = 1;
		ThePlayer = (GameObject)Resources.Load ("2DCharacter",typeof (GameObject));

			Instantiate (ThePlayer, SpawnPoint [decoountNumber].position, SpawnPoint [decoountNumber].rotation);
	}
	// Use this for initialization
	void Start () {
		if (decoountNumber > 0 && decoountNumber < 10) {
			BackGround [0].SetActive (false);
			BackGround [1].SetActive (false);
			BackGround [2].SetActive (false);
			BackGround [3].SetActive (false);
			BackGround [4].SetActive (false);
			BackGround [5].SetActive (false);
			BackGround [6].SetActive (false);
			BackGround [7].SetActive (false);
			BackGround [8].SetActive (false);
			BackGround [9].SetActive (false);
			BackGround [10].SetActive (false);

			BackGround [decoountNumber].SetActive (true);
			BackGround [decoountNumber+1].SetActive (true);
			BackGround [decoountNumber-1].SetActive (true);

		}
		if (decoountNumber==0) {
			BackGround [0].SetActive (false);
			BackGround [1].SetActive (false);
			BackGround [2].SetActive (false);
			BackGround [3].SetActive (false);
			BackGround [4].SetActive (false);
			BackGround [5].SetActive (false);
			BackGround [6].SetActive (false);
			BackGround [7].SetActive (false);
			BackGround [8].SetActive (false);
			BackGround [9].SetActive (false);
			BackGround [10].SetActive (false);

			BackGround [decoountNumber].SetActive (true);
			BackGround [decoountNumber+1].SetActive (true);

		}
		if (decoountNumber==10) {
			BackGround [0].SetActive (false);
			BackGround [1].SetActive (false);
			BackGround [2].SetActive (false);
			BackGround [3].SetActive (false);
			BackGround [4].SetActive (false);
			BackGround [5].SetActive (false);
			BackGround [6].SetActive (false);
			BackGround [7].SetActive (false);
			BackGround [8].SetActive (false);
			BackGround [9].SetActive (false);
			BackGround [10].SetActive (false);

			BackGround [decoountNumber].SetActive (true);
			BackGround [decoountNumber-1].SetActive (true);

		}
		if(decoountNumber<6)
		{
			SecondSection.SetActive (false);
			ThirdSection.SetActive (false);
			FirstSection.SetActive (true);

			}
		if(decoountNumber>=6 && decoountNumber<9)
		{
			FirstSection.SetActive (false);
			ThirdSection.SetActive (false);
			SecondSection.SetActive (true);

		}

		if(decoountNumber>=9)
		{
			FirstSection.SetActive (false);
			SecondSection.SetActive(false);
			ThirdSection.SetActive(true);

		}


		raycar = GameObject.Find ("raycar");
			
		//EnnemyPack[].SetActive (false);
		EnnemyPack [0].SetActive (false);

		EnnemyPack [1].SetActive (false);
		EnnemyPack [2].SetActive (false);
		EnnemyPack [3].SetActive (false);
		EnnemyPack [4].SetActive (false);
		EnnemyPack [5].SetActive (false);

		EnnemyPack [6].SetActive (false);

		EnnemyPack [7].SetActive (false);
		EnnemyPack [8].SetActive (false);
		EnnemyPack [9].SetActive (false);
		EnnemyPack [10].SetActive (false);
		Cam.SetActive (true);
		PlayerLight.SetActive (true);
		EnnemyPack [decoountNumber]. SetActive(true);


			if (DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [0] != null) {
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [0] = DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [0];
				raycar.GetComponent<CheckVisinCone> ().PatrolOne=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [0].GetComponent<EnnnemyPatrolUpgraded>();
				raycar.GetComponent<CheckVisinCone> ().ConvisibleOne=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [0].GetComponent<ConVisible>();
				raycar.GetComponent<CheckVisinCone> ().MarkOne=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [0].GetComponent<EnnemyMarked>();

			}
			else
				raycar.GetComponent<CheckVisinCone>().EnnemyInScene [0] = null;

			if (DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [1] != null) {
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [1] = DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [1];
				raycar.GetComponent<CheckVisinCone> ().PatrolTwo=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [1].GetComponent<EnnnemyPatrolUpgraded>();
				raycar.GetComponent<CheckVisinCone> ().ConvisibleTwo=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [1].GetComponent<ConVisible>();
				raycar.GetComponent<CheckVisinCone> ().MarkTwo=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [1].GetComponent<EnnemyMarked>();

			}
			else
				raycar.GetComponent<CheckVisinCone>().EnnemyInScene [1] = null;


			if (DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [2] != null) {
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [2] = DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [2];
				raycar.GetComponent<CheckVisinCone> ().Patrolthree=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [2].GetComponent<EnnnemyPatrolUpgraded>();
				raycar.GetComponent<CheckVisinCone> ().ConvisibleThree=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [2].GetComponent<ConVisible>();
				raycar.GetComponent<CheckVisinCone> ().MarkThree=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [2].GetComponent<EnnemyMarked>();

			}
			else
				raycar.GetComponent<CheckVisinCone>().EnnemyInScene [2] = null;


			if (DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [3] != null) {
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [3] = DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [3];
				raycar.GetComponent<CheckVisinCone> ().PatrolFour=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [3].GetComponent<EnnnemyPatrolUpgraded>();
				raycar.GetComponent<CheckVisinCone> ().ConvisibleFour=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [3].GetComponent<ConVisible>();
				raycar.GetComponent<CheckVisinCone> ().MarkFour=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [3].GetComponent<EnnemyMarked>();

			}
			else
				raycar.GetComponent<CheckVisinCone>().EnnemyInScene [3] = null;


			if (DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [4] != null) {
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [4] = DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [4];
				raycar.GetComponent<CheckVisinCone> ().PatrolFive=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [4].GetComponent<EnnnemyPatrolUpgraded>();
				raycar.GetComponent<CheckVisinCone> ().ConvisibleFive=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [4].GetComponent<ConVisible>();
				raycar.GetComponent<CheckVisinCone> ().MarkFive=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [4].GetComponent<EnnemyMarked>();

			}
			else
				raycar.GetComponent<CheckVisinCone>().EnnemyInScene [4] = null;


			if (DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [5] != null) {
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [5] = DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [5];
				raycar.GetComponent<CheckVisinCone> ().PatrolSix=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [5].GetComponent<EnnnemyPatrolUpgraded>();
				raycar.GetComponent<CheckVisinCone> ().ConvisibleSix=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [5].GetComponent<ConVisible>();
				raycar.GetComponent<CheckVisinCone> ().MarkSix=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [5].GetComponent<EnnemyMarked>();

			}
			else
				raycar.GetComponent<CheckVisinCone>().EnnemyInScene [5] = null;


			if (DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [6] != null) {
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [6] = DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [6];
				raycar.GetComponent<CheckVisinCone> ().PatrolSeven=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [6].GetComponent<EnnnemyPatrolUpgraded>();
				raycar.GetComponent<CheckVisinCone> ().ConvisibleSeven=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [6].GetComponent<ConVisible>();
				raycar.GetComponent<CheckVisinCone> ().MarkSeven=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [6].GetComponent<EnnemyMarked>();

			}
			else
				raycar.GetComponent<CheckVisinCone>().EnnemyInScene [6] = null;


			if (DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [7] != null) {
				raycar.GetComponent<CheckVisinCone> ().EnnemyInScene [7] = DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [7];
				raycar.GetComponent<CheckVisinCone> ().PatrolEight=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [7].GetComponent<EnnnemyPatrolUpgraded>();
				raycar.GetComponent<CheckVisinCone> ().ConvisibleEight=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [7].GetComponent<ConVisible>();
				raycar.GetComponent<CheckVisinCone> ().MarkEight=DecountEnnemy [decoountNumber].GetComponent<EnnemyDecount> ().Decount [7].GetComponent<EnnemyMarked>();

			}
			else
				raycar.GetComponent<CheckVisinCone>().EnnemyInScene [7] = null;

			

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
