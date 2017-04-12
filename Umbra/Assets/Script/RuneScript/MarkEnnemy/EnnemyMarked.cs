using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMarked : MonoBehaviour {
	MarkEnnemy myMarkEnmnemyRune;
	public GameObject RuneManager;
	public GameObject VireLight;
	RuneManagerScript myRuneManager;
	public float colorRedOver;
	public float colorBlueOver;
	public float colorGreenOver;
	public GameObject myCam;
	public GameObject myMainCam;
	public GameObject ennemyBase;
	public GameObject StateObj;
	public bool isMarked;
	public GameObject PlayerMy;
	public float PlayerSpeed;
	public GameObject raycarVision;

	// Use this for initialization
	void Start () {
		PlayerMy = GameObject.Find("2DCharacter(Clone)");
		RuneManager = GameObject.Find ("RuneManager");
		myMarkEnmnemyRune = RuneManager.GetComponent<MarkEnnemy> ();
		myRuneManager = RuneManager.GetComponent<RuneManagerScript> ();
		myMainCam=GameObject.Find("Main Camera");
		myCam=GameObject.Find("Main Camera (1)");
		raycarVision=GameObject.Find("")


	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1) && myMarkEnmnemyRune.CanBeClicked == true)
			CancelEvent ();

		//GetComponent<SpriteRenderer> ().color = new Color (colorRedOver, colorGreenOver, colorBlueOver);

	}

	void OnMouseEnter()
	{
		print ("Enter");
	//	GetComponent<SpriteRenderer> ().color = new Color (colorRedOver, colorGreenOver, colorBlueOver);
	}
	void OnMouseOver()
	{
		print ("Enter");
		if (myMarkEnmnemyRune.CanBeClicked == true)
			ennemyBase.GetComponent<SpriteRenderer> ().color = new Color (colorRedOver, colorGreenOver, colorBlueOver,1);
	}

	void OnMouseExit()
	{
		ennemyBase.GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1);

	}

	void OnMouseDown()
	{
		if (myMarkEnmnemyRune.CanBeClicked == true)
		{
			AkSoundEngine.PostEvent ("PC_Rune_Marquage_Use", gameObject);
			myRuneManager.RuneActivated = false;
			StartCoroutine (MarkEvent());
		myRuneManager.RuneModeEnabled = false;
			myRuneManager.timerOffense = 0;
			PlayerMy.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
			PlayerMy.GetComponent<PlatformerCharacter2D> ().enabled = true;
			PlayerMy.GetComponent<Platformer2DUserControl> ().enabled = true;

			Time.timeScale = 1f;
			AkSoundEngine.PostEvent ("PC_Action_slowMo_End", gameObject);

			myMarkEnmnemyRune.CanBeClicked = false;

		}


	}
	void CancelEvent()
	{
		myRuneManager.GetComponent<RuneManagerScript> ().RuneActivated = false;
		myRuneManager.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1);
		myMainCam.GetComponent<BloomOptimized> ().enabled = false;
		myCam.GetComponent<ColorCorrectionCurves> ().enabled = false;

		Cursor.visible = false;
		PlayerMy.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		PlayerMy.GetComponent<PlatformerCharacter2D> ().enabled = true;
		PlayerMy.GetComponent<Platformer2DUserControl> ().enabled = true;

		Time.timeScale = 1f;
		AkSoundEngine.PostEvent ("PC_Action_slowMo_End", gameObject);

		myMarkEnmnemyRune.CanBeClicked = false;

	}


	IEnumerator MarkEvent()
	{
		{
			ennemyBase.GetComponent<EnnnemyPatrolUpgraded> ().timerAttack = 1.5f;

			myRuneManager.GetComponent<RuneManagerScript> ().RuneActivated = false;
			myRuneManager.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;

		myMainCam.GetComponent<Grayscale> ().enabled = false;
		myMainCam.GetComponent<BloomOptimized> ().enabled = false;
		isMarked = true;
		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1);
		myCam.GetComponent<ColorCorrectionCurves> ().enabled = false;
		myRuneManager.timerOffense = 0;
		VireLight.SetActive (true);
		gameObject.layer = 25;
		myMarkEnmnemyRune.CanBeClicked = false;
		Cursor.visible = false;
		Time.timeScale = 1f;
		yield return new WaitForSeconds (25f);
			ennemyBase.GetComponent<EnnnemyPatrolUpgraded> ().timerAttack = 0f;

		isMarked = false;

		gameObject.layer = 11;
		VireLight.SetActive (false);
	}
}
}