using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtnSetter : MonoBehaviour {
	public GameObject ContinueBtn;
	public GameObject CommencerNewGame;
	public GameObject CommencerStartedGame;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("SaveSystem") == 0)
		{
			ContinueBtn.SetActive (false);
			CommencerNewGame.SetActive (true);
			CommencerStartedGame.SetActive (false);

		}
		else
		{
			ContinueBtn.SetActive (true);
			CommencerNewGame.SetActive (false);
			CommencerStartedGame.SetActive (true);
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Continue()
	{
		SceneManager.LoadScene ("NiveauComplete");
	}

	 

public void restartGame()
			{
		PlayerPrefs.SetInt ("Death", 0);
		PlayerPrefs.SetInt ("Kill", 0);

		PlayerPrefs.SetInt ("SaveSystem", 0);
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


}
