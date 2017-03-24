using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followLureUI : MonoBehaviour {
	public GameObject LurePlayrt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = LurePlayrt.transform.position;
	}
}
