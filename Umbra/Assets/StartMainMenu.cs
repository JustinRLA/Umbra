using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
		SceneManager.LoadScene("Main Menu");
		AkSoundEngine.PostEvent("Mus_InGame",gameObject);

		AkSoundEngine.PostEvent("Mus_Menu",gameObject);
		print ("Start");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartLevelMusic()
	{
		AkSoundEngine.PostEvent("Mus_Secteur1",gameObject);
	}

	public void ReturnToMenuMusic()
	{
		AkSoundEngine.PostEvent("Mus_Menu",gameObject);
	}
}
