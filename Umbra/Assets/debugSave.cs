using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugSave : MonoBehaviour {
	public int SaveLoad;
	// Use this for initialization
	void Awake () {
		PlayerPrefs.SetInt ("SaveSystem", SaveLoad);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
