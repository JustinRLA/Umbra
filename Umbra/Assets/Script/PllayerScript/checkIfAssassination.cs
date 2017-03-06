using UnityEngine;
using System.Collections;

public class checkIfAssassination : MonoBehaviour {
	
	public GameObject AssassinFeedback;
	public bool canAssassinate;
	public GameObject ActualEnnemy;
	public GameObject OtherEnnemy;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if(canAssassinate==true)
		{
			AssassinFeedback.SetActive (true);
			if (Input.GetKeyDown (KeyCode.E) && ActualEnnemy.GetComponent<EnnnemyPatrolUpgraded>().Alert==false)
			{
				Assassination();
			}
		}
		else
			AssassinFeedback.SetActive (false);
		

	}
	void OnTriggerEnter2D (Collider2D col) {

//		else
//			canAssassinate = false;
		

		if (col.tag == "ennemy") {
//			print ("See");
			if (col.GetComponent<EnnnemyPatrolUpgraded> ().Alert == false || col.GetComponent<EnnemyMarked>().isMarked==true)
			{
				canAssassinate = true;
				ActualEnnemy = col.gameObject;
			}
		} 
//		else
//			canAssassinate = false;
	}

	void Assassination()
	{
		print ("I kill you");	
		ActualEnnemy.GetComponent<EnnnemyPatrolUpgraded> ().Alert = false;
		ActualEnnemy.GetComponent<EnnnemyPatrolUpgraded> ().isdead = true;
		ActualEnnemy.GetComponent<EnnnemyPatrolUpgraded> ().enabled = false;
		ActualEnnemy.GetComponent<DeadScript> ().enabled = true;
		ActualEnnemy.GetComponent<DeadScript> ().EnnemyDeath();
		AssassinFeedback.SetActive (false);
		canAssassinate = false;


	}

	void OnTriggerExit2D (Collider2D col) {
		if(col.tag=="ennemy")
		{
			canAssassinate=false;

		}
	
		}

		}
