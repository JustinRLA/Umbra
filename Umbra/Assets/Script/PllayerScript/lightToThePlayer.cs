using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightToThePlayer : MonoBehaviour {
	public GameObject ThePlayer;
	public float LightHeight;
	public float lightDistance;
	// Use this for initialization
	void Start () {
		ThePlayer = GameObject.Find("2DCharacter(Clone)");

		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = ThePlayer.transform.position ;
		transform.position = new Vector3(ThePlayer.transform.position.x, ThePlayer.transform.position.y+LightHeight,lightDistance);
	}
}
