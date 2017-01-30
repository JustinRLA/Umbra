using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dragScript : MonoBehaviour {
	//GameObject TheRealSPrite;

	public bool dragging = true;
	private float distance;
	GameObject MyOverlay;



	//	Vector2 MymousePos;

	void OnMouseEnter()
	{
		//	GetComponent<Renderer>().material.color = mouseOverColor;
	}

	void OnMouseExit()
	{
		//	GetComponent<Renderer>().material.color = originalColor;
	}

	void OnMouseDown()
	{
		dragging = false;
		MyOverlay.SetActive (false);
		//GetComponent<dragScript> ().enabled = false;
		//Destroy(GameObject.Find("OldCube"));
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - 0.01f);
		Time.timeScale =1f;

		Destroy (GetComponent<dragScript> ());
			gameObject.name=("OldCube");
	}

	void OnMouseUp()
	{
		//dragging = false;
	}
	void Start()
	{
		MyOverlay = GameObject.Find ("BlackOverlay");
	}
	void Update()
	{
		Time.timeScale =0f;

		if (dragging)
		{		distance = Vector3.Distance(transform.position, Camera.main.transform.position);


			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//Vector3 rayPoint = ray.GetPoint(distance);
			Vector2 rayPoint = ray.GetPoint(distance);

			transform.position = rayPoint;
		}
	}



}
