using UnityEngine;
using System.Collections;

public class Mysigntrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D col) 
	{
		if (col.name == "2DSight")
			print ("LaserDetect");
	}
}
