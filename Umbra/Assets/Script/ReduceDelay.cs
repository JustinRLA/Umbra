using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduceDelay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (Reducing ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Reducing()
	{
		
		Time.timeScale = 0.1f;
		GetComponent<SpriteRenderer> ().sortingOrder = 10;
		yield return new WaitForSeconds (1.5f);
		GetComponent<Animator> ().SetBool ("Play", true);
		GetComponent<SpriteRenderer> ().sortingOrder = 0;
		Time.timeScale = 1f;

	}
}
