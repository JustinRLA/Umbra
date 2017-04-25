using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearLetter : MonoBehaviour {
	public GameObject thisText;
	float valueCOlor;
	bool active=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		thisText.GetComponent<TextMesh> ().color=new Color(1,1,1,valueCOlor);
		if(active==true)
		valueCOlor += Time.deltaTime;
		if (valueCOlor>=1)
			Ending ();		}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player" && active==false)
			active = true;
	}

	void Ending()
	{
		thisText.GetComponent<TextMesh> ().color=new Color(1,1,1,1);
		Destroy (gameObject);
	}
}
