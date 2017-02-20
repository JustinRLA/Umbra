using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableTrapMode : MonoBehaviour {
	Vector3 Mousepos;
	RaycastHit2D myraycast;
	Ray ray;
	public bool CanInstantiate;
	bool ScriptIsActivaed=false;
	public GameObject Trapping;
	RuneManagerScript myRuneManager;
	public GameObject gameCam;
	public GameObject trapcam;


	// Use this for initialization
	void Start () {
		myRuneManager = GetComponent<RuneManagerScript> ();
		trapcam = GameObject.Find ("Main CameraTrapRegion");
	}
	
	// Update is called once per frame
	void Update () {
	//	myraycast = Physics2D.Raycast(Mousepos,Mousepos-Camera.main.ScreenToWorldPoint(Mousepos));
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		myraycast = Physics2D.Raycast(ray.origin, ray.direction,Mathf.Infinity);
	
		Mousepos = (Input.mousePosition);
		Mousepos.z = 0;

		if(Input.GetMouseButton(1))
		{
			
			myRuneManager.GetComponent<RuneManagerScript> ().RuneActivated = false;
			myRuneManager.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
			Time.timeScale = 1f;
			gameCam.GetComponent<BloomOptimized> ().enabled = false;
			trapcam.SetActive (false);

			GetComponent<EnableTrapMode> ().enabled = false;
			
		}	

		if(myraycast)
		{
			if (myraycast.collider.tag == "TrapPlacement")
				CanInstantiate = true;
			else
				CanInstantiate = false;

			if(CanInstantiate==true)
			{
				if(Input.GetMouseButton(0) && ScriptIsActivaed==true)
				{

					Instantiate (Trapping, myraycast.point,transform.rotation);
					myRuneManager.GetComponent<RuneManagerScript> ().RuneActivated = false;
					myRuneManager.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;

					Time.timeScale = 1f;
					myRuneManager.timerOffense = 0;
					gameCam.GetComponent<BloomOptimized> ().enabled = false;
					ScriptIsActivaed=false;
					trapcam.SetActive (false);

					GetComponent<EnableTrapMode> ().enabled = false;

				}	
			}
		}
	}


	public void EnabledTrapMode()
	{
		Time.timeScale = 0.1f;
		Cursor.visible = true;
		ScriptIsActivaed = true;
		trapcam.SetActive (true);
	}

}
