using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
		SceneManager.LoadScene("Main Menu");
		print ("Start");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartLevelMusic()
	{
		if(PlayerPrefs.GetInt("SaveSystem")<6)
		AkSoundEngine.PostEvent("Mus_Secteur1",gameObject);
		if(PlayerPrefs.GetInt("SaveSystem")>=6 && PlayerPrefs.GetInt("SaveSystem")<=8)
			AkSoundEngine.PostEvent("Mus_Secteur2",gameObject);
		if(PlayerPrefs.GetInt("SaveSystem")>=9)
			AkSoundEngine.PostEvent("Mus_Secteur3",gameObject);
	}

	public void ReturnToMenuMusic()
	{
		AkSoundEngine.PostEvent("Mus_Menu",gameObject);
	}
}
