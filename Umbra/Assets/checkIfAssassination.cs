using UnityEngine;
using System.Collections;

public class checkIfAssassination : MonoBehaviour {
	
	public bool canAssassinate;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "ennemy") {
			if (col.GetComponent<EnnemyAlert> ().Alert == false)
				canAssassinate = true;
		} else
			canAssassinate = false;
	}
	void OnTriggerExit2D (Collider2D col) {
		if(col.tag=="ennemy")
		{
			canAssassinate=false;
		}

		}
}