using UnityEngine;
using System.Collections;

public class flipEnnemy : MonoBehaviour {
	
	public float TheScale;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void FlipmyEnnemy () {
		transform.localScale = new Vector3 (0,TheScale,0);
		TheScale = -TheScale;
	}
}
