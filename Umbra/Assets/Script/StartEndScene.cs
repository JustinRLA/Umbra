using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartEndScene : MonoBehaviour {
	GameObject Musicbase;

	// Use this for initialization
	void Start () {
		Musicbase = GameObject.Find ("MusicBase");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player" && PlayerPrefs.GetInt ("English") == 0) {
			Musicbase.GetComponent<StartMainMenu> ().timerOn = false;
			PlayerPrefs.SetFloat ("Timer", Musicbase.GetComponent<StartMainMenu> ().PlayerTimer);
			SceneManager.LoadScene ("cutscene");

		
		}
		if (col.tag == "Player" && PlayerPrefs.GetInt("English")==1)
		{
			Musicbase.GetComponent<StartMainMenu> ().timerOn = false;
		PlayerPrefs.SetFloat ("Timer", Musicbase.GetComponent<StartMainMenu> ().PlayerTimer);
			SceneManager.LoadScene ("cutsceneEnglish");
	}
	}
}
