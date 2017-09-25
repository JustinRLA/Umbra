using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartBtnSetter : MonoBehaviour {
	public GameObject ContinueBtn;
	public GameObject CommencerNewGame;
	public GameObject CommencerStartedGame;
	public bool CreditMainMenu;
	public bool English;
	GameObject MusicBase;
	// Use this for initialization

	void Awake()
	{
		if (English == false)
			PlayerPrefs.SetInt ("English", 0);
		else
			PlayerPrefs.SetInt ("English", 1);

		print(PlayerPrefs.GetInt ("English"));
		MusicBase = GameObject.Find ("MusicBase");
		AkSoundEngine.PostEvent("Mus_InGame",MusicBase);

		AkSoundEngine.PostEvent("Mus_Menu",MusicBase);


	}

	public void ChangeLangage()
	{
		if (English == true)
			SceneManager.LoadScene ("Main menu");
		else
			SceneManager.LoadScene ("Main menuEnglish");
		
	}
	void Start () {
		//MusicBase = GameObject.Find ("MusicBase");
		if (PlayerPrefs.GetInt ("SaveSystem") == 0)
		{
				
			ContinueBtn.SetActive (false);
			CommencerNewGame.SetActive (true);
			CommencerStartedGame.SetActive (false);

		}
		else
		{
			if(CreditMainMenu==false)
			{
			ContinueBtn.SetActive (true);
			CommencerNewGame.SetActive (false);
			CommencerStartedGame.SetActive (true);
			}
			if(CreditMainMenu==true)
			{
				ContinueBtn.SetActive (true);
				CommencerNewGame.SetActive (false);
				CommencerStartedGame.SetActive (true);

				CommencerStartedGame.GetComponent<Image> ().enabled = false;
				CommencerStartedGame.GetComponent<Button> ().enabled = false;

				ContinueBtn.GetComponent<Image> ().enabled = false;
				ContinueBtn.GetComponent<Button> ().enabled = false;

			}

		}
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Continue()
	{
		MusicBase.GetComponent<StartMainMenu> ().PlayerTimer = 		PlayerPrefs.GetInt ("Timer");
		MusicBase.GetComponent<StartMainMenu> ().timerOn = true;

		MusicBase.GetComponent<StartMainMenu> ().StartLevelMusic ();
		SceneManager.LoadScene ("NiveauComplete");
	}

	 

public void restartGame()
			{
		PlayerPrefs.SetInt ("Death", 0);
		PlayerPrefs.SetInt ("Kill", 0);
		PlayerPrefs.SetInt ("Timer", 0);
		PlayerPrefs.SetInt ("RuneMarkNumber", 0);
		PlayerPrefs.SetInt ("RuneTrapNumber", 0);
		PlayerPrefs.SetInt ("RuneShadowNumber", 0);
		PlayerPrefs.SetInt ("RuneGrapNumber", 0);
		PlayerPrefs.SetInt ("RuneLureNumber", 0);
		PlayerPrefs.SetInt ("RuneSolidNumber", 0);

		PlayerPrefs.SetInt ("SaveSystem", 0);
		MusicBase.GetComponent<StartMainMenu> ().PlayerTimer = 0;
			}
	public void RuneHover()
	{
		AkSoundEngine.PostEvent("Menu_Rune_Hover",gameObject);
	}
	public void HoverSound()
	{
		AkSoundEngine.PostEvent("Menu_Hover",gameObject);
	}
	public void ClickSound()
	{
		AkSoundEngine.PostEvent("Menu_Click",gameObject);
	}
	public void CancelSound()
	{
		AkSoundEngine.PostEvent("Menu_Cancel",gameObject);
	}
	public void Quitter()
	{
		Application.Quit();
	}

}
