using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startTimer : MonoBehaviour {
	public GameObject timershadow;
	public GameObject SecondShadow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Player" && PlayerPrefs.GetInt ("SaveSystem") == 6) {
			timershadow.GetComponent<TimerShadowPieceFour> ().StartShadow ();
			Destroy (gameObject);
		}

		if (col.tag == "Player" && PlayerPrefs.GetInt("SaveSystem")==7)
		{
			timershadow.GetComponent<TimerShadowPieceFour> ().StopShadow ();
			Destroy(gameObject);
		}
		if (col.tag == "Player" && PlayerPrefs.GetInt("SaveSystem") >=9)
		{
			print ("starttimer");
			SecondShadow.GetComponent<CoroutinePipePuzzle> ().StartPipe ();
			Destroy(gameObject);
		}

		

	}
}
