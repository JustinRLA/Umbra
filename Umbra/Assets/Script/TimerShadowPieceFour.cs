using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerShadowPieceFour : MonoBehaviour {
	public GameObject ShadowOne;
	public GameObject ShadowTwo;
	public GameObject ShadowThree;
	public bool paprika=true;

	// Use this for initialization
	void Start () {

	}
	public void StartShadow(){
	
		StartCoroutine(TimerOmbre());
		StartCoroutine(TimerOmbreTwo());

	}
	public void StopShadow(){

		StopCoroutine(TimerOmbre());
		StopCoroutine(TimerOmbreTwo());

	}
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator TimerOmbre()
	{
		while(true)
		{
			print ("Pass");
		ShadowOne.SetActive (true);
			//AkSoundEngine.PostEvent ("Amb_Shadow_Pipe", gameObject);
		yield return new WaitForSeconds (3f);
			print ("Pass2");

			//AkSoundEngine.PostEvent ("Amb_Shadow_Pipe", gameObject);
		ShadowTwo.SetActive (true);

		yield return new WaitForSeconds (2f);
		ShadowOne.SetActive (false);
		yield return new WaitForSeconds (3f);
		ShadowTwo.SetActive (false);
			yield return new WaitForSeconds (2f);

		}

	}

	IEnumerator TimerOmbreTwo()
	{
		while(paprika)
		{
			ShadowThree.SetActive (true);
			yield return new WaitForSeconds (3f);
			ShadowThree.SetActive (false);
			yield return new WaitForSeconds (3f);

		}

	}
}
