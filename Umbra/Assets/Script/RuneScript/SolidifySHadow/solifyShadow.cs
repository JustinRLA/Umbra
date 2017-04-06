using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
	public GameObject GrimpSurface;
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

		foreach (GameObject Ombre in AllShadow)
		{
			Ombre.layer = 10;
		}
		mymyRuneManagerScript.RuneActivated = false;
	}


	IEnumerator SolidicationEvent()
	{
		AkSoundEngine.PostEvent("Rune_Solide_Use",gameObject);
		myMainCam = GameObject.Find ("Main Camera");

		mymyRuneManagerScript.timerTactic = 0;
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
		GrimpSurface.SetActive (true);
		GrimpSurface.GetComponent<Collider2D> ().enabled = true;

		AllShadow = GameObject.FindGameObjectsWithTag ("Ombre");

		foreach (GameObject Ombre in AllShadow)
		{
			Ombre.layer = 10;
		}
		gameObject.layer = 24;
		mymyRuneManagerScript.RuneActivated = false;

		yield return new WaitForSeconds(10f);
		AkSoundEngine.PostEvent("Rune_Solide_End",gameObject);

		GrimpSurface.GetComponent<Collider2D> ().enabled = false;
		if (GrimpSurface.GetComponent<maxHauteurLadder> ().TouchShadow == true)
			PlayerMy.GetComponent<PlatformerCharacter2D> ().ClimbTrue = false;
		GrimpSurface.SetActive (false);

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
