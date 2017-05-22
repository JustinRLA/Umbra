using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartEndScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player" && PlayerPrefs.GetInt("English")==0)
			SceneManager.LoadScene ("cutscene");
		if (col.tag == "Player" && PlayerPrefs.GetInt("English")==1)
			SceneManager.LoadScene ("cutsceneEnglish");
	}

}
