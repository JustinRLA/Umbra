using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerShadowPieceFour : MonoBehaviour {
	public GameObject ShadowOne;
	public GameObject ShadowTwo;
	public GameObject ShadowThree;

	// Use this for initialization
	void Start () {
		StartCoroutine(TimerOmbre());
		StartCoroutine(TimerOmbreTwo());

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator TimerOmbre()
	{
		while(true)
		{
		ShadowOne.SetActive (true);
			AkSoundEngine.PostEvent ("Amb_Shadow_Pipe", gameObject);
		yield return new WaitForSeconds (2f);
			AkSoundEngine.PostEvent ("Amb_Shadow_Pipe", gameObject);
		ShadowTwo.SetActive (true);
		yield return new WaitForSeconds (1f);
		ShadowOne.SetActive (false);
		yield return new WaitForSeconds (2f);
		ShadowTwo.SetActive (false);
		}

	}

	IEnumerator TimerOmbreTwo()
	{
		while(true)
		{
			ShadowThree.SetActive (true);
			yield return new WaitForSeconds (3f);
			ShadowThree.SetActive (false);
			yield return new WaitForSeconds (3f);

		}

	}
}
