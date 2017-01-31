using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyIsBlind : MonoBehaviour {
	BlindEnnemyRune myBlindEnmnemyRune;
	public GameObject RuneManager;
	public GameObject MyLight;

	// Use this for initialization
	void Start () {
		myBlindEnmnemyRune = RuneManager.GetComponent<BlindEnnemyRune> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseEnter()
	{
		if (myBlindEnmnemyRune.CanClick == true)
			print ("Clicked");
	}

	void OnMouseExit()
	{
	}

	void OnMouseDown()
	{
		if (myBlindEnmnemyRune.CanClick == true)
			StartCoroutine (BlindEvent ());
		}

	IEnumerator BlindEvent()
	{
		myBlindEnmnemyRune.CanClick = false;
		MyLight.SetActive(false);
		Cursor.visible = false;
		Time.timeScale = 1f;
		yield return new WaitForSeconds (10f);
		MyLight.SetActive (true);
	}


}
