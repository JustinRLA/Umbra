using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class ConditionToStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (GameObject.Find ("SaveSystem"))
			SceneManager.LoadScene ("Main Menu");
		else
			SceneManager.LoadScene ("Begin");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
