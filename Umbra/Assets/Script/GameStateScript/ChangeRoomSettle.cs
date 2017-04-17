using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoomSettle : MonoBehaviour {
	public GameObject LastEnnemi;
	public GameObject LastDecount;
	public GameObject TrueLastDecount;

	public GameObject player;
	public GameObject NextEnnemy;

	GameObject[] AllInstantiateShadow;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("raycar");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D col) {
		AllInstantiateShadow = GameObject.FindGameObjectsWithTag ("Ombre");

		foreach (GameObject Ombre in AllInstantiateShadow)
		{
			if (Ombre.name == "OldCube")
				Destroy (Ombre.gameObject);
		}
	


		if(col.tag=="Player")
		{
			NextEnnemy.SetActive (true);

			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [0] != null) {
				player.GetComponent<CheckVisinCone> ().EnnemyInScene [0] = LastDecount.GetComponent<EnnemyDecount> ().Decount [0];
				player.GetComponent<CheckVisinCone> ().PatrolOne=LastDecount.GetComponent<EnnemyDecount> ().Decount [0].GetComponent<EnnnemyPatrolUpgraded>();
				player.GetComponent<CheckVisinCone> ().ConvisibleOne=LastDecount.GetComponent<EnnemyDecount> ().Decount [0].GetComponent<ConVisible>();
				player.GetComponent<CheckVisinCone> ().MarkOne=LastDecount.GetComponent<EnnemyDecount> ().Decount [0].GetComponent<EnnemyMarked>();
				LastDecount.GetComponent<EnnemyDecount> ().Decount [0].GetComponent<EnnnemyPatrolUpgraded>().NormalStart();


			}
				else
				player.GetComponent<CheckVisinCone>().EnnemyInScene [0] = null;

			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [1] != null) {
				player.GetComponent<CheckVisinCone> ().EnnemyInScene [1] = LastDecount.GetComponent<EnnemyDecount> ().Decount [1];
				player.GetComponent<CheckVisinCone> ().PatrolTwo=LastDecount.GetComponent<EnnemyDecount> ().Decount [1].GetComponent<EnnnemyPatrolUpgraded>();
				player.GetComponent<CheckVisinCone> ().ConvisibleTwo=LastDecount.GetComponent<EnnemyDecount> ().Decount [1].GetComponent<ConVisible>();
				player.GetComponent<CheckVisinCone> ().MarkTwo=LastDecount.GetComponent<EnnemyDecount> ().Decount [1].GetComponent<EnnemyMarked>();
				LastDecount.GetComponent<EnnemyDecount> ().Decount [1].GetComponent<EnnnemyPatrolUpgraded>().NormalStart();


			}
				else
				player.GetComponent<CheckVisinCone>().EnnemyInScene [1] = null;


			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [2] != null) {
				player.GetComponent<CheckVisinCone> ().EnnemyInScene [2] = LastDecount.GetComponent<EnnemyDecount> ().Decount [2];
				player.GetComponent<CheckVisinCone> ().Patrolthree=LastDecount.GetComponent<EnnemyDecount> ().Decount [2].GetComponent<EnnnemyPatrolUpgraded>();
				player.GetComponent<CheckVisinCone> ().ConvisibleThree=LastDecount.GetComponent<EnnemyDecount> ().Decount [2].GetComponent<ConVisible>();
				player.GetComponent<CheckVisinCone> ().MarkThree=LastDecount.GetComponent<EnnemyDecount> ().Decount [2].GetComponent<EnnemyMarked>();
				LastDecount.GetComponent<EnnemyDecount> ().Decount [2].GetComponent<EnnnemyPatrolUpgraded>().NormalStart();


			}
				else
				player.GetComponent<CheckVisinCone>().EnnemyInScene [2] = null;


			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [3] != null) {
				player.GetComponent<CheckVisinCone> ().EnnemyInScene [3] = LastDecount.GetComponent<EnnemyDecount> ().Decount [3];
				player.GetComponent<CheckVisinCone> ().PatrolFour=LastDecount.GetComponent<EnnemyDecount> ().Decount [3].GetComponent<EnnnemyPatrolUpgraded>();
				player.GetComponent<CheckVisinCone> ().ConvisibleFour=LastDecount.GetComponent<EnnemyDecount> ().Decount [3].GetComponent<ConVisible>();
				player.GetComponent<CheckVisinCone> ().MarkFour=LastDecount.GetComponent<EnnemyDecount> ().Decount [3].GetComponent<EnnemyMarked>();
				LastDecount.GetComponent<EnnemyDecount> ().Decount [3].GetComponent<EnnnemyPatrolUpgraded>().NormalStart();


			}
				else
				player.GetComponent<CheckVisinCone>().EnnemyInScene [3] = null;


			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [4] != null) {
				player.GetComponent<CheckVisinCone> ().EnnemyInScene [4] = LastDecount.GetComponent<EnnemyDecount> ().Decount [4];
				player.GetComponent<CheckVisinCone> ().PatrolFive=LastDecount.GetComponent<EnnemyDecount> ().Decount [4].GetComponent<EnnnemyPatrolUpgraded>();
				player.GetComponent<CheckVisinCone> ().ConvisibleFive=LastDecount.GetComponent<EnnemyDecount> ().Decount [4].GetComponent<ConVisible>();
				player.GetComponent<CheckVisinCone> ().MarkFive=LastDecount.GetComponent<EnnemyDecount> ().Decount [4].GetComponent<EnnemyMarked>();
				LastDecount.GetComponent<EnnemyDecount> ().Decount [4].GetComponent<EnnnemyPatrolUpgraded>().NormalStart();

			}
				else
				player.GetComponent<CheckVisinCone>().EnnemyInScene [4] = null;


			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [5] != null) {
				player.GetComponent<CheckVisinCone> ().EnnemyInScene [5] = LastDecount.GetComponent<EnnemyDecount> ().Decount [5];
				player.GetComponent<CheckVisinCone> ().PatrolSix=LastDecount.GetComponent<EnnemyDecount> ().Decount [5].GetComponent<EnnnemyPatrolUpgraded>();
				player.GetComponent<CheckVisinCone> ().ConvisibleSix=LastDecount.GetComponent<EnnemyDecount> ().Decount [5].GetComponent<ConVisible>();
				player.GetComponent<CheckVisinCone> ().MarkSix=LastDecount.GetComponent<EnnemyDecount> ().Decount [5].GetComponent<EnnemyMarked>();
				LastDecount.GetComponent<EnnemyDecount> ().Decount [5].GetComponent<EnnnemyPatrolUpgraded>().NormalStart();


			}
				else
				player.GetComponent<CheckVisinCone>().EnnemyInScene [5] = null;


			if (TrueLastDecount.GetComponent<EnnemyDecount> ().Decount [0] != null) 
				TrueLastDecount.GetComponent<EnnemyDecount> ().Decount [0].GetComponent<EnnnemyPatrolUpgraded>().DestroyObj();
			

			if (TrueLastDecount.GetComponent<EnnemyDecount> ().Decount [1] != null) 
				TrueLastDecount.GetComponent<EnnemyDecount> ().Decount [1].GetComponent<EnnnemyPatrolUpgraded>().DestroyObj();
			if (TrueLastDecount.GetComponent<EnnemyDecount> ().Decount [2] != null) 
				TrueLastDecount.GetComponent<EnnemyDecount> ().Decount [2].GetComponent<EnnnemyPatrolUpgraded>().DestroyObj();
			if (TrueLastDecount.GetComponent<EnnemyDecount> ().Decount [3] != null) 
				TrueLastDecount.GetComponent<EnnemyDecount> ().Decount [3].GetComponent<EnnnemyPatrolUpgraded>().DestroyObj();
			if (TrueLastDecount.GetComponent<EnnemyDecount> ().Decount [4] != null) 
				TrueLastDecount.GetComponent<EnnemyDecount> ().Decount [4].GetComponent<EnnnemyPatrolUpgraded>().DestroyObj();
			if (TrueLastDecount.GetComponent<EnnemyDecount> ().Decount [5] != null) 
				TrueLastDecount.GetComponent<EnnemyDecount> ().Decount [5].GetComponent<EnnnemyPatrolUpgraded>().DestroyObj();
			if (TrueLastDecount.GetComponent<EnnemyDecount> ().Decount [6] != null) 
				TrueLastDecount.GetComponent<EnnemyDecount> ().Decount [6].GetComponent<EnnnemyPatrolUpgraded>().DestroyObj();


			LastEnnemi.SetActive (false);

		}

	}
}
