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


	// Use this for initialization
	void Start () {
		RuneManager = GameObject.Find ("RuneManager");
		myMainCam = GameObject.Find ("Main Camera");

		mymyRuneManagerScript = RuneManager.GetComponent<RuneManagerScript> ();
		MySolid = RuneManager.GetComponent<SolidifcationEnabled> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1) && MySolid.CanClickable == true)
			CancelAction ();
	}

	void OnMouseDown()
	{
		if (MySolid.CanClickable == true)
			StartCoroutine (SolidicationEvent ());
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


	}


	IEnumerator SolidicationEvent()
	{
		mymyRuneManagerScript.timerTactic = 0;
		RuneManager.GetComponent<RuneManagerScript> ().RuneActivated = false;
		RuneManager.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
		myMainCam.GetComponent<BloomOptimized> ().enabled = false;

		GetComponent<Collider2D> ().isTrigger = false;
		Time.timeScale = 1f;
		Cursor.visible = false;
		yield return new WaitForSeconds(10f);
		GetComponent<Collider2D> ().isTrigger = true;

//		myBlindEnmnemyRune.CanClick = false;
//		MyLight.SetActive(false);
//		Cursor.visible = false;
//		Time.timeScale = 1f;
//		yield return new WaitForSeconds (10f);
//		MyLight.SetActive (true);
	}

}
