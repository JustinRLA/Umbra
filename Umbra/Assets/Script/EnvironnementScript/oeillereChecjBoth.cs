using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oeillereChecjBoth : MonoBehaviour {
	public bool IsInside;
	public GameObject Base;
	public bool inJudaMode;
	public GameObject PlayeroNE;
	public int OeillereLayer;
	public Sprite spriteOver;
	public Sprite SpriteOriginal;

	// Use this for initialization
	void Start () {
		PlayeroNE=GameObject.Find("2DCharacter(Clone)");
		//SpriteOriginal = Base.GetComponent<Sprite>();
	}

	// Update is called once per frame
	void Update () {
		if (IsInside && Input.GetKeyDown (KeyCode.E)) 
			inJudaMode = true;



		if (inJudaMode == true) {
			if (PlayeroNE.transform.position.y <= transform.position.y)
				Base.layer = OeillereLayer;
			else
				Base.layer = 1;
		} else {
			Base.layer = 0;


		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player") {
			IsInside = true;
			Base.GetComponent<SpriteRenderer > ().sprite = spriteOver;
		}

	} 	

	void OnTriggerExit2D(Collider2D col)
	{

		if (col.tag == "Player")
		{
			IsInside=false;
			inJudaMode=false;
			Base.GetComponent<SpriteRenderer >().sprite = SpriteOriginal;

		} 
	} 



}
