using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAmbiantSOund : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AkSoundEngine.PostEvent ("Mus_Secteur1", gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
