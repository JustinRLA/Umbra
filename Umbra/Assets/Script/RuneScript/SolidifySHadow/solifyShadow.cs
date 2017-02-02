using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solifyShadow : MonoBehaviour {
	SolidifcationEnabled MySolid;
	public GameObject RuneManager;
	// Use this for initialization
	void Start () {
		RuneManager = GameObject.Find ("RuneManager");
		MySolid = RuneManager.GetComponent<SolidifcationEnabled> ();

	}
	
	// Update is called once per frame
	void Update () {
		//RuneManager
	}

	void OnMouseDown()
	{
		if (MySolid.CanClickable == true)
			StartCoroutine (SolidicationEvent ());
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
