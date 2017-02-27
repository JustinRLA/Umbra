using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OeillereScriptCheckDown : MonoBehaviour {
	public bool IsInside;
	public GameObject Base;
	public bool inJudaMode;
	public GameObject OeillereFeedback;

	// Use this for initialization
	void Start () {
		OeillereFeedback=GameObject.Find("feedbackOeillere");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (IsInside && Input.GetKeyDown (KeyCode.E)) 
			inJudaMode = true;

		if(IsInside==true && inJudaMode==false)
			OeillereFeedback.GetComponent<SpriteRenderer>().enabled=true;
//		else
//			OeillereFeedback.GetComponent<SpriteRenderer>().enabled=false;


		if(inJudaMode==true)
		{
			Base.layer = 1;
		}
	else
		Base.layer = 0;
				
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player")
			IsInside = true;
		
	} 	void OnTriggerExit2D(Collider2D col)
	{			OeillereFeedback.GetComponent<SpriteRenderer>().enabled=false;
		
		if (col.tag == "Player")
		{
			IsInside=false;
			inJudaMode=false;
		} 
	} 



}
