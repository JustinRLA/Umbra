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
	public GameObject Runemanager;
	public GameObject[] TourelleLumiere;
	public GameObject[] GrilleJuda;
	public GameObject[]Piece;
	public GameObject[]TrapFeedback;
	public GameObject[]GrapRegion;
	public GameObject[] interzone;






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
		interzone [0].SetActive (false);
		interzone [1].SetActive (false);
		if(decoountNumber<6)
			AkSoundEngine.PostEvent ("Mus_Secteur1", gameObject);
		if(decoountNumber>8)
			AkSoundEngine.PostEvent ("Mus_Secteur3", gameObject);
		if(decoountNumber>=6 && decoountNumber<=8)
			AkSoundEngine.PostEvent ("Mus_Secteur2", gameObject);
		
		
		if (decoountNumber >= 7)
			interzone [1].SetActive(true);

		if (decoountNumber < 7)
			interzone [0].SetActive (true);


		if (decoountNumber > 0 && decoountNumber < 10) {
			Piece [0].SetActive (false);
			Piece [1].SetActive (false);
			Piece [2].SetActive (false);
			Piece [3].SetActive (false);
			Piece [4].SetActive (false);
			Piece [5].SetActive (false);
			Piece [6].SetActive (false);
			Piece [7].SetActive (false);
			Piece [8].SetActive (false);
			Piece [9].SetActive (false);
			Piece [10].SetActive (false);

			Piece [decoountNumber].SetActive (true);
			Piece [decoountNumber+1].SetActive (true);
			Piece [decoountNumber-1].SetActive (true);

		}
		if (decoountNumber==0) {
			Piece [0].SetActive (false);
			Piece [1].SetActive (false);
			Piece [2].SetActive (false);
			Piece [3].SetActive (false);
			Piece [4].SetActive (false);
			Piece [5].SetActive (false);
			Piece [6].SetActive (false);
			Piece [7].SetActive (false);
			Piece [8].SetActive (false);
			Piece [9].SetActive (false);
			Piece [10].SetActive (false);

			Piece [decoountNumber].SetActive (true);
			Piece [decoountNumber+1].SetActive (true);

		}


		if (decoountNumber==10) {
			Piece [0].SetActive (false);
			Piece [1].SetActive (false);
			Piece [2].SetActive (false);
			Piece [3].SetActive (false);
			Piece [4].SetActive (false);
			Piece [5].SetActive (false);
			Piece [6].SetActive (false);
			Piece [7].SetActive (false);
			Piece [8].SetActive (false);
			Piece [9].SetActive (false);
			Piece [10].SetActive (false);

			Piece [decoountNumber].SetActive (true);
			Piece [decoountNumber-1].SetActive (true);

		}

		Runemanager = GameObject.Find ("RuneManager");
		if (PlayerPrefs.GetInt ("RuneTactic") == 1)
			Runemanager.GetComponent<RuneManagerScript> ().TacticRune = 1;
		
		if (PlayerPrefs.GetInt ("RuneTactic") == 2)
			Runemanager.GetComponent<RuneManagerScript> ().TacticRune = 2;
		if (PlayerPrefs.GetInt ("RuneTactic") == 0)
			Runemanager.GetComponent<RuneManagerScript> ().TacticRune = 0;
		if (PlayerPrefs.GetInt ("RuneDefense") == 1)
			Runemanager.GetComponent<RuneManagerScript> ().DefFune = 1;

		if (PlayerPrefs.GetInt ("RuneDefense") == 2)
			Runemanager.GetComponent<RuneManagerScript> ().DefFune = 2;
		if (PlayerPrefs.GetInt ("RuneDefense") == 0)
			Runemanager.GetComponent<RuneManagerScript> ().DefFune = 0;
		if (PlayerPrefs.GetInt ("RuneOffense") == 1)
			Runemanager.GetComponent<RuneManagerScript> ().OffenseRune = 1;

		if (PlayerPrefs.GetInt ("RuneOffense") == 2)
			Runemanager.GetComponent<RuneManagerScript> ().OffenseRune = 2;
		if (PlayerPrefs.GetInt ("RuneOffense") == 0)
			Runemanager.GetComponent<RuneManagerScript> ().OffenseRune = 0;
		

		Runemanager.GetComponent<RuneManagerScript> ().RuneSetting();
		if (GrilleJuda [0] != null)
			GrilleJuda [0].SetActive (false);
		if (GrilleJuda [1] != null)
			GrilleJuda [1].SetActive (false);
		if (GrilleJuda [2] != null)
			GrilleJuda [2].SetActive (false);
		if (GrilleJuda [3] != null)
			GrilleJuda [3].SetActive (false);
		if (GrilleJuda [4] != null)
			GrilleJuda [4].SetActive (false);
		if (GrilleJuda [5] != null)
			GrilleJuda [5].SetActive (false);
		if (GrilleJuda [6] != null)
			GrilleJuda [6].SetActive (false);
		if (GrilleJuda [7] != null)
			GrilleJuda [7].SetActive (false);
		if (GrilleJuda [8] != null)
			GrilleJuda [8].SetActive (false);
		if (GrilleJuda [9] != null)
			GrilleJuda [9].SetActive (false);
		if (GrilleJuda [10] != null)
			GrilleJuda [10].SetActive (false);
	
		if (GrilleJuda [decoountNumber] != null)
			GrilleJuda [decoountNumber].SetActive (true);

		if (TourelleLumiere [0] != null)
			TourelleLumiere [0].SetActive (false);
		if (TourelleLumiere [1] != null)
			TourelleLumiere [1].SetActive (false);
		if (TourelleLumiere [2] != null)
			TourelleLumiere [2].SetActive (false);
		if (TourelleLumiere [3] != null)
			TourelleLumiere [3].SetActive (false);
		if (TourelleLumiere [4] != null)
			TourelleLumiere [4].SetActive (false);
		if (TourelleLumiere [5] != null)
			TourelleLumiere [5].SetActive (false);
		if (TourelleLumiere [6] != null)
			TourelleLumiere [6].SetActive (false);
		if (TourelleLumiere [7] != null)
			TourelleLumiere [7].SetActive (false);
		if (TourelleLumiere [8] != null)
			TourelleLumiere [8].SetActive (false);
		if (TourelleLumiere [9] != null)
			TourelleLumiere [9].SetActive (false);
		if (TourelleLumiere [10] != null)
			TourelleLumiere [10].SetActive (false);

		if (TourelleLumiere [decoountNumber] != null)
			TourelleLumiere [decoountNumber].SetActive (true);

		if (GrapRegion [0] != null)
			GrapRegion [0].SetActive (false);
		if (GrapRegion [1] != null)
			GrapRegion [1].SetActive (false);
		if (GrapRegion [2] != null)
			GrapRegion [2].SetActive (false);
		if (GrapRegion [3] != null)
			GrapRegion [3].SetActive (false);
		if (GrapRegion [4] != null)
			GrapRegion [4].SetActive (false);
		if (GrapRegion [5] != null)
			GrapRegion [5].SetActive (false);
		if (GrapRegion [6] != null)
			GrapRegion [6].SetActive (false);
		if (GrapRegion [7] != null)
			GrapRegion [7].SetActive (false);
		if (GrapRegion [8] != null)
			GrapRegion [8].SetActive (false);
		if (GrapRegion [9] != null)
			GrapRegion [9].SetActive (false);
		if (GrapRegion [10] != null)
			GrapRegion [10].SetActive (false);

		if (GrapRegion [decoountNumber] != null)
			GrapRegion [decoountNumber].SetActive (true);

		if (TrapFeedback [0] != null)
			TrapFeedback [0].SetActive (false);
		if (TrapFeedback [1] != null)
			TrapFeedback [1].SetActive (false);
		if (TrapFeedback [2] != null)
			TrapFeedback [2].SetActive (false);
		if (TrapFeedback [3] != null)
			TrapFeedback [3].SetActive (false);
		if (TrapFeedback [4] != null)
			TrapFeedback [4].SetActive (false);
		if (TrapFeedback [5] != null)
			TrapFeedback [5].SetActive (false);
		if (TrapFeedback [6] != null)
			TrapFeedback [6].SetActive (false);
		if (TrapFeedback [7] != null)
			TrapFeedback [7].SetActive (false);
		if (TrapFeedback [8] != null)
			TrapFeedback [8].SetActive (false);
		if (TrapFeedback [9] != null)
			TrapFeedback [9].SetActive (false);
		if (TrapFeedback [10] != null)
			TrapFeedback [10].SetActive (false);

		if (TrapFeedback [decoountNumber] != null)
			TrapFeedback [decoountNumber].SetActive (true);
		

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



			

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
