using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipTutot : MonoBehaviour {
	bool inTrigger;
	public GameObject WarningUI;
	// Use this for initialization
	void Start () {
		
	}
	public void SkipTuto()
	{
		PlayerPrefs.SetInt ("SaveSystem",6);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);

	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E) && inTrigger == true)
			WarningUI.SetActive (false);
	}
	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Player")
			inTrigger = true;
	}
	void OnTriggerExit2D (Collider2D col) {
		if (col.tag == "Player")
			inTrigger = false;
	}
}
