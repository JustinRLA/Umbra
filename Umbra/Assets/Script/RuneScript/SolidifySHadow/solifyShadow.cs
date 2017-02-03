using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solifyShadow : MonoBehaviour {
	SolidifcationEnabled MySolid;
	public GameObject RuneManager;
	RuneManagerScript mymyRuneManagerScript;

	// Use this for initialization
	void Start () {
		mymyRuneManagerScript = RuneManager.GetComponent<RuneManagerScript> ();
		RuneManager = GameObject.Find ("RuneManager");
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

	void CancelAction()
	{

		Time.timeScale = 1f;
		Cursor.visible = false;
	}


	IEnumerator SolidicationEvent()
	{
		
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
