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
	public GameObject YellowBCGTrap;
	public GameObject YellowBCGmark;
	public GameObject YellowBCGSolid;
	public GameObject YellowBCGShadow;
	public GameObject YellowBCGGrap;
	public GameObject YellowBCGLure;


	public GameObject FeedBackImage;
	public GameObject UIMode;
	public GameObject playerMy;
	// Use this for initialization
	void Start () {
		RuneManager=GameObject.Find("RuneManager");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E) && canChange == true && playerMy.GetComponent<PlatformerCharacter2D> ().canChangeRune == true)
		{
			UIMode.SetActive (true);

		playerMy.GetComponent<PlatformerCharacter2D> ().enabled = false;
			playerMy.GetComponent<Platformer2DUserControl> ().enabled = false;
			ReceiveInfo ();
			Cursor.visible=true;
		}
		if (canChange == true && playerMy.GetComponent<PlatformerCharacter2D> ().canChangeRune == true)
			FeedBackImage.GetComponent<SpriteRenderer> ().enabled = true;
	}
	public void SendInfo()
	{
		RuneManager.GetComponent<RuneManagerScript> ().enabled = true;

		RuneManager.GetComponent<RuneManagerScript> ().DefFune= myTempoDefRune;
		RuneManager.GetComponent<RuneManagerScript> ().OffenseRune=myTempoOffRune ;
	 RuneManager.GetComponent<RuneManagerScript> ().TacticRune=myTempoTacticRune ;
		playerMy.GetComponent<PlatformerCharacter2D> ().enabled = true;
		playerMy.GetComponent<Platformer2DUserControl> ().enabled = true;
		playerMy.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;

		UIMode.SetActive (false);
		Cursor.visible=false;
	}

	public void ReceiveInfo()
	{
		myTempoDefRune = RuneManager.GetComponent<RuneManagerScript> ().DefFune ;
		myTempoOffRune=RuneManager.GetComponent<RuneManagerScript> ().OffenseRune ;
		myTempoTacticRune= RuneManager.GetComponent<RuneManagerScript> ().TacticRune ;

		if (myTempoDefRune == 1)
		{
			LureRune.SetActive (false);
			YellowBCGLure.SetActive(false);
			ShadowIns.SetActive (true);
			YellowBCGShadow.SetActive(true);


		}
		if (myTempoDefRune == 2)
			{
			LureRune.SetActive (true);
			YellowBCGLure.SetActive(true);

			ShadowIns.SetActive (false);
			YellowBCGShadow.SetActive(false);
			}

		if (myTempoTacticRune == 1)
				{
			SolidRune.SetActive (false);
			YellowBCGSolid.SetActive(false);
			GrapRune.SetActive(true);
			YellowBCGGrap.SetActive(true);


				}
		if(myTempoTacticRune==2)
					{
			SolidRune.SetActive (true);
			YellowBCGSolid.SetActive(true);

			GrapRune.SetActive(false);
			YellowBCGGrap.SetActive(false);
					}


		if (myTempoOffRune == 1)
						{
			MarkLure.SetActive (false);
			YellowBCGmark.SetActive(false);

			TrapRune.SetActive (true);
			YellowBCGTrap.SetActive(true);

						}
			if (myTempoOffRune == 2)
							{
			MarkLure.SetActive (true);
			YellowBCGmark.SetActive(true);


			TrapRune.SetActive (false);
			YellowBCGTrap.SetActive(false);
							}
		RuneManager.GetComponent<RuneManagerScript> ().enabled = false;
	
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
		FeedBackImage.GetComponent<SpriteRenderer> ().enabled = false;


	}

}
