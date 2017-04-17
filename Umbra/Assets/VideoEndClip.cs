﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoEndClip : MonoBehaviour {
	public MovieTexture EndFilm;

	// Use this for initialization
	void Start () {
		GetComponent<RawImage> ().texture = EndFilm as MovieTexture;
		EndFilm.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
