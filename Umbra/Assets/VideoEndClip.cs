using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VideoEndClip : MonoBehaviour {
	public MovieTexture EndFilm;

	//audio
	private AudioSource audio;
	//

	// Use this for initialization
	void Start () {
		GetComponent<RawImage> ().texture = EndFilm as MovieTexture;

		EndFilm.Play ();
		AkSoundEngine.PostEvent ("CutS_Start",gameObject);

		StartCoroutine (ReturnToMain ());
		//audio
		//
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator ReturnToMain()
	{
		yield return new WaitForSeconds (75);
		SceneManager.LoadScene ("Main Menu");
	}
}
