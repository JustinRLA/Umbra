using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollowPlayer : MonoBehaviour {
	public GameObject PlayerMy;
	// Use this for initialization
	void Start () {
		PlayerMy = GameObject.Find ("2DCharacter");
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = new Vector3(PlayerMy.transform.position.x, PlayerMy.transform.position.y,1);
	}
}
