using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShadowInstantiate : MonoBehaviour {

	private Color mouseOverColor = Color.blue;
	private Color originalColor = Color.yellow;
	private bool dragging = false;
	private float distance;
	public GameObject myCyube;
	GameObject CurrentGameObject;
	GameObject FullShadow;
	Vector2 MyPos;
	public GameObject myRuneManager;
	//public GameObject myMainCam;


	Transform InstantiateTransform;
//	Vector2 MymousePos;
	void Awake()
	{
	}
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
		FullShadow=GameObject.Find("OmbreRuneImageFull");
		FullShadow.GetComponent<Image> ().enabled = true;
		AkSoundEngine.PostEvent ("PC_Rune_Ombre_Select",gameObject);
		//myRuneManager.GetComponent<RuneManagerScript> ().RuneModeEnabled = false;
		myRuneManager.GetComponent<RuneManagerScript> ().RuneActivated = true;
		Time.timeScale = 1f;
		
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


		



