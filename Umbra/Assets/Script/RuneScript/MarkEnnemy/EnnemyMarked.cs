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

	// Use this for initialization
	void Start () {
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
			myRuneManager.RuneActivated = false;
			StartCoroutine (MarkEvent());
		myRuneManager.RuneModeEnabled = false;
			myRuneManager.timerOffense = 0;
			Time.timeScale = 1f;

		}


	}
	void CancelEvent()
	{
		myRuneManager.GetComponent<RuneManagerScript> ().RuneActivated = false;
		myRuneManager.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1);
		myMainCam.GetComponent<BloomOptimized> ().enabled = false;
		Cursor.visible = false;
		Time.timeScale = 1f;

	}


	IEnumerator MarkEvent()
	{
		myMainCam.GetComponent<Grayscale> ().enabled = false;
		myMainCam.GetComponent<BloomOptimized> ().enabled = false;

		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1);
		myCam.GetComponent<ColorCorrectionCurves> ().enabled = false;
		myRuneManager.timerOffense = myRuneManager.ActualOffense;
		VireLight.SetActive (true);
		gameObject.layer = 13;
		myMarkEnmnemyRune.CanBeClicked = false;
		Cursor.visible = false;
		Time.timeScale = 1f;
		yield return new WaitForSeconds (25f);
		gameObject.layer = 11;
		VireLight.SetActive (false);

	}

}