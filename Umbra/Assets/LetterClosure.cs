using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterClosure : MonoBehaviour {
	public GameObject ThisLetter;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void closure()
	{
		ThisLetter.SetActive (false);
	}
}
