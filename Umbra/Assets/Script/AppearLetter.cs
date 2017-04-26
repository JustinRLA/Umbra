using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearLetter : MonoBehaviour {
	public GameObject thisText;
	float valueCOlor;
	public bool active=false;
	public bool bluetext;
	public bool greentext;
	public bool whitetext;
	public bool redtext;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(redtext==true)
		thisText.GetComponent<TextMesh> ().color=new Color(1,0.6f,0.6f,valueCOlor);
		if(bluetext==true)
			thisText.GetComponent<TextMesh> ().color=new Color(0.6f,0.6f,1,valueCOlor);
		if(whitetext==true)
			thisText.GetComponent<TextMesh> ().color=new Color(1,1,1,valueCOlor);
		if(greentext==true)
			thisText.GetComponent<TextMesh> ().color=new Color(0.6f,1,0.6f,valueCOlor);
		
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
		
		if(redtext==true)
			thisText.GetComponent<TextMesh> ().color=new Color(1,0.6f,0.6f,1);
		if(bluetext==true)
			thisText.GetComponent<TextMesh> ().color=new Color(0.6f,0.6f,1,1);
		if(whitetext==true)
			thisText.GetComponent<TextMesh> ().color=new Color(1,1,1,1);
		if(greentext==true)
			thisText.GetComponent<TextMesh> ().color=new Color(0.6f,1,0.6f,1);
		Destroy (gameObject);
	}
}
