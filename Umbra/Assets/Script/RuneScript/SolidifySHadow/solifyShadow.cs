using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class solifyShadow : MonoBehaviour {
	SolidifcationEnabled MySolid;
	public GameObject RuneManager;
	RuneManagerScript mymyRuneManagerScript;
	public float colorRedOver;
	public float colorGreenOver;
	public float colorBlueOver;
	public GameObject myMainCam;
	public GameObject PlayerMy;
	public float movespeed;
	public GameObject[] AllShadow;
	public GameObject GrimpSurfaceRight;
	public GameObject GrimpSurfaceLeft;
	public Texture2D CursorText;
	public CursorMode cursormode=CursorMode.Auto;
	Vector2 hotspot= Vector2.zero;
	GameObject FullRune;
	bool colPlayer;

	// Use this for initialization
	void Start () {
		PlayerMy = GameObject.Find("2DCharacter(Clone)");
		RuneManager = GameObject.Find ("RuneManager");
		myMainCam = GameObject.Find ("Main Camera");

		mymyRuneManagerScript = RuneManager.GetComponent<RuneManagerScript> ();
		MySolid = RuneManager.GetComponent<SolidifcationEnabled> ();

	}
	
	// Update is called once per frame
	void Update () {
		Cursor.SetCursor (CursorText, hotspot, cursormode);
		if (Input.GetMouseButtonDown(1) && MySolid.CanClickable == true)
		{
			CancelAction ();
		MySolid.CanClickable = false;
		}


	}

	void OnMouseDown()
	{
		if (MySolid.CanClickable == true && PlayerMy.GetComponent<PlatformerCharacter2D> ().inShadow == false) {
			StartCoroutine (SolidicationEvent ());
			MySolid.CanClickable = false;

		} 
		if(MySolid.CanClickable == false)
			CancelAction ();
	
	}

	void OnMouseOver()
	{
//		print ("Enter");
		if (MySolid.CanClickable == true)
			GetComponent<SpriteRenderer> ().color = new Color (colorRedOver, colorGreenOver, colorBlueOver,1);
	}

	void CancelAction()
	{
		FullRune = GameObject.Find ("solideImageFull");
		FullRune.GetComponent<Image> ().enabled = false;
		myMainCam = GameObject.Find ("Main Camera");

		myMainCam.GetComponent<BloomOptimized> ().enabled = false;
		Cursor.visible = false;
		RuneManager.GetComponent<RuneManagerScript> ().RuneActivated = false;
		RuneManager.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
		PlayerMy.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		PlayerMy.GetComponent<PlatformerCharacter2D> ().enabled = true;
		PlayerMy.GetComponent<Platformer2DUserControl> ().enabled = true;
		MySolid.CanClickable = false;
		Time.timeScale = 1;
		AllShadow = GameObject.FindGameObjectsWithTag ("Ombre");
		AkSoundEngine.PostEvent ("PC_Action_slowMo_End", gameObject);

		foreach (GameObject Ombre in AllShadow)
		{
			Ombre.layer = 10;
		}
		mymyRuneManagerScript.RuneActivated = false;
	}


	IEnumerator SolidicationEvent()
	{
		FullRune = GameObject.Find ("solideImageFull");
		FullRune.GetComponent<Image> ().enabled = false;
		AkSoundEngine.PostEvent("PC_Rune_Solide_Use",gameObject);
		myMainCam = GameObject.Find ("Main Camera");

		mymyRuneManagerScript.timerTactic = 0;
		mymyRuneManagerScript.TacticTimer.SetActive (true);
		RuneManager.GetComponent<RuneManagerScript> ().RuneActivated = false;
		RuneManager.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
		myMainCam.GetComponent<BloomOptimized> ().enabled = false;
		GetComponent<SpriteRenderer> ().enabled = true;
		GetComponent<Collider2D> ().isTrigger = false;
		Time.timeScale = 1f;
		Cursor.visible = false;
		PlayerMy.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		PlayerMy.GetComponent<PlatformerCharacter2D> ().enabled = true;
		PlayerMy.GetComponent<Platformer2DUserControl> ().enabled = true;
		gameObject.tag="SolidOmbre";
		gameObject.layer = 10;
		GrimpSurfaceLeft.SetActive (true);
		GrimpSurfaceRight.SetActive (true);

		GrimpSurfaceRight.GetComponent<Collider2D> ().enabled = true;
		GrimpSurfaceLeft.GetComponent<Collider2D> ().enabled = true;

		AllShadow = GameObject.FindGameObjectsWithTag ("Ombre");

		foreach (GameObject Ombre in AllShadow)
		{
			Ombre.layer = 10;
		}
		gameObject.layer = 24;
		mymyRuneManagerScript.RuneActivated = false;
		AkSoundEngine.PostEvent ("PC_Action_slowMo_End", gameObject);

		yield return new WaitForSeconds(10f);
		AkSoundEngine.PostEvent("PC_Rune_Solide_End",gameObject);

		GrimpSurfaceLeft.GetComponent<Collider2D> ().enabled = false;
		GrimpSurfaceRight.GetComponent<Collider2D> ().enabled = false;

		if (GrimpSurfaceLeft.GetComponent<maxHauteurLadder> ().TouchShadow == true || GrimpSurfaceRight.GetComponent<maxHauteurLadder> ().TouchShadow)
			PlayerMy.GetComponent<PlatformerCharacter2D> ().ClimbTrue = false;
		GrimpSurfaceLeft.SetActive (false);
		GrimpSurfaceRight.SetActive (false);

		MySolid.CanClickable = false;
		gameObject.layer = 10;

		GetComponent<SpriteRenderer> ().enabled = false;
		gameObject.tag="Ombre";

//		myBlindEnmnemyRune.CanClick = false;
//		MyLight.SetActive(false);
//		Cursor.visible = false;
//		Time.timeScale = 1f;
//		yield return new WaitForSeconds (10f);
//		MyLight.SetActive (true);
	}



}
