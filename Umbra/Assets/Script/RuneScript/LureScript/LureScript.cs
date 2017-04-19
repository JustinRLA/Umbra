using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//namespace UnityStandardAssets._2D
//{

public class LureScript : MonoBehaviour {
	
	public GameObject ThePlayer;
	public GameObject ThePlayerShadow;
		public bool EnnemyDistracted;
		public GameObject RuneManager;
	RuneManagerScript myRuneManagerScript;
	public GameObject myCam;
	public bool inLureMode;
	public GameObject raycar;
	public GameObject Lurelight;
	public GameObject CamOne;
	public GameObject CamTwo;
	public GameObject CamThree;
	public GameObject PlayerCam;
	GameObject FullRune;


	public bool Active=false;
	public float timer;
	public GameObject imageTimer;
	public GameObject canvaTimer;

	// Use this for initialization


	void Start () {
		GetComponent<LureScript> ().enabled = false;
		myCam = GameObject.Find ("Main Camera");
		CamOne = GameObject.Find ("Main Camera (1)");
		CamTwo = GameObject.Find ("Main Camera (2)");
		CamThree = GameObject.Find ("Main Camera (3)");

		myRuneManagerScript = GetComponent<RuneManagerScript> ();

	}
	
	// Update is called once per frame


	public void StartLure () {
		AkSoundEngine.PostEvent ("PC_Rune_Leurre_Filter", gameObject);
		raycar = GameObject.Find ("raycar");
		raycar.transform.position = gameObject.transform.position;
		raycar.transform.parent = gameObject.transform;
				Lurelight.SetActive (true);
		FullRune = GameObject.Find ("LeureImageFull");
		myRuneManagerScript = GetComponent<RuneManagerScript> ();
		AkSoundEngine.PostEvent ("PC_Rune_Leurre_Use", gameObject);
		myRuneManagerScript.RuneActivated = true;
		ThePlayer = GameObject.Find("2DCharacter(Clone)");
		PlayerCam.GetComponent<PlayerCamScript> ().activateLeurreCam = true;
		ThePlayerShadow.transform.position = ThePlayer.transform.position;
		ThePlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 0;

		myCam.GetComponent<Animator> ().SetBool ("MegaBlue", false);
		CamOne.GetComponent<Animator> ().SetBool ("MegaBlue", false);
		CamTwo.GetComponent<Animator> ().SetBool ("MegaBlue", false);
		CamThree.GetComponent<Animator> ().SetBool ("MegaBlue", false);
		myCam.GetComponent<NoiseAndScratches> ().enabled = true;
		CamOne.GetComponent<NoiseAndScratches> ().enabled = true;
		CamTwo.GetComponent<NoiseAndScratches> ().enabled = true;
		CamThree.GetComponent<NoiseAndScratches> ().enabled = true;

		//	if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.W)) 
		//myOwnLureCam.SetActive(true);
		canvaTimer.SetActive(true);
		Active=true;
		inLureMode = true;
		//myCamPivot.SetActive (false);
		imageTimer.GetComponent<timerLure>().fraction=7;
			ThePlayerShadow.GetComponent<PlatformerCharacter2D> ().enabled = true;
			ThePlayerShadow.GetComponent<Platformer2DUserControl> ().enabled = true;
		RuneManager.GetComponent<RuneManagerScript> ().timerTactic = 30;
		FullRune.GetComponent<Image> ().enabled = true;

		RuneManager.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;

		ThePlayer.GetComponent<Platformer2DUserControl> ().enabled = false;

			ThePlayer.GetComponent<PlatformerCharacter2D> ().enabled = false;
			ThePlayer.GetComponent<Platformer2DUserControl> ().enabled = false;
			ThePlayerShadow.SetActive (true);
				StartCoroutine (DistractEnnemy ());
	//}
		}

	void Update()
	{
		if(Input.GetMouseButtonDown(1) && inLureMode==true)
		{
			StartCoroutine (DistractEnnemFast());
		}
	}

