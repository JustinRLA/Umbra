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

	public GameObject YesBtnFr;
	public GameObject NoBtnFr;
	public GameObject WarningTextFr;
	public GameObject ResumeBtnFr;
	public GameObject QuitBtnFr;

	public GameObject YesBtnEng;
	public GameObject NoBtnEng;
	public GameObject WarningTextEng;
	public GameObject ResumeBtnEng;
	public GameObject QuitBtnEng;

	BorneBase myBorneScript;
	bool canPause=true;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("English") == 0) {
			YesBtnEng=YesBtnFr;
			NoBtn = NoBtnFr;
			WarningText = WarningTextFr;
			QuitBtn = QuitBtnFr;
			ResumeBtn = ResumeBtnFr;
			ResumeBtnEng.SetActive (false);
			QuitBtnEng.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("English") == 1) {
			YesBtnEng=YesBtnEng;
			NoBtn = NoBtnEng;
			WarningText = WarningTextEng;
			QuitBtn = QuitBtnEng;
			ResumeBtn = ResumeBtnEng;
			ResumeBtnFr.SetActive (false);
			QuitBtnFr.SetActive (false);
		}
		
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
		MusicBase = GameObject.Find ("MusicBase");
		MusicBase.GetComponent<StartMainMenu> ().timerOn = false;
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
		MusicBase = GameObject.Find ("MusicBase");
		MusicBase.GetComponent<StartMainMenu> ().timerOn = true;

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
