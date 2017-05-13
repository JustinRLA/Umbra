using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyParticle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (DeathToTheWave ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator DeathToTheWave()
	{
		yield return new WaitForSeconds (1f);
		Destroy (gameObject);
	}

}
