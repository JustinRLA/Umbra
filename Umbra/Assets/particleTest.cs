using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleTest : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		StartCoroutine (testparticle ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator testparticle()
	{
		yield return new WaitForSeconds (3f);
		GetComponent<ParticleSystem> ().Stop();
	}

}
