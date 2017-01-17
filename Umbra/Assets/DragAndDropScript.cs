using UnityEngine;
using System.Collections;

public class DragAndDropScript : MonoBehaviour {

	private Color mouseOverColor = Color.blue;
	private Color originalColor = Color.yellow;
	private bool dragging = false;
	private float distance;
	public GameObject myCyube;
	GameObject CurrentGameObject;
	public GameObject Cache;

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
	void Update()
	{
		//MymousePos = Camera.main.ScreenPointToRay (Input.mousePosition);
		//Vector2 MymousePos = Camera.main.ScreenToViewportPoint (Input.mousePosition);
		if (Input.GetKeyDown (KeyCode.E)&&dragging==false)
		{		//Vector2 MymousePos = Input.mousePosition;
			Vector2 MyPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Cache.SetActive (true);

			Instantiate (myCyube, MyPos,Quaternion.identity);
		//	CurrentGameObject = myCyube;
		//	dragging = true;
//			print ("buttonPress");
//			Ray MyRay = Camera.main.ScreenPointToRay (Input.mousePosition);
//		RaycastHit hit;
//		if(Physics.Raycast(MyRay,out hit))
//		{
//			Instantiate(myCyube, hit.point, Quaternion.identity);
//		}
		}


		//if (dragging)
		//{		distance = Vector3.Distance(transform.position, Camera.main.transform.position);
			

			//Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		////Vector3 rayPoint = ray.GetPoint(distance);
			//Vector2 rayPoint = ray.GetPoint(distance);

			//CurrentGameObject.transform.position = rayPoint;
		}
	}
		//IEnumerator CreateObject()
		//{
//		Ray MyRay = Camera.main.ScreenPointToRay (Input.mousePosition);
//		RaycastHit hit;
//		if(Physics.Raycast(MyRay,out hit))
//			{
//				Instantiate(myCyube, hit.point, Quaternion.identity);
//			}
		//yield return null;

		



