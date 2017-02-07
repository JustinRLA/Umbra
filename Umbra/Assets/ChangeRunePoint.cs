using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRunePoint : MonoBehaviour {
	public bool canChange;
	public int myTempoDefRune;
	public int myTempoOffRune;
	public int myTempoTacticRune;
	public GameObject RuneManager;
	public GameObject LureRune;
	public GameObject TrapRune;
	public GameObject SolidRune;
	public GameObject GrapRune;
	public GameObject MarkLure;
	public GameObject ShadowIns;


	public GameObject FeedBackImage;
	public GameObject UIMode;
	public GameObject playerMy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.B) && canChange == true)
		{
			UIMode.SetActive (true);
		playerMy.GetComponent<PlatformerCharacter2D> ().enabled = false;
			playerMy.GetComponent<Platformer2DUserControl> ().enabled = false;
			ReceiveInfo ();

		}
	}
	public void SendInfo()
	{
		RuneManager.GetComponent<RuneManagerScript> ().DefFune= myTempoDefRune;
		RuneManager.GetComponent<RuneManagerScript> ().OffenseRune=myTempoOffRune ;
	 RuneManager.GetComponent<RuneManagerScript> ().TacticRune=myTempoTacticRune ;

	}

	public void ReceiveInfo()
	{
		myTempoDefRune = RuneManager.GetComponent<RuneManagerScript> ().DefFune ;
		myTempoOffRune=RuneManager.GetComponent<RuneManagerScript> ().OffenseRune ;
		myTempoTacticRune= RuneManager.GetComponent<RuneManagerScript> ().TacticRune ;

		if (myTempoDefRune == 1)
			LureRune.SetActive (false);
		if (myTempoDefRune == 2)
			ShadowIns.SetActive (false);

		if (myTempoTacticRune == 1)
			SolidRune.SetActive (false);
		if(myTempoTacticRune==2)
			GrapRune.SetActive(false);


		if (myTempoOffRune == 1)
			MarkLure.SetActive (false);
		if (myTempoOffRune == 2)
			TrapRune.SetActive (false);
		
			
		


	}

	public void MySetOffenseRuneMark()
	{
		myTempoOffRune = 2;
	}
	public void MySetOffenseRuneTrap()
	{
		myTempoOffRune = 1;
	}
	public void MySetDefRuneShadowCreate()
	{
		myTempoDefRune = 1;
	}
	public void MySetDefRuneLure()
	{
		myTempoDefRune = 2;
	}
	public void MysetTacticAccrochage()
	{
		myTempoTacticRune = 1;
	}
	public void MysetTacticSolid()
	{
		myTempoTacticRune = 2;
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player")
		{
			playerMy = col.gameObject;
			canChange = true;
		}
	}
	void OnTriggerExit2D(Collider2D col)
	{
		if (col.tag == "Player")
			canChange = false;
	}

}
