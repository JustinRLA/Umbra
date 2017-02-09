using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
	Vector3 ProjDir;
	float angle;
	public Transform ThePlayer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ProjDir = ThePlayer.position - transform.position;
		angle = Mathf.Atan2 (ProjDir.y, ProjDir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);

	}
}
