using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipSceneBtn : MonoBehaviour {
	public GameObject AdvertSign;
	int numberEscape;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) && numberEscape==0) {
			AdvertSign.SetActive (true);
			numberEscape = 1;
		}
		if (Input.GetKeyDown (KeyCode.Escape) && numberEscape==1) {
			SceneManager.LoadScene ("LeaderBoard_French");
		}
	}
}
