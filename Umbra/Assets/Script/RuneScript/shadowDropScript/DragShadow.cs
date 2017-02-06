using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DragShadow : MonoBehaviour {
	//GameObject TheRealSPrite;
	Ray ray;
	public bool dragging = true;
	private float distance;
	GameObject MyOverlay;
	public GameObject RuneMangerMy;
	Vector2 rayPoint;

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
		RuneMangerMy.GetComponent<RuneManagerScript> ().RuneActivated = false;
		RuneMangerMy.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
		RuneMangerMy.GetComponent<RuneManagerScript> ().timerDef = 0;
		RuneMangerMy.GetComponent<ShadowInstantiate> ().enabled = false;
		Time.timeScale =1f;
		//Destroy (GetComponent<DragShadow> ());

		gameObject.name=("OldCube");
	}
	void CancelThis()
	{
		RuneMangerMy.GetComponent<RuneManagerScript> ().RuneActivated = false;
		RuneMangerMy.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
		RuneMangerMy.GetComponent<ShadowInstantiate> ().enabled = false;
		Destroy (gameObject);
	}

	void OnMouseUp()
	{
		//dragging = false;
	}
	void Start()
	{
		RuneMangerMy=GameObject.Find ("RuneManager");
		MyOverlay = GameObject.Find ("BlackOverlay");
	}
	void Update()
	{
	//	Time.timeScale =0.1f;
		if (Input.GetMouseButtonDown (1) && dragging)
			CancelThis ();


		if (dragging)
		{		distance = Vector3.Distance(transform.position, Camera.main.transform.position);


			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//Vector3 rayPoint = ray.GetPoint(distance);
			rayPoint = ray.GetPoint(distance);

			transform.position = rayPoint;
		}
	}

}
