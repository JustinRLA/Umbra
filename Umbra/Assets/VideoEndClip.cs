using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoEndClip : MonoBehaviour {
	public MovieTexture EndFilm;

	//audio
	private AudioSource audio;
	//

	// Use this for initialization
	void Start () {
		GetComponent<RawImage> ().texture = EndFilm as MovieTexture;

		//audio
		audio = GetComponent<AudioSource> ();
		audio.clip = EndFilm.audioClip;
		//

		EndFilm.Play ();

		//audio
		audio.Play ();
		//
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
