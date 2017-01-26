using UnityEngine;
using System.Collections;

public class flipIfNecessary : MonoBehaviour {
	EnnnemyPatrol myEnnemyPatrol;
	public GameObject MyTarget;
	public GameObject EnnemyBase;
	public bool Cansee;

	// Use this for initialization
	void Start () {
		myEnnemyPatrol = EnnemyBase.GetComponent<EnnnemyPatrol> ();


	}
	
	// Update is called once per frame


	void Update () {
		MyTarget = myEnnemyPatrol.CurrentNavPointGo;
	//	if(Collision2D.Equals
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		print (MyTarget);
		print ("SawSometging");

		if (col.gameObject == MyTarget)
			Cansee = true;
	//	else
	//		Cansee = false;
	}
//	void OnTriggerStay2D(Collider2D col)
//	{
//		if (col.gameObject == MyTarget)
//			Cansee = true;
//		else
//			Cansee = false;
//	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject == MyTarget)
			Cansee = false;

	}



}
