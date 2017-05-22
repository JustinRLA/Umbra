using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour {
	public bool isEnglish;

	// Use this for initialization
	void Start () {
		
	}
	public void ReturnToMainMenu()
	{
		if (isEnglish == true)
			SceneManager.LoadScene ("Main menuEnglish_Credit");
		else
			SceneManager.LoadScene ("Main menuCredit");
		

	}
	// Update is called once per frame
	void Update () {
		
	}
}
