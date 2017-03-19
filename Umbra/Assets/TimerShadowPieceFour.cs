using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerShadowPieceFour : MonoBehaviour {
	public GameObject ShadowOne;
	public GameObject ShadowTwo;

	// Use this for initialization
	void Start () {
		StartCoroutine(TimerOmbre());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator TimerOmbre()
	{
		while(true)
		{
		ShadowOne.SetActive (true);
		yield return new WaitForSeconds (2f);
		ShadowTwo.SetActive (true);
		yield return new WaitForSeconds (1f);
		ShadowOne.SetActive (false);
		yield return new WaitForSeconds (2f);
		ShadowTwo.SetActive (false);
		}

	}

}
