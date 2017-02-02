using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkEnnemy : MonoBehaviour {
	public GameObject Cache;
	public bool CanBeClick;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void EnemyMarkedStart()
	{
		print ("Done");
		Cache.SetActive (true);
		Cursor.visible = true;
		Time.timeScale =0.1f;

		CanBeClick = true;
	}


}
