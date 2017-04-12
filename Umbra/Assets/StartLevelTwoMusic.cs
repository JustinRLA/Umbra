using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevelTwoMusic : MonoBehaviour {
	public GameObject camSound;
	// Use this for initialization
	void Start () {
		camSound = GameObject.Find ("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		AkSoundEngine.PostEvent ("Mus_Secteur2", camSound);

	}
}
