using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customDestroyParticle : MonoBehaviour {
	public float CustomTime;

	// Use this for initialization
	void Start () {
		StartCoroutine (BeforeApocalypse ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator BeforeApocalypse()
	{
		yield return new WaitForSeconds (CustomTime);
		Destroy (gameObject);
	}
}
