using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopLureOnStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (stop ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Endy()
	{
		gameObject.SetActive (false);
		GetComponent<stopLureOnStart> ().enabled = false;

	}

	IEnumerator stop()
	{
		yield return new WaitForSeconds (1f);
		Endy ();
	}
}
