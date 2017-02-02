using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindEnnemyRune : MonoBehaviour {
	public GameObject Cache;
	RaycastHit myRaycastHit;
	Ray ray;

	public bool  CanClick=false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



	}

	public void EnnemyBlinded()
	{
		Cache.SetActive (true);
		Cursor.visible = true;
		Time.timeScale =0.1f;

		CanClick = true;
	}

	void OnMouseEnter()
	{
		
	}

	void OnMouseExit()
	{
	}

	void OnMouseDown()
	{
		//distance = Vector3.Distance(transform.position, Camera.main.transform.position);

	}


}
