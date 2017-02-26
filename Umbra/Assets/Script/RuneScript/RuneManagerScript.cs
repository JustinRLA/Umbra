using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneManagerScript : MonoBehaviour 
{
	ShadowInstantiate myShadowInstantiate;
	BlindEnnemyRune myBlindEnnemyRune;
	MarkEnnemy myMarkEnnemy;
	SolidifcationEnabled mySolidicationEnabled;
	LineRendererTest myLineRenderer;
	EnableTrapMode myenabledTrapMode;
	public bool RuneModeEnabled;
	public float timerTactic; 
	public float timerOffense;
	public float timerDef;
	public GameObject myRuneSetter;
	public bool IsTesting;
	public float ActualDef;
	public float ActualOffense;
	public float ActualTactic;
	public bool RuneActivated;
	public GameObject myCam;
	public GameObject myCamTwo;
	public GameObject myCamThree;
	public GameObject myCamFour;
	Animator animCamOne;
	Animator animCamTwo;
	Animator animCamThree;
	Animator animCamFour;
	public GameObject textleure;
	public GameObject textaccrochage;
	public GameObject texttrappe;
	public GameObject textSolid;
	public GameObject textMark;
	public GameObject textOmbre;
	public GameObject ImageRuneOmbre;
	public GameObject ImageRuneAccrochage;
	public GameObject ImageRunePiege;
	public GameObject ImageRuneSolidification;
	public GameObject ImageRuneMarquage;
	public GameObject ImageRuneLeurre;
	PlatformerCharacter2D myPlatchar;
	Platformer2DUserControl myPlatUserControl;



	LureScript myLureScript;
	public GameObject ThePlayer;
	PlatformerCharacter2D myPlatformCharacter;

	public int DefFune;
	public int OffenseRune;
	public int TacticRune;
	public int TypeRuneUsed;
	// Use this for initialization
	void Start () {
		myPlatUserControl = ThePlayer.GetComponent<Platformer2DUserControl>();
		myPlatformCharacter= ThePlayer.GetComponent<PlatformerCharacter2D>();
		textaccrochage=GameObject.Find ("accorchageText");
		textOmbre=GameObject.Find ("ombreText");
		textSolid=GameObject.Find ("solidText");
		texttrappe=GameObject.Find ("trapText");
		textMark=GameObject.Find ("markText");
		textleure=GameObject.Find ("leurreText");

		ImageRuneLeurre = GameObject.Find ("LeureImage");
		ImageRuneAccrochage = GameObject.Find ("AccrochageImage");
		ImageRuneMarquage = GameObject.Find ("MaquageRuneImage");
		ImageRuneSolidification = GameObject.Find ("solideImage");
		ImageRuneOmbre = GameObject.Find ("OmbreRuneImage");
		ImageRunePiege = GameObject.Find ("trapImage");

		animCamOne=myCam.GetComponent<Animator>();
		animCamTwo=myCamTwo.GetComponent<Animator>();
		animCamThree=myCamThree.GetComponent<Animator>();
		animCamFour=myCamFour.GetComponent<Animator>();

		//myCam.GetComponent<Animator> ().Stop ();
		if(IsTesting==false)
		{
		myRuneSetter = GameObject.Find ("RuneSetter");
		DefFune = myRuneSetter.GetComponent<SetRune> ().TemporaryDefRune;
		OffenseRune=myRuneSetter.GetComponent<SetRune> ().TemporaryOffenseRune;
		TacticRune=myRuneSetter.GetComponent<SetRune> ().TemporaryTacticRune;
		}
		myLineRenderer = GetComponent<LineRendererTest> ();
		mySolidicationEnabled = GetComponent<SolidifcationEnabled> ();
		myMarkEnnemy = GetComponent<MarkEnnemy> ();
		myShadowInstantiate = GetComponent<ShadowInstantiate> ();
		Cursor.visible = false;
		myBlindEnnemyRune = GetComponent<BlindEnnemyRune> ();
		myLureScript=GetComponent<LureScript>();
		myPlatformCharacter = ThePlayer.GetComponent<PlatformerCharacter2D> ();
		myenabledTrapMode = GetComponent<EnableTrapMode> ();

	}
	
	// Update is called once per frame
	void Update () {
		if(OffenseRune==1)
		{
			ImageRunePiege.SetActive(true);
			ImageRuneMarquage.SetActive(false);
			texttrappe.SetActive(true);
			textMark.SetActive(false);
		}
		if(OffenseRune==2)
		{
			ImageRunePiege.SetActive(false);
			ImageRuneMarquage.SetActive(true);
			texttrappe.SetActive(false);
			textMark.SetActive(true);
		}
		if(DefFune==1)
		{
			ImageRuneLeurre.SetActive(false);
			ImageRuneOmbre.SetActive(true);
			textleure.SetActive(false);
			textOmbre.SetActive(true);
		}
		if(DefFune==2)
		{
			ImageRuneLeurre.SetActive(true);
			ImageRuneOmbre.SetActive(false);

			textleure.SetActive(true);
			textOmbre.SetActive(false);
		}
		if(TacticRune==1)
		{
			ImageRuneSolidification.SetActive (false);
			ImageRuneAccrochage.SetActive(true);
			textSolid.SetActive(false);
			textaccrochage.SetActive(true);
		}
		if(TacticRune==2)
		{
			ImageRuneSolidification.SetActive (true);
			ImageRuneAccrochage.SetActive(false);
			textSolid.SetActive(true);
			textaccrochage.SetActive(false);
		}

		if(timerDef<ActualDef)
		{
			timerDef += Time.deltaTime;
		}
		if(timerTactic<ActualTactic)
		{
			timerTactic += Time.deltaTime;
		}
		if(timerOffense<ActualOffense)
		{
			timerOffense += Time.deltaTime;
		}


		if ( RuneModeEnabled == false)
		{
			
			animCamOne.speed = 2;
			animCamTwo.speed = 2;
			animCamThree.speed = 2;
			animCamFour.speed = 2;


			myCam.GetComponent<BloomOptimized>().enabled=false;
			//myCamFour.GetComponent<Grayscale>().enabled=false;
			
			Time.timeScale = 1;
		
			animCamOne.SetBool ("Blue",false);
			animCamTwo.SetBool ("Blue",false);
			animCamFour.SetBool ("Blue",false);
			animCamThree.SetBool ("Blue",false);


		}
		//if (Input.GetKeyDown (KeyCode.E) && RuneModeEnabled == false)
			//myCam.GetComponent<Animator> ().speed = 10.0f;

	//	if (Input.GetKeyDown (KeyCode.E) && RuneModeEnabled == true)
		//	myCam.GetComponent<Animator> (). = -10.0f;



	//	myCam.GetComponent<Animator> ().SetBool ("Blue",true);

		if (Input.GetKeyDown (KeyCode.Q) && RuneModeEnabled==false && myPlatformCharacter.canRune==true)
		{
			animCamOne.SetBool ("Blue",true);
			animCamTwo.SetBool ("Blue",true);
			animCamFour.SetBool ("Blue",true);
			animCamThree.SetBool ("Blue",true);

			RuneModeEnabled = true;
			myCam.GetComponent<BloomOptimized>().enabled=true;
			//myCam.GetComponent<Grayscale>().enabled=true;

		}
		if (Input.GetKeyDown (KeyCode.Escape) && RuneModeEnabled==true)
		{
			RuneModeEnabled = false;
		myCam.GetComponent<BloomOptimized>().enabled=false;
		myCam.GetComponent<Grayscale>().enabled=false;
		
		}
		
		if (RuneModeEnabled == true) { 
			ThePlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 0;
			ThePlayer.GetComponent<PlatformerCharacter2D> ().enabled = false;
			ThePlayer.GetComponent<Platformer2DUserControl> ().enabled = false;

			animCamOne.speed = 13;
			animCamTwo.speed = 13;
			animCamThree.speed = 13;
			animCamFour.speed = 13;
			
			

		//	Time.timeScale = 1;
		

			Time.timeScale = 0.1f;
			if (Input.GetKeyDown (KeyCode.Alpha2)) {

				if (DefFune == 1 && timerDef >= ActualDef && RuneActivated==false) {
					// Rune D'ombre
					myShadowInstantiate.enabled = true;
					myShadowInstantiate.InstantiateTheShadow ();
				}
				
				if (DefFune == 2 && timerDef >= ActualDef && RuneActivated==false) {
					// Rune de Lure
					myLureScript.enabled = true;
					myLureScript.StartLure ();
					animCamOne.SetBool ("Blue",false);
					animCamTwo.SetBool ("Blue",false);
					animCamFour.SetBool ("Blue",false);
					animCamThree.SetBool ("Blue",false);

					animCamOne.SetBool ("MegaBlue",true);
					animCamTwo.SetBool ("MegaBlue",true);
					animCamFour.SetBool ("MegaBlue",true);
					animCamThree.SetBool ("MegaBlue",true);

				}

			}
//
			if (Input.GetKeyDown (KeyCode.Alpha3)) {
				// rune d'accrochage
				if (TacticRune == 1 && timerTactic >= ActualTactic && RuneActivated==false) {
					myLineRenderer.enabled = true;
					myLineRenderer.IsActivated ();
				}
				if (TacticRune == 2 && timerTactic >= ActualTactic && RuneActivated==false) {
					// rune solidification Ombre
					mySolidicationEnabled.enabled = true;
					mySolidicationEnabled.SolidificationStart ();
				}


			}
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				// Rune de piege
				if (OffenseRune == 1 && timerOffense >= ActualOffense && RuneActivated==false) {
					myenabledTrapMode.enabled = true;
					myenabledTrapMode.EnabledTrapMode ();
				}	
				if (OffenseRune == 2 && timerOffense >= ActualOffense && RuneActivated==false) {
					// rune de marquage
					print("Blue");
					myMarkEnnemy.enabled = true;
					myMarkEnnemy.EnemyMarkedStart ();

				}	
			}
//
//
//
//
//
		}

}

}