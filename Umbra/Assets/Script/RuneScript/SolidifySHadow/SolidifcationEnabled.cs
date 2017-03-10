using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolidifcationEnabled : MonoBehaviour {
	public bool CanClickable=false;
//	public GameObject MyCache;
	public GameObject[] AllShadow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SolidificationStart()
	{
		AllShadow = GameObject.FindGameObjectsWithTag ("Ombre");

		foreach (GameObject Ombre in AllShadow)
		{
			Ombre.GetComponent<Collider2D> ().isTrigger = false;
			Ombre.layer = 23;
		}


	//MyCache.SetActive (true);
	Cursor.visible = true;

		CanClickable = true;
	}
}