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


	// Use this for initialization
	void Start () {
		myRuneManager = GetComponent<RuneManagerScript> ();
	}
	
	// Update is called once per frame
	void Update () {
	//	myraycast = Physics2D.Raycast(Mousepos,Mousepos-Camera.main.ScreenToWorldPoint(Mousepos));
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		myraycast = Physics2D.Raycast(ray.origin, ray.direction,Mathf.Infinity);
	
		Mousepos = (Input.mousePosition);
		Mousepos.z = 0;

		if(myraycast)
		{
			if (myraycast.collider.tag == "Ombre")
				CanInstantiate = true;
			else
				CanInstantiate = false;

			if(CanInstantiate==true)
			{
				if(Input.GetMouseButton(0))
				{
					Instantiate (Trapping, myraycast.point,transform.rotation);
					Time.timeScale = 1f;
					myRuneManager.timerOffense = 0;

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

	}

}
