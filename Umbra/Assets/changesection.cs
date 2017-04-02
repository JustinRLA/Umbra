using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changesection : MonoBehaviour {
	public GameObject LastSection;
	public GameObject NextSection;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col)
	{
	if(col.tag=="Player")
	{
		NextSection.SetActive (true);



		LastSection.SetActive (false);

	}

}

}
