using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
	public Sprite SpawnerNormal;
	public Sprite SpawnerOver;

	public GameObject LureRuneGlow;
	public GameObject TrapRuneGlow;
	public GameObject SolidRuneGlow;
	public GameObject GrapRuneGlow;
	public GameObject MarkLureGlow;
	public GameObject ShadowInsGlow;

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
		playerMy=GameObject.Find("2DCharacter(Clone)");
		RuneManager=GameObject.Find("RuneManager");
		FeedBackImage = GameObject.Find ("feedbackRuneChange");

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
		UIMode=GameObject.Find("RuneChangeUI");

		playerMy=GameObject.Find("2DCharacter(Clone)");
		RuneManager=GameObject.Find("RuneManager");
		FeedBackImage = GameObject.Find ("feedbackRuneChange");

		RuneManager.GetComponent<RuneManagerScript> ().enabled = true;
		PlayerPrefs.SetInt ("RuneOffense", myTempoOffRune);
		RuneManager.GetComponent<RuneManagerScript> ().DefFune= myTempoDefRune;
		PlayerPrefs.SetInt ("RuneDefense", myTempoDefRune);
		PlayerPrefs.SetInt ("RuneTactic", myTempoTacticRune);

		RuneManager.GetComponent<RuneManagerScript> ().OffenseRune=myTempoOffRune ;
	 RuneManager.GetComponent<RuneManagerScript> ().TacticRune=myTempoTacticRune ;
		playerMy.GetComponent<PlatformerCharacter2D> ().enabled = true;
		playerMy.GetComponent<Platformer2DUserControl> ().enabled = true;
		playerMy.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		RuneManager.GetComponent<RuneManagerScript> ().RuneSetting() ;
		print ("Shut");


		UIMode.SetActive (false);
		Cursor.visible=false;
	}

	public void ReceiveInfo()
	{

		YellowBCGGrap= GameObject.Find ("bcg_PlateGrap");
		YellowBCGLure = GameObject.Find ("bcg_PlateLure");
		YellowBCGmark = GameObject.Find ("bcg_PlatMark");
		YellowBCGShadow = GameObject.Find ("bcg_PlateOmbre");
		YellowBCGTrap = GameObject.Find ("bcg_PlatePiege");
		YellowBCGSolid = GameObject.Find ("bcg_PlateSolid");

		LureRune= GameObject.Find ("lureShow");
		TrapRune = GameObject.Find ("trapShow");
		MarkLure = GameObject.Find ("MarkShow");
		ShadowIns = GameObject.Find ("shadowShow");
		GrapRune = GameObject.Find ("grapShow");
		SolidRune = GameObject.Find ("solidShow");


		LureRuneGlow= GameObject.Find ("lurefeed");
		TrapRuneGlow = GameObject.Find ("trapfeed");
		MarkLureGlow = GameObject.Find ("Markfeed");
		ShadowInsGlow = GameObject.Find ("shadowfeed");
		GrapRuneGlow = GameObject.Find ("grapfeed");
		SolidRuneGlow = GameObject.Find ("solidfeed");





		myTempoDefRune = RuneManager.GetComponent<RuneManagerScript> ().DefFune ;
		myTempoOffRune=RuneManager.GetComponent<RuneManagerScript> ().OffenseRune ;
		myTempoTacticRune= RuneManager.GetComponent<RuneManagerScript> ().TacticRune ;

		if (myTempoDefRune == 1)
		{
			PlayerPrefs.SetInt ("RuneDefense", 1);
			LureRuneGlow.GetComponent<Image> ().enabled = false;

			LureRune.GetComponent<Image> ().enabled = false;
			YellowBCGLure.GetComponent<Image> ().enabled = false;
			ShadowInsGlow.GetComponent<Image> ().enabled = true;

			ShadowIns.GetComponent<Image> ().enabled = true;
			YellowBCGShadow.GetComponent<Image> ().enabled = true;


		}
		if (myTempoDefRune == 2)
			{
			PlayerPrefs.SetInt ("RuneDefense", 2);

			LureRune.GetComponent<Image> ().enabled = true;
			YellowBCGLure.GetComponent<Image> ().enabled = true;
			LureRuneGlow.GetComponent<Image> ().enabled = true;
			ShadowInsGlow.GetComponent<Image> ().enabled = false;

			ShadowIns.GetComponent<Image> ().enabled = false;
			YellowBCGShadow.GetComponent<Image> ().enabled = false;
			}

		if (myTempoTacticRune == 1)
				{
			PlayerPrefs.SetInt ("RuneTactic", 1);

			SolidRuneGlow.GetComponent<Image> ().enabled = false;

			SolidRune.GetComponent<Image> ().enabled = false;

			YellowBCGSolid.GetComponent<Image> ().enabled = false;
			GrapRune.GetComponent<Image> ().enabled = true;
			GrapRuneGlow.GetComponent<Image> ().enabled = true;

			YellowBCGGrap.GetComponent<Image> ().enabled = true;


				}
		if(myTempoTacticRune==2)
					{
			PlayerPrefs.SetInt ("RuneTactic", 2);

			SolidRune.GetComponent<Image> ().enabled = true;
			YellowBCGSolid.GetComponent<Image> ().enabled = true;
			SolidRuneGlow.GetComponent<Image> ().enabled = true;
			GrapRuneGlow.GetComponent<Image> ().enabled = false;

			GrapRune.GetComponent<Image> ().enabled = false;
			YellowBCGGrap.GetComponent<Image> ().enabled = false;
					}


		if (myTempoOffRune == 1)
						{
			PlayerPrefs.SetInt ("RuneOffense", 1);

			MarkLure.GetComponent<Image> ().enabled = false;
			YellowBCGmark.GetComponent<Image> ().enabled = false;
			MarkLureGlow.GetComponent<Image> ().enabled = false;
			TrapRuneGlow.GetComponent<Image> ().enabled = true;

			TrapRune.GetComponent<Image> ().enabled = true;
			YellowBCGTrap.GetComponent<Image> ().enabled = true;

						}
			if (myTempoOffRune == 2)
							{
			PlayerPrefs.SetInt ("RuneOffense", 2);

			MarkLure.GetComponent<Image> ().enabled = true;
			YellowBCGmark.GetComponent<Image> ().enabled = true;
			MarkLureGlow.GetComponent<Image> ().enabled = true;

			TrapRuneGlow.GetComponent<Image> ().enabled = false;

			TrapRune.GetComponent<Image> ().enabled = false;
			YellowBCGTrap.GetComponent<Image> ().enabled = false;
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
			GetComponent<SpriteRenderer> ().sprite = SpawnerOver;
			playerMy = col.gameObject;
			canChange = true;
		}
	}
	void OnTriggerExit2D(Collider2D col)
	{
		if (col.tag == "Player") {
			canChange = false;
			FeedBackImage.GetComponent<SpriteRenderer> ().enabled = false;
			GetComponent<SpriteRenderer> ().sprite = SpawnerNormal;

		}

	}

}
