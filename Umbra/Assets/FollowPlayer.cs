using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
	Vector3 ProjDir;
	float angle;
	public Transform ThePlayer;
	public GameObject MyPlayer;
	// Use this for initialization
	void Start () {
		MyPlayer = GameObject.Find ("2DCharacter");
		ThePlayer = MyPlayer.transform;
	}
	
	// Update is called once per frame
	void Update () {
		ProjDir = ThePlayer.position - transform.position;
		angle = Mathf.Atan2 (ProjDir.y, ProjDir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);

	}
}
