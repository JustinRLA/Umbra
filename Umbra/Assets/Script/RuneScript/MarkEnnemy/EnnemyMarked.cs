using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMarked : MonoBehaviour {
	MarkEnnemy myMarkEnmnemyRune;
	public GameObject RuneManager;
	public GameObject VireLight;
	RuneManagerScript myRuneManager;
	// Use this for initialization
	void Start () {
		myMarkEnmnemyRune = RuneManager.GetComponent<MarkEnnemy> ();
		myRuneManager = RuneManager.GetComponent<RuneManagerScript> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1) && myMarkEnmnemyRune.CanBeClick == true)
			CancelEvent ();
	}

	void OnMouseEnter()
	{
	}

	void OnMouseExit()
	{
	}

	void OnMouseDown()
	{
		if (myMarkEnmnemyRune.CanBeClick == true)
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

		Cursor.visible = false;
		Time.timeScale = 1f;

	}


	IEnumerator MarkEvent()
	{
		myRuneManager.timerOffense = myRuneManager.ActualOffense;
		VireLight.SetActive (true);
		gameObject.layer = 13;
		myMarkEnmnemyRune.CanBeClick = false;
		Cursor.visible = false;
		Time.timeScale = 1f;
		yield return new WaitForSeconds (25f);
		gameObject.layer = 11;
		VireLight.SetActive (false);

	}

}