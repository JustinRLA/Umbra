using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DragShadow : MonoBehaviour {
	//GameObject TheRealSPrite;
	Ray ray;
	public bool dragging = true;
	private float distance;
	public GameObject RuneMangerMy;
	Vector2 rayPoint;
	public GameObject mainCamMy;
	//	Vector2 MymousePos;
	public GameObject playerMy;
	public float moveSpeed;


	void Start()
	{
		playerMy = GameObject.Find("2DCharacter(Clone)");

		mainCamMy = GameObject.Find ("Main Camera");
		RuneMangerMy=GameObject.Find ("RuneManager");
	}
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
		mainCamMy = GameObject.Find ("Main Camera");

		dragging = false;
		//GetComponent<dragScript> ().enabled = false;
		//Destroy(GameObject.Find("OldCube"));
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - 0.01f);
		RuneMangerMy.GetComponent<RuneManagerScript> ().RuneActivated = false;
		RuneMangerMy.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
		RuneMangerMy.GetComponent<RuneManagerScript> ().timerDef = 0;
		RuneMangerMy.GetComponent<ShadowInstantiate> ().enabled = false;
		mainCamMy.GetComponent<BloomOptimized> ().enabled = false;
		playerMy.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		playerMy.GetComponent<PlatformerCharacter2D> ().enabled = true;
		playerMy.GetComponent<Platformer2DUserControl> ().enabled = true;
		//gameObject.layer = 10;
		RuneMangerMy.GetComponent<RuneManagerScript> ().RuneActivated = false;

		Time.timeScale =1f;
		//Destroy (GetComponent<DragShadow> ());
		GetComponent<DragShadow>().enabled=false;
		GetComponent<SpriteRenderer> ().enabled = false;

		gameObject.name=("OldCube");
	}
	void CancelThis()
	{
		mainCamMy = GameObject.Find ("Main Camera");
		Time.timeScale =1f;

		RuneMangerMy.GetComponent<RuneManagerScript> ().RuneActivated = false;
		RuneMangerMy.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
		RuneMangerMy.GetComponent<ShadowInstantiate> ().enabled = false;
		mainCamMy.GetComponent<BloomOptimized> ().enabled = false;
		playerMy.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		playerMy.GetComponent<PlatformerCharacter2D> ().enabled = true;
		playerMy.GetComponent<Platformer2DUserControl> ().enabled = true;
		RuneMangerMy.GetComponent<RuneManagerScript> ().RuneActivated = false;
		Destroy (gameObject);
	}

	void OnMouseUp()
	{
		//dragging = false;
	}

	void Update()
	{
	//	Time.timeScale =0.1f;
		if (Input.GetMouseButtonDown (1) && dragging)
			CancelThis ();


		if (dragging)
		{		distance = Vector3.Distance(transform.position, Camera.main.transform.position);
			//gameObject.layer = 23;
			GetComponent<SpriteRenderer> ().enabled = true;
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//Vector3 rayPoint = ray.GetPoint(distance);
			rayPoint = ray.GetPoint(distance);

			transform.position = rayPoint;
		}
	}

}
