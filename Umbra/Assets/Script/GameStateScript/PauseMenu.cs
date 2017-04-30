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
	public GameObject BorneBaseObj;
	GameObject MusicBase;
	public bool isPause;
	public GameObject YesBtn;
	public GameObject NoBtn;
	public GameObject WarningText;
	public GameObject ResumeBtn;
	public GameObject QuitBtn;


	BorneBase myBorneScript;
	bool canPause=true;

	// Use this for initialization
	void Start () {
		CameraOne = GameObject.Find ("Main Camera");
		RuneManager = GameObject.Find ("RuneManager");
		myRuneManScript = RuneManager.GetComponent<RuneManagerScript> ();
		BorneBaseObj = GameObject.Find ("BorneBase");
		myBorneScript = BorneBaseObj.GetComponent<BorneBase> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) && Paused == false && myRuneManScript.RuneActivated == false && myBorneScript.inTrapSelectionMode == false && canPause == true) {
			canPause = false;
			PauseBegin ();
		
		}
		if (Input.GetKeyDown (KeyCode.Escape) && Paused == true && PauseUI.activeInHierarchy == true && canPause == true) {
			canPause = false;
			PauseEnd ();
		
		}
		if (Input.GetKeyUp (KeyCode.Escape))
			canPause = true;
			
	}

	void PauseBegin()
	{
		isPause = true;
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
		isPause = false;
		AkSoundEngine.PostEvent ("Menu_Pause_End", gameObject);

		Cursor.visible = false;
		
		CameraOne.GetComponent<BlurOptimized> ().enabled = false;

		Paused = false;
		Time.timeScale = 1;
		OtherUI.GetComponent<Canvas> ().enabled = true;
		QuitBtn.SetActive (true);
		ResumeBtn.SetActive (true);
		YesBtn.SetActive (false);
		NoBtn.SetActive (false);
		WarningText.SetActive (false);

		PauseUI.SetActive (false);
	}
	public void ReturnToMainMenu()
	{
		MusicBase = GameObject.Find ("MusicBase");

		AkSoundEngine.PostEvent ("Mus_Menu",MusicBase);
		SceneManager.LoadScene ("Main Menu");	}

}
