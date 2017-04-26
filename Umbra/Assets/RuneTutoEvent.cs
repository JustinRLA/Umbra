using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RuneTutoEvent : MonoBehaviour {
	bool actiatefirstEvent;
	public GameObject FirstText;
	public GameObject SecondText;
	public GameObject ThirdText;

	float valueCOlor;
	float valuerColorTwo;
	float valuerColorThree;

	public bool activateSecondEvent;
	bool activateThirdEvent;

	GameObject RuneManager;



	// Use this for initialization
	void Start () {
		RuneManager = GameObject.Find ("RuneManager");
	}
	
	// Update is called once per frame
	void Update () {
		FirstText.GetComponent<TextMesh> ().color=new Color(1,1,1,valueCOlor);
		SecondText.GetComponent<TextMesh> ().color=new Color(1,1,1,valuerColorTwo);
		ThirdText.GetComponent<TextMesh> ().color=new Color(1,0.5f,0.5f,valuerColorThree);

		if(actiatefirstEvent==true)
			valueCOlor += Time.deltaTime*5;

		if (actiatefirstEvent == true && Input.GetMouseButton (1)) {
			FirstText.SetActive (false);
			activateSecondEvent = true;
		}
		if (activateSecondEvent == true)
			valuerColorTwo += Time.deltaTime*5;
		if (activateThirdEvent == true)
			valuerColorThree += Time.deltaTime*5;
		

		if(RuneManager.GetComponent<RuneManagerScript>().RuneModeEnabled && Input.GetKey(KeyCode.Alpha1) && activateSecondEvent==true)
		{
			SecondText.SetActive (false);
			activateThirdEvent = true;
		}
		if (activateThirdEvent == true)
			valuerColorThree += Time.deltaTime;

		if (valuerColorThree >= 1)
			Ending ();


	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player")
			actiatefirstEvent = true;
	}

	void Ending()
	{
		ThirdText.GetComponent<TextMesh> ().color=new Color(1,0.5f,0.5f,1);
		Destroy (gameObject);

	}
}
