using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableTrapMode : MonoBehaviour {
	Vector3 Mousepos;
	RaycastHit2D myraycast;
	Ray ray;
	public bool CanInstantiate;
	//bool ScriptIsActivaed=false;
	public GameObject Trapping;
	RuneManagerScript myRuneManager;
	public GameObject gameCam;
	public GameObject trapcam;
	public float movespeed;
	public GameObject nowherepointObj;
	public GameObject myPlayer;
	public GameObject ThisTrap;
	public GameObject Demotrap;
	public GameObject[] AllTrap;
	GameObject FullRune;

	bool ThisEvent;
	public Transform NowherePoint;
	public GameObject myTrapZone;
	// Use this for initialization
	void Aweake()
	{
	}
	void Start () {
		myPlayer=GameObject.Find("2DCharacter(Clone)");
		Demotrap = GameObject.Find ("TrapDemo");
		nowherepointObj=GameObject.Find("NowherePoint");
		NowherePoint = nowherepointObj.transform;
		myRuneManager = GetComponent<RuneManagerScript> ();
		//trapcam = GameObject.Find ("Main CameraTrapRegion");
	}

	// Update is called once per frame
	void Update () {
		Mousepos = (Input.mousePosition);
		Mousepos.z = 0;

		//    myraycast = Physics2D.Raycast(Mousepos,Mousepos-Camera.main.ScreenToWorldPoint(Mousepos));
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		myraycast = Physics2D.Raycast(ray.origin, ray.direction,Mathf.Infinity);


		if(Input.GetMouseButton(1))
		{

			Ending ();        }    

		if(myraycast && ThisEvent==true)
		{
			if (myraycast.collider.tag == "TrapPlacement")
			{
				CanInstantiate = true;
				myTrapZone = myraycast.collider.gameObject;
			}
			else
				CanInstantiate = false;

		}

		if( myTrapZone != null)
		{
			if (CanInstantiate == true)
			{
				myTrapZone.GetComponent<ThisisMyFeedBackTrap> ().myFeedback.SetActive (true);
				Demotrap.transform.position = new Vector3 (myraycast.point.x, myTrapZone.transform.position.y, 0);
			}

			if(CanInstantiate==false)
			{
				myTrapZone.GetComponent<ThisisMyFeedBackTrap> ().myFeedback.SetActive (false);
				Demotrap.transform.position = NowherePoint.position;

			}


		}
		if( myTrapZone == null)
		{
			Demotrap.transform.position = NowherePoint.position;

		}



		if(CanInstantiate==true)
		{
			if(Input.GetMouseButton(0)){
				ThisEvent = false;
				FullRune.GetComponent<Image> ().enabled = false;

				Instantiate (Trapping, myraycast.point,transform.rotation);
				AkSoundEngine.PostEvent ("PC_Rune_Trap_Use", gameObject);
				myRuneManager.GetComponent<RuneManagerScript> ().RuneActivated = false;
				myRuneManager.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;

				myPlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
				myPlayer.GetComponent<PlatformerCharacter2D> ().enabled = true;
				myPlayer.GetComponent<Platformer2DUserControl> ().enabled = true;
				if(myTrapZone != null)
				{
					myTrapZone.GetComponent<ThisisMyFeedBackTrap> ().myFeedback.SetActive (false);
					Demotrap.transform.position = NowherePoint.position;
				}
				Demotrap.transform.position = NowherePoint.position;

				foreach (GameObject TrapRegion in AllTrap)
					TrapRegion.GetComponent<Collider2D> ().isTrigger = true;

				Time.timeScale = 1f;
				myRuneManager.timerOffense = 0;
				myRuneManager.OffTimer.SetActive (true);
				gameCam.GetComponent<BloomOptimized> ().enabled = false;

				trapcam.SetActive (false);
				CanInstantiate = false;

				Demotrap.transform.position = NowherePoint.position;
				AkSoundEngine.PostEvent ("PC_Action_slowMo_End", gameObject);

				GetComponent<EnableTrapMode> ().enabled = false;

			}    
		}
	}


	void Ending()
	{
		ThisEvent = false;
		FullRune.GetComponent<Image> ().enabled = false;

		myRuneManager.GetComponent<RuneManagerScript> ().RuneActivated = false;
		myRuneManager.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
		myPlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		myPlayer.GetComponent<PlatformerCharacter2D> ().enabled = true;
		myPlayer.GetComponent<Platformer2DUserControl> ().enabled = true;

		Time.timeScale = 1f;
		gameCam.GetComponent<BloomOptimized> ().enabled = false;
		trapcam.SetActive (false);
		foreach (GameObject TrapRegion in AllTrap)
			TrapRegion.GetComponent<Collider2D> ().isTrigger = true;

		if(myTrapZone != null)
		{
			myTrapZone.GetComponent<ThisisMyFeedBackTrap> ().myFeedback.SetActive (false);
		}
		CanInstantiate = false;
		Demotrap.transform.position = NowherePoint.position;
		AkSoundEngine.PostEvent ("PC_Action_slowMo_End", gameObject);

		GetComponent<EnableTrapMode> ().enabled = false;

	}
	public void EnabledTrapMode()
	{
		FullRune = GameObject.Find ("trapImageFull");
		FullRune.GetComponent<Image> ().enabled = true;
	//	AkSoundEngine.PostEvent ("PC_Rune_Trap_Equip", gameObject);

		Time.timeScale = 0.1f;
		Cursor.visible = true;
		trapcam.SetActive (true);

		AllTrap = GameObject.FindGameObjectsWithTag ("TrapPlacement");
		ThisEvent = true;
		foreach (GameObject TrapPlacement in AllTrap)
			TrapPlacement.GetComponent<Collider2D> ().isTrigger = false;
	}

}

