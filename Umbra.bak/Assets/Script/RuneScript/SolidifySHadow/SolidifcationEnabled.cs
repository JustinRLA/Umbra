using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolidifcationEnabled : MonoBehaviour {
	public bool CanClickable=false;
//	public GameObject MyCache;
	public GameObject[] AllShadow;
	GameObject RuneManager;
	// Use this for initialization
	void Start () {
		RuneManager = GameObject.Find ("RuneManager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SolidificationStart()
	{
		RuneManager = GameObject.Find ("RuneManager");

		AllShadow = GameObject.FindGameObjectsWithTag ("Ombre");

		foreach (GameObject Ombre in AllShadow)
		{
			Ombre.GetComponent<Collider2D> ().isTrigger = false;
			Ombre.layer = 23;
		}
		RuneManager.GetComponent<RuneManagerScript> ().RuneActivated = true;

	//MyCache.SetActive (true);
	Cursor.visible = true;

		CanClickable = true;
	}
}