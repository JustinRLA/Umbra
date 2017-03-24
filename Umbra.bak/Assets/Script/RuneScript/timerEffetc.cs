using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerEffetc : MonoBehaviour {
	public int BeforeDestroy;

	// Use this for initialization
	void Start () {
		StartCoroutine (Destroyy());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator Destroyy () {
		yield return new WaitForSeconds (BeforeDestroy);
		Destroy (gameObject);
	}
}
