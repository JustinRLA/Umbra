using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinePipePuzzle : MonoBehaviour {
	public GameObject[] Pipe;
	public float timebetween;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void StartPipe()
	{
		StartCoroutine (PipeCoroutine ());

	}
	IEnumerator PipeCoroutine()
	{
		while (true)
		{
		Pipe [4].SetActive (false);
		Pipe [0].SetActive (true);
			AkSoundEngine.PostEvent ("Amb_Shadow_Pipe", gameObject);

		yield return new WaitForSeconds (timebetween);
			AkSoundEngine.PostEvent ("Amb_Shadow_Pipe", gameObject);

		Pipe [1].SetActive (true);
		Pipe [5].SetActive (false);
		yield return new WaitForSeconds (timebetween);
			AkSoundEngine.PostEvent ("Amb_Shadow_Pipe", gameObject);

		Pipe [2].SetActive (true);
		Pipe [0].SetActive (false);
			Pipe [6].SetActive (false);

		yield return new WaitForSeconds (timebetween);
		Pipe [3].SetActive (true);
		Pipe [1].SetActive (false);
		yield return new WaitForSeconds (timebetween);
			AkSoundEngine.PostEvent ("Amb_Shadow_Pipe", gameObject);

		Pipe [4].SetActive (true);
		Pipe [2].SetActive (false);
		yield return new WaitForSeconds (timebetween);
			AkSoundEngine.PostEvent ("Amb_Shadow_Pipe", gameObject);

		Pipe [5].SetActive (true);
		Pipe [3].SetActive (false);
			Pipe [6].SetActive (true);

		yield return new WaitForSeconds (timebetween);


	}
	}
}
