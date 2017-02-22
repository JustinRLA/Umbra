using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateTest : MonoBehaviour {
	public GameObject mybouteOne;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles = new Vector3(0,0,mybouteOne.transform.eulerAngles.z+180);
	}
}
