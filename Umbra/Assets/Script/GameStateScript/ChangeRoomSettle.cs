using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoomSettle : MonoBehaviour {
	public GameObject LastEnnemi;
	public GameObject LastDecount;
	public GameObject player;
	public GameObject NextEnnemy;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("raycar");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D col) {
		if(col.tag=="Player")
		{
			NextEnnemy.SetActive (true);

			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [0] != null) {
				player.GetComponent<CheckVisinCone> ().EnnemyInScene [0] = LastDecount.GetComponent<EnnemyDecount> ().Decount [0];
				player.GetComponent<CheckVisinCone> ().PatrolOne=LastDecount.GetComponent<EnnemyDecount> ().Decount [0].GetComponent<EnnnemyPatrolUpgraded>();
				player.GetComponent<CheckVisinCone> ().ConvisibleOne=LastDecount.GetComponent<EnnemyDecount> ().Decount [0].GetComponent<ConVisible>();
				player.GetComponent<CheckVisinCone> ().MarkOne=LastDecount.GetComponent<EnnemyDecount> ().Decount [0].GetComponent<EnnemyMarked>();

			}
				else
				player.GetComponent<CheckVisinCone>().EnnemyInScene [0] = null;

			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [1] != null) {
				player.GetComponent<CheckVisinCone> ().EnnemyInScene [1] = LastDecount.GetComponent<EnnemyDecount> ().Decount [1];
				player.GetComponent<CheckVisinCone> ().PatrolTwo=LastDecount.GetComponent<EnnemyDecount> ().Decount [1].GetComponent<EnnnemyPatrolUpgraded>();
				player.GetComponent<CheckVisinCone> ().ConvisibleTwo=LastDecount.GetComponent<EnnemyDecount> ().Decount [1].GetComponent<ConVisible>();
				player.GetComponent<CheckVisinCone> ().MarkTwo=LastDecount.GetComponent<EnnemyDecount> ().Decount [1].GetComponent<EnnemyMarked>();

			}
				else
				player.GetComponent<CheckVisinCone>().EnnemyInScene [1] = null;


			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [2] != null) {
				player.GetComponent<CheckVisinCone> ().EnnemyInScene [2] = LastDecount.GetComponent<EnnemyDecount> ().Decount [2];
				player.GetComponent<CheckVisinCone> ().Patrolthree=LastDecount.GetComponent<EnnemyDecount> ().Decount [2].GetComponent<EnnnemyPatrolUpgraded>();
				player.GetComponent<CheckVisinCone> ().ConvisibleThree=LastDecount.GetComponent<EnnemyDecount> ().Decount [2].GetComponent<ConVisible>();
				player.GetComponent<CheckVisinCone> ().MarkThree=LastDecount.GetComponent<EnnemyDecount> ().Decount [2].GetComponent<EnnemyMarked>();

			}
				else
				player.GetComponent<CheckVisinCone>().EnnemyInScene [2] = null;


			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [3] != null) {
				player.GetComponent<CheckVisinCone> ().EnnemyInScene [3] = LastDecount.GetComponent<EnnemyDecount> ().Decount [3];
				player.GetComponent<CheckVisinCone> ().PatrolFour=LastDecount.GetComponent<EnnemyDecount> ().Decount [3].GetComponent<EnnnemyPatrolUpgraded>();
				player.GetComponent<CheckVisinCone> ().ConvisibleFour=LastDecount.GetComponent<EnnemyDecount> ().Decount [3].GetComponent<ConVisible>();
				player.GetComponent<CheckVisinCone> ().MarkFour=LastDecount.GetComponent<EnnemyDecount> ().Decount [3].GetComponent<EnnemyMarked>();

			}
				else
				player.GetComponent<CheckVisinCone>().EnnemyInScene [3] = null;


			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [4] != null) {
				player.GetComponent<CheckVisinCone> ().EnnemyInScene [4] = LastDecount.GetComponent<EnnemyDecount> ().Decount [4];
				player.GetComponent<CheckVisinCone> ().PatrolFive=LastDecount.GetComponent<EnnemyDecount> ().Decount [4].GetComponent<EnnnemyPatrolUpgraded>();
				player.GetComponent<CheckVisinCone> ().ConvisibleFive=LastDecount.GetComponent<EnnemyDecount> ().Decount [4].GetComponent<ConVisible>();
				player.GetComponent<CheckVisinCone> ().MarkFive=LastDecount.GetComponent<EnnemyDecount> ().Decount [4].GetComponent<EnnemyMarked>();

			}
				else
				player.GetComponent<CheckVisinCone>().EnnemyInScene [4] = null;


			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [5] != null) {
				player.GetComponent<CheckVisinCone> ().EnnemyInScene [5] = LastDecount.GetComponent<EnnemyDecount> ().Decount [5];
				player.GetComponent<CheckVisinCone> ().PatrolSix=LastDecount.GetComponent<EnnemyDecount> ().Decount [5].GetComponent<EnnnemyPatrolUpgraded>();
				player.GetComponent<CheckVisinCone> ().ConvisibleSix=LastDecount.GetComponent<EnnemyDecount> ().Decount [5].GetComponent<ConVisible>();
				player.GetComponent<CheckVisinCone> ().MarkSix=LastDecount.GetComponent<EnnemyDecount> ().Decount [5].GetComponent<EnnemyMarked>();

			}
				else
				player.GetComponent<CheckVisinCone>().EnnemyInScene [5] = null;




			LastEnnemi.SetActive (false);

		}

	}
}
