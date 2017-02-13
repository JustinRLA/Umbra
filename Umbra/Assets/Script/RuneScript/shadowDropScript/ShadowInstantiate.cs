using UnityEngine;
using System.Collections;

public class ShadowInstantiate : MonoBehaviour {

	private Color mouseOverColor = Color.blue;
	private Color originalColor = Color.yellow;
	private bool dragging = false;
	private float distance;
	public GameObject myCyube;
	GameObject CurrentGameObject;
	public GameObject Cache;
	Vector2 MyPos;
	public GameObject myRuneManager;
	public GameObject myMainCam;


	Transform InstantiateTransform;
//	Vector2 MymousePos;

	void OnMouseEnter()
	{
		GetComponent<Renderer>().material.color = mouseOverColor;
	}

	void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = originalColor;
	}

	void OnMouseDown()
	{
		//distance = Vector3.Distance(transform.position, Camera.main.transform.position);
		dragging = false;
	}

	void OnMouseUp()
	{
		dragging = false;
	}
	void Start()
	{
	}

	public void InstantiateTheShadow()
	{
		//myRuneManager.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
		myRuneManager.GetComponent<RuneManagerScript> ().RuneActivated = true;
		Time.timeScale = 1f;
		Cache.SetActive (true);
		MyPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Instantiate (myCyube, MyPos,Quaternion.identity);
	}

	void Update()
	{
		
		if (dragging==false)
			MyPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
//		}
		}


		}


		



