using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RuneTutoEvent : MonoBehaviour {
	bool actiatefirstEvent;
	public GameObject FirstText;
	public GameObject SecondText;
	public GameObject ThirdText;

	public GameObject FirstTextEng;
	public GameObject SecondTextEng;
	public GameObject ThirdTextEng;

	public GameObject FirstTextFr;
	public GameObject SecondTextFr;
	public GameObject ThirdTextFr;

	float valueCOlor;
	float valuerColorTwo;
	float valuerColorThree;

	public bool activateSecondEvent;
	bool activateThirdEvent;

	GameObject RuneManager;



	// Use this for initialization
	void Start () {
		FirstTextFr.GetComponent<SpriteRenderer> ().color=new Color(1,1,1,0);
		SecondTextFr.GetComponent<SpriteRenderer> ().color=new Color(1,1,1,0);
		ThirdTextFr.GetComponent<SpriteRenderer> ().color=new Color(1,1,1,0);

		FirstTextEng.GetComponent<SpriteRenderer> ().color=new Color(1,1,1,0);
		SecondTextEng.GetComponent<SpriteRenderer> ().color=new Color(1,1,1,0);
		ThirdTextEng.GetComponent<SpriteRenderer> ().color=new Color(1,1,1,0);


		if (PlayerPrefs.GetInt ("English") == 0) {
			FirstText = FirstTextFr;
			SecondText = SecondTextFr;
			ThirdText = ThirdTextFr;
		}
		if (PlayerPrefs.GetInt ("English") == 1) {
			FirstText = FirstTextEng;
			SecondText = SecondTextEng;
			ThirdText = ThirdTextEng;
		}
		

		RuneManager = GameObject.Find ("RuneManager");
	}
	
	// Update is called once per frame
	void Update () {
		FirstText.GetComponent<SpriteRenderer> ().color=new Color(1,1,1,valueCOlor);
		SecondText.GetComponent<SpriteRenderer> ().color=new Color(1,1,1,valuerColorTwo);
		ThirdText.GetComponent<SpriteRenderer> ().color=new Color(1,1,1,valuerColorThree);

		if(actiatefirstEvent==true)
			valueCOlor += Time.deltaTime*5;

		if (actiatefirstEvent == true && Input.GetMouseButton (1)) {
			activateSecondEvent = true;
		}
		if (activateSecondEvent == true) {
			valueCOlor = 0.4f;
			FirstText.GetComponent<SpriteRenderer> ().color=new Color(1,1,1,0.5f);

			valuerColorTwo += Time.deltaTime * 5;
			actiatefirstEvent = false;

		}
		if (activateThirdEvent == true) {
			SecondText.GetComponent<SpriteRenderer> ().color=new Color(1,1,1,0.4f);
			valuerColorTwo = 0.4f;

			valuerColorThree += Time.deltaTime * 5;
			activateSecondEvent = false;
		}

		if(RuneManager.GetComponent<RuneManagerScript>().RuneModeEnabled && Input.GetKey(KeyCode.Alpha1) && activateSecondEvent==true)
		{

			activateThirdEvent = true;
		}
		if (activateThirdEvent == true) {
			valuerColorThree += Time.deltaTime;
			SecondText.GetComponent<SpriteRenderer> ().color=new Color(1,1,1,0.4f);

		}
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
		ThirdText.GetComponent<SpriteRenderer> ().color=new Color(1,1,1,1);
		Destroy (gameObject);

	}
}
