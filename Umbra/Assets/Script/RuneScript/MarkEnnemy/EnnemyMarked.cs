using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
	GameObject FullMark;
	GameObject MarkParticle;
	GameObject MarkParticleObj;


	public Texture2D cursor;

	// Use this for initialization
	void Awake()
	{

	}
	void Start () {
		MarkParticle = (GameObject)Resources.Load ("MarkParticle",typeof (GameObject));
		MarkParticleObj=Instantiate (MarkParticle) as GameObject;
		MarkParticleObj.transform.parent = ennemyBase.transform;
		MarkParticleObj.transform.position = new Vector3 (ennemyBase.transform.position.x, ennemyBase.transform.position.y + 1.8f, ennemyBase.transform.position.z);
		MarkParticleObj.SetActive (false);
		cursor = (Texture2D)Resources.Load ("DaggerIconRedFull");

		PlayerMy = GameObject.Find("2DCharacter(Clone)");
		RuneManager = GameObject.Find ("RuneManager");
		myMarkEnmnemyRune = RuneManager.GetComponent<MarkEnnemy> ();
		myRuneManager = RuneManager.GetComponent<RuneManagerScript> ();
		myMainCam=GameObject.Find("Main Camera");
		myCam=GameObject.Find("Main Camera (1)");


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
		Cursor.SetCursor (cursor, Vector2.zero, CursorMode.Auto);

		print ("Enter");
		if (myMarkEnmnemyRune.CanBeClicked == true)
			ennemyBase.GetComponent<SpriteRenderer> ().color = new Color (colorRedOver, colorGreenOver, colorBlueOver,1);
	}

	void OnMouseExit()
	{
		Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
		ennemyBase.GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1);

	}

	void OnMouseDown()
	{
		if (myMarkEnmnemyRune.CanBeClicked == true)
		{
			FullMark = GameObject.Find ("MaquageRuneImageFull");
			FullMark.GetComponent<Image> ().enabled = false;

			AkSoundEngine.PostEvent ("PC_Rune_Marquage_Use", gameObject);
			myRuneManager.RuneActivated = false;
			StartCoroutine (MarkEvent());
		myRuneManager.RuneModeEnabled = false;
			myRuneManager.timerOffense = 0;
			myRuneManager.OffTimer.SetActive (true);
			PlayerMy.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
			PlayerMy.GetComponent<PlatformerCharacter2D> ().enabled = true;
			PlayerMy.GetComponent<Platformer2DUserControl> ().enabled = true;
			myRuneManager.RuneActivated = false;

			Time.timeScale = 1f;
			AkSoundEngine.PostEvent ("PC_Action_slowMo_End", gameObject);

			myMarkEnmnemyRune.CanBeClicked = false;
			myMarkEnmnemyRune.enabled = false;


		}


	}
	void CancelEvent()
	{
		Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
		FullMark = GameObject.Find ("MaquageRuneImageFull");
		FullMark.GetComponent<Image> ().enabled = false;

		myRuneManager.GetComponent<RuneManagerScript> ().RuneActivated = false;
		myRuneManager.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1);
		myMainCam.GetComponent<BloomOptimized> ().enabled = false;
		myCam.GetComponent<ColorCorrectionCurves> ().enabled = false;
		myRuneManager.RuneActivated = false;

		Cursor.visible = false;
		PlayerMy.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		PlayerMy.GetComponent<PlatformerCharacter2D> ().enabled = true;
		PlayerMy.GetComponent<Platformer2DUserControl> ().enabled = true;

		Time.timeScale = 1f;
		AkSoundEngine.PostEvent ("PC_Action_slowMo_End", gameObject);

		myMarkEnmnemyRune.CanBeClicked = false;
		myMarkEnmnemyRune.enabled = false;

	}


	IEnumerator MarkEvent()
	{
		{
			MarkParticleObj.SetActive (true);
			Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
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
			MarkParticleObj.SetActive (false);

			ennemyBase.GetComponent<EnnnemyPatrolUpgraded> ().timerAttack = 0f;

		isMarked = false;

		gameObject.layer = 11;
		VireLight.SetActive (false);
	}
}
}