	IEnumerator DistractEnnemFast()
	{
		raycar.transform.position = new Vector3(ThePlayer.transform.position.x,ThePlayer.transform.position.y+4,ThePlayer.transform.position.z);
		raycar.transform.parent = ThePlayer.transform;

		myRuneManagerScript.RuneActivated = false;
		FullRune.GetComponent<Image> ().enabled = false;

		myCam.GetComponent<Animator> ().SetBool ("MegaBlue", false);
		CamOne.GetComponent<Animator> ().SetBool ("MegaBlue", false);
		CamTwo.GetComponent<Animator> ().SetBool ("MegaBlue", false);
		CamThree.GetComponent<Animator> ().SetBool ("MegaBlue", false);
		myCam.GetComponent<NoiseAndScratches> ().enabled = false;
		CamOne.GetComponent<NoiseAndScratches> ().enabled = false;
		CamTwo.GetComponent<NoiseAndScratches> ().enabled = false;
		CamThree.GetComponent<NoiseAndScratches> ().enabled = false;
	//	myOwnLureCam.SetActive(false);

	//	myCamPivot.SetActive (true);
		inLureMode = false;
		ThePlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		myCam.GetComponent<BloomOptimized> ().enabled = false;
		myRuneManagerScript.RuneActivated = false;

		myRuneManagerScript.timerDef = 0;
		RuneManager.GetComponent<RuneManagerScript>().DefTimer.SetActive (true);

		ThePlayer.GetComponent<BoxCollider2D> ().enabled = true;

		ThePlayer.GetComponent<Collider2D> ().enabled = true;
		ThePlayer.GetComponent<CircleCollider2D> ().enabled = true;
		ThePlayer.GetComponent<Rigidbody2D> ().isKinematic = false;

		Time.timeScale = 1.0f;
		timer = 10;
		PlayerCam.GetComponent<PlayerCamScript> ().activateLeurreCam = false;

		ThePlayer.GetComponent<PlatformerCharacter2D> ().enabled = true;
		ThePlayer.GetComponent<Platformer2DUserControl> ().enabled = true;
		ThePlayerShadow.GetComponent<PlatformerCharacter2D> ().enabled = false;
		ThePlayerShadow.GetComponent<Platformer2DUserControl> ().enabled = false;

		yield return new WaitForSeconds(2f);
		timer = 8;
		yield return new WaitForSeconds(2f);
		timer = 6;
		yield return new WaitForSeconds(2f);
		timer = 4;
		yield return new WaitForSeconds(2f);
		timer = 2;
		yield return new WaitForSeconds(2f);
		Lurelight.SetActive (false);
		//ThePlayerShadow.transform.parent = ThePlayer.transform;
		EnnemyDistracted = false;
		//ThePlayerShadow.transform.position = ThePlayer.transform.position;
		ThePlayerShadow.SetActive (false);
		Active = false;
		canvaTimer.SetActive(false);

		GetComponent<LureScript> ().enabled = false;

	}



		IEnumerator DistractEnnemy()
		{
			EnnemyDistracted = true;
		ThePlayer.GetComponent<BoxCollider2D> ().enabled = false;
		ThePlayer.GetComponent<Rigidbody2D> ().isKinematic = true;
		//timer += Time.deltaTime;
		timer = 10;
		//ThePlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 150;
		ThePlayer.GetComponent<Collider2D> ().enabled = false;
		ThePlayer.GetComponent<CircleCollider2D> ().enabled = false;
		//myRuneManagerScript.RuneModeEnabled = false;
		//ThePlayerShadow.transform.parent = null;
		inLureMode = true;
		Time.timeScale = 1.0f;

			yield return new WaitForSeconds(7f);
		raycar.transform.position = new Vector3(ThePlayer.transform.position.x,ThePlayer.transform.position.y+4,ThePlayer.transform.position.z);
		raycar.transform.parent = ThePlayer.transform;

		FullRune.GetComponent<Image> ().enabled = false;

		myRuneManagerScript.RuneActivated = false;

		PlayerCam.GetComponent<PlayerCamScript> ().activateLeurreCam = false;

		myCam.GetComponent<NoiseAndScratches> ().enabled = false;
		CamOne.GetComponent<NoiseAndScratches> ().enabled = false;
		CamTwo.GetComponent<NoiseAndScratches> ().enabled = false;
		CamThree.GetComponent<NoiseAndScratches> ().enabled = false;
		myCam.GetComponent<Animator> ().SetBool ("MegaBlue", false);
		CamOne.GetComponent<Animator> ().SetBool ("MegaBlue", false);
		CamTwo.GetComponent<Animator> ().SetBool ("MegaBlue", false);
		CamThree.GetComponent<Animator> ().SetBool ("MegaBlue", false);

		//myOwnLureCam.SetActive(false);

		//myCamPivot.SetActive (true);
		inLureMode = false;
		ThePlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		myCam.GetComponent<BloomOptimized> ().enabled = false;
		myRuneManagerScript.RuneActivated = false;

		myRuneManagerScript.timerDef = 0;
		RuneManager.GetComponent<RuneManagerScript>().DefTimer.SetActive (true);
		ThePlayer.GetComponent<BoxCollider2D> ().enabled = true;

		ThePlayer.GetComponent<Collider2D> ().enabled = true;
		ThePlayer.GetComponent<CircleCollider2D> ().enabled = true;
		ThePlayer.GetComponent<Rigidbody2D> ().isKinematic = false;

			Time.timeScale = 1.0f;
		timer = 10;
		ThePlayerShadow.GetComponent<PlatformerCharacter2D> ().enabled = false;
		ThePlayerShadow.GetComponent<Platformer2DUserControl> ().enabled = false;
		yield return new WaitForSeconds (1f);
		ThePlayer.GetComponent<PlatformerCharacter2D> ().enabled = true;
		ThePlayer.GetComponent<Platformer2DUserControl> ().enabled = true;
	
		yield return new WaitForSeconds(2f);
		timer = 2;
		yield return new WaitForSeconds(2f);

			EnnemyDistracted = false;
				Lurelight.SetActive (false);

			ThePlayerShadow.transform.position = ThePlayer.transform.position;
			ThePlayerShadow.SetActive (false);
		Active = false;
		canvaTimer.SetActive(false);

		GetComponent<LureScript> ().enabled = false;
		}

}
//}