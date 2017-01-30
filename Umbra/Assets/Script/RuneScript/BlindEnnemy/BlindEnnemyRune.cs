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
		if(Input.GetMouseButton(0))
		{

			ray=Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray,out myRaycastHit))
			{
				print("FUCKKKKKKKKKKKKKK");

				if(myRaycastHit.collider.tag=="ennemy")
					print("FUCKKKKKKKKKKKKKK");
			}

		}

	}

	public void EnnemyBlinded()
	{
		Cache.SetActive (true);
		Cursor.visible = true;
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
		if (gameObject.tag+"OnMouseDown" == "ennemy")
			print ("FuckYeah");
		//distance = Vector3.Distance(transform.position, Camera.main.transform.position);

	}


}
