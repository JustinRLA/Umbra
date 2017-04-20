using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevelThirdMusic : MonoBehaviour {
	public GameObject camSound;
	public bool MusTest;
	public GameObject MusBase;



	// Use this for initialization
	void Start () {
		camSound = GameObject.Find ("MainCamera");
		if (MusTest == false)
			MusBase = GameObject.Find ("MusicBase");
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if(MusTest==false)
			AkSoundEngine.PostEvent ("Mus_Secteur3", MusBase);
		else
			AkSoundEngine.PostEvent ("Mus_Secteur3", camSound);


	}
}