using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour {
	bool Paused;
	public GameObject OtherUI;
	public GameObject PauseUI;
	public GameObject RuneManager;
	RuneManagerScript myRuneManScript;

	// Use this for initialization
	void Start () {
		RuneManager = GameObject.Find ("RuneManager");
		myRuneManScript = RuneManager.GetComponent<RuneManagerScript> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) && Paused == false && myRuneManScript.RuneActivated==false)
			PauseBegin ();
			
	}

	void PauseBegin()
	{
		Paused = true;
		Cursor.visible = true;
		Time.timeScale = 0;
		OtherUI.GetComponent<Canvas> ().enabled = false;
		PauseUI.SetActive (true);

	}

	public void PauseEnd()
	{		Cursor.visible = false;
		

		Paused = false;
		Time.timeScale = 1;
		OtherUI.GetComponent<Canvas> ().enabled = true;
		PauseUI.SetActive (false);
	}
	public void ReturnToMainMenu()
	{
		SceneManager.LoadScene ("Main Menu");	}

}
