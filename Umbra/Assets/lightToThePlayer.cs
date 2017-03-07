using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightToThePlayer : MonoBehaviour {
	public GameObject thePlayer;

	// Use this for initialization
	void Start () {
		thePlayer = GameObject.Find ("2DCharacter");
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = thePlayer.transform.position;
	}
}
