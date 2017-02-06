using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolidifcationEnabled : MonoBehaviour {
	public bool CanClickable=false;
	public GameObject MyCache;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SolidificationStart()
	{
		GetComponent<RuneManagerScript> ().RuneActivated = true;

	MyCache.SetActive (true);
	Cursor.visible = true;

		CanClickable = true;
	}
}