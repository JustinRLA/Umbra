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

	// Use this for initialization
	void Start () {
		PlayerMy = GameObject.Find ("2DCharacter");
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
		if (MySolid.CanClickable == true)
		{
			StartCoroutine (SolidicationEvent ());
			MySolid.CanClickable = false;

		}
	}

	void OnMouseOver()
	{
//		print ("Enter");
		if (MySolid.CanClickable == true)
			GetComponent<SpriteRenderer> ().color = new Color (colorRedOver, colorGreenOver, colorBlueOver,1);
	}

	void CancelAction()
	{
		myMainCam.GetComponent<BloomOptimized> ().enabled = false;
		Cursor.visible = false;
		RuneManager.GetComponent<RuneManagerScript> ().RuneActivated = false;
		RuneManager.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
		PlayerMy.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		PlayerMy.GetComponent<PlatformerCharacter2D> ().enabled = true;
		PlayerMy.GetComponent<Platformer2DUserControl> ().enabled = true;
		MySolid.CanClickable = false;
	}


	IEnumerator SolidicationEvent()
	{
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

		yield return new WaitForSeconds(10f);
		GetComponent<Collider2D> ().isTrigger = true;
		MySolid.CanClickable = false;

		GetComponent<SpriteRenderer> ().enabled = false;

//		myBlindEnmnemyRune.CanClick = false;
//		MyLight.SetActive(false);
//		Cursor.visible = false;
//		Time.timeScale = 1f;
//		yield return new WaitForSeconds (10f);
//		MyLight.SetActive (true);
	}

}
