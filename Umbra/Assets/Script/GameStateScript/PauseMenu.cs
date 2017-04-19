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
	public GameObject CameraOne;

	// Use this for initialization
	void Start () {
		CameraOne = GameObject.Find ("Main Camera");
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
		AkSoundEngine.PostEvent ("Menu_Pause", gameObject);
		CameraOne.GetComponent<BlurOptimized> ().enabled = true;
		Paused = true;
		Cursor.visible = true;
		Time.timeScale = 0;
		OtherUI.GetComponent<Canvas> ().enabled = false;
		PauseUI.SetActive (true);

	}

	public void PauseEnd()
	{	
		AkSoundEngine.PostEvent ("Menu_Pause_End", gameObject);

		Cursor.visible = false;
		
		CameraOne.GetComponent<BlurOptimized> ().enabled = false;

		Paused = false;
		Time.timeScale = 1;
		OtherUI.GetComponent<Canvas> ().enabled = true;
		PauseUI.SetActive (false);
	}
	public void ReturnToMainMenu()
	{
		SceneManager.LoadScene ("Main Menu");	}

}
