using UnityEngine;
using System.Collections;

public class checkIfAssassination : MonoBehaviour {
	
	public GameObject AssassinFeedback;
	public bool canAssassinate;
	public GameObject ActualEnnemy;


	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if(canAssassinate==true)
		{
			AssassinFeedback.SetActive (true);
			if (Input.GetKeyDown (KeyCode.E))
			{
				print ("I kill you");	
				ActualEnnemy.GetComponent<EnnnemyPatrol> ().enabled = false;
				ActualEnnemy.GetComponent<DeadScript> ().enabled = true;
				ActualEnnemy.GetComponent<DeadScript> ().EnnemyDeath();
				AssassinFeedback.SetActive (false);


			}
		}
		else
			AssassinFeedback.SetActive (false);
		

	}
	void OnTriggerEnter2D (Collider2D col) {

		if (col.tag == "ennemy") {
			print ("See");
			if (col.GetComponent<EnnnemyPatrol> ().Alert == false)
			{
				canAssassinate = true;
				ActualEnnemy = col.gameObject;
			}
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