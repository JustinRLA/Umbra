using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoomSettle : MonoBehaviour {
	public GameObject LastEnnemi;
	public GameObject NextEnnemy;
	public GameObject LastDecount;
	public GameObject nextDecount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D col) {
		if(col.tag=="Player")
		{
			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [0] != null)
				nextDecount.GetComponent<EnnemyDecount> ().Decount [0] = LastDecount.GetComponent<EnnemyDecount> ().Decount [0];
			else
				nextDecount.GetComponent<EnnemyDecount> ().Decount [0] = null;

			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [1] != null)
				nextDecount.GetComponent<EnnemyDecount> ().Decount [1] = LastDecount.GetComponent<EnnemyDecount> ().Decount [1];
			else
				nextDecount.GetComponent<EnnemyDecount> ().Decount [1] = null;


			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [2] != null)
				nextDecount.GetComponent<EnnemyDecount> ().Decount [2] = LastDecount.GetComponent<EnnemyDecount> ().Decount [2];
			else
				nextDecount.GetComponent<EnnemyDecount> ().Decount [2] = null;


			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [3] != null)
				nextDecount.GetComponent<EnnemyDecount> ().Decount [3] = LastDecount.GetComponent<EnnemyDecount> ().Decount [3];
			else
				nextDecount.GetComponent<EnnemyDecount> ().Decount [3] = null;


			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [4] != null)
				nextDecount.GetComponent<EnnemyDecount> ().Decount [4] = LastDecount.GetComponent<EnnemyDecount> ().Decount [0];
			else
				nextDecount.GetComponent<EnnemyDecount> ().Decount [4] = null;


			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [0] != null)
				nextDecount.GetComponent<EnnemyDecount> ().Decount [0] = LastDecount.GetComponent<EnnemyDecount> ().Decount [4];
			else
				nextDecount.GetComponent<EnnemyDecount> ().Decount [4] = null;


			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [5] != null)
				nextDecount.GetComponent<EnnemyDecount> ().Decount [5] = LastDecount.GetComponent<EnnemyDecount> ().Decount [5];
			else
				nextDecount.GetComponent<EnnemyDecount> ().Decount [5] = null;


			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [6] != null)
				nextDecount.GetComponent<EnnemyDecount> ().Decount [6] = LastDecount.GetComponent<EnnemyDecount> ().Decount [6];
			else
				nextDecount.GetComponent<EnnemyDecount> ().Decount [6] = null;


			if (LastDecount.GetComponent<EnnemyDecount> ().Decount [7] != null)
				nextDecount.GetComponent<EnnemyDecount> ().Decount [7] = LastDecount.GetComponent<EnnemyDecount> ().Decount [7];
			else
				nextDecount.GetComponent<EnnemyDecount> ().Decount [7] = null;
			

			LastEnnemi.SetActive (false);
			NextEnnemy.SetActive (true);

		}

	}
}
