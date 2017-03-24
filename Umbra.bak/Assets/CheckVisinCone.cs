using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVisinCone : MonoBehaviour {
	Transform[] EnnemyInScene;
	RaycastHit2D[] EnnmyRay;
	Transform player;

	// Use this for initialization
	void Start () {
		player=GameObject.Find("2DCharacter(Shadow)").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(EnnemyInScene[0] != null)
		{
			EnnmyRay [0] = Physics2D.Linecast (player.position, EnnemyInScene [0].position);

		}
	}
}
