using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMoveemntAnim : MonoBehaviour {
	GameObject Player;
	public Transform StartPosition;
	public Transform ObjectivePosition;
	float timer=0.3f;
	Vector3 dir;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find("2DCharacter(Clone)");
		ObjectivePosition=Player.GetComponent<DeathEvent> ().EnnemyPos;
		dir =  ObjectivePosition.position-transform.position;
			
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		transform.position += dir * Time.deltaTime*3;


		if(timer<0)
			GetComponent<SpriteMoveemntAnim>().enabled=false;
		
	}
}
