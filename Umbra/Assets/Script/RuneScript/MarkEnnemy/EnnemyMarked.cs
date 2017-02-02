using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMarked : MonoBehaviour {
	MarkEnnemy myMarkEnmnemyRune;
	public GameObject RuneManager;
	public GameObject VireLight;

	// Use this for initialization
	void Start () {
		myMarkEnmnemyRune = RuneManager.GetComponent<MarkEnnemy> ();

	}

	// Update is called once per frame
	void Update () {

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
			StartCoroutine (MarkEvent());
	}

	IEnumerator MarkEvent()
	{
		VireLight.SetActive (true);
		gameObject.layer = 13;
		myMarkEnmnemyRune.CanBeClick = false;
		Cursor.visible = false;
		Time.timeScale = 1f;
		yield return new WaitForSeconds (10f);
		gameObject.layer = 11;
		VireLight.SetActive (false);

	}

}