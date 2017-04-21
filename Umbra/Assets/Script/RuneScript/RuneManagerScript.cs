using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RuneManagerScript : MonoBehaviour 
{
	public GameObject DefTimer;
	public GameObject OffTimer;
	public GameObject TacticTimer;
	bool canSwitchMode;
	ShadowInstantiate myShadowInstantiate;
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

	public GameObject ImageRuneOmbreFull;
	public GameObject ImageRuneAccrochageFull;
	public GameObject ImageRunePiegeFull;
	public GameObject ImageRuneSolidificationFull;
	public GameObject ImageRuneMarquageFull;
	public GameObject ImageRuneLeurreFull;

	PlatformerCharacter2D myPlatchar;
	Platformer2DUserControl myPlatUserControl;
    private Animator m_Anim;



    LureScript myLureScript;
	public GameObject ThePlayer;
	PlatformerCharacter2D myPlatformCharacter;

	public int DefFune;
	public int OffenseRune;
	public int TacticRune;
	public int TypeRuneUsed;
	// Use this for initialization


	void Start () {
		
		ThePlayer=GameObject.Find("2DCharacter(Clone)");
		myPlatUserControl = ThePlayer.GetComponent<Platformer2DUserControl>();
		myPlatformCharacter = ThePlayer.GetComponent<PlatformerCharacter2D>();
        m_Anim = ThePlayer.GetComponent<Animator>();
        textaccrochage =GameObject.Find ("accorchageText");
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

		ImageRuneLeurreFull = GameObject.Find ("LeureImageFull");
		ImageRuneAccrochageFull = GameObject.Find ("AccrochageImageFull");
		ImageRuneMarquageFull = GameObject.Find ("MaquageRuneImageFull");
		ImageRuneSolidificationFull = GameObject.Find ("solideImageFull");
		ImageRuneOmbreFull = GameObject.Find ("OmbreRuneImageFull");
		ImageRunePiegeFull = GameObject.Find ("trapImageFull");


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
		myLureScript=GetComponent<LureScript>();
		myPlatformCharacter = ThePlayer.GetComponent<PlatformerCharacter2D> ();
		myenabledTrapMode = GetComponent<EnableTrapMode> ();

	}

	public void RuneSetting()
	{
		if(OffenseRune==1)
		{
			ImageRunePiege.SetActive(true);
			ImageRunePiegeFull.SetActive(true);
			ImageRuneMarquageFull.SetActive(false);

			ImageRuneMarquage.SetActive(false);
			texttrappe.SetActive(true);
			textMark.SetActive(false);
		}
		if(OffenseRune==2)
		{
			ImageRunePiegeFull.SetActive(false);

			ImageRuneMarquageFull.SetActive(true);

			ImageRunePiege.SetActive(false);

			ImageRuneMarquage.SetActive(true);
			texttrappe.SetActive(false);
			textMark.SetActive(true);
		}
		if(OffenseRune==0)
		{
			ImageRunePiegeFull.SetActive(false);
			ImageRuneMarquageFull.SetActive(false);
			ImageRunePiege.SetActive(false);
			ImageRuneMarquage.SetActive(false);
			texttrappe.SetActive(false);
			textMark.SetActive(false);
		}

		if(DefFune==1)
		{
			ImageRuneLeurre.SetActive(false);
			ImageRuneOmbre.SetActive(true);

			ImageRuneLeurreFull.SetActive(false);
			ImageRuneOmbreFull.SetActive(true);

			textleure.SetActive(false);
			textOmbre.SetActive(true);
		}
		if(DefFune==2)
		{
			ImageRuneLeurreFull.SetActive(true);
			ImageRuneOmbreFull.SetActive(false);
			ImageRuneLeurre.SetActive(true);
			ImageRuneOmbre.SetActive(false);

			textleure.SetActive(true);
			textOmbre.SetActive(false);
		}
		if(DefFune==0)
		{

			ImageRuneLeurreFull.SetActive(false);
			ImageRuneOmbreFull.SetActive(false);

			ImageRuneLeurre.SetActive(false);
			ImageRuneOmbre.SetActive(false);

			textleure.SetActive(false);
			textOmbre.SetActive(false);
		}
		if(TacticRune==0)
		{			
			ImageRuneSolidificationFull.SetActive (false);
			ImageRuneAccrochageFull.SetActive(false);


			ImageRuneSolidification.SetActive (false);
			ImageRuneAccrochage.SetActive(false);
			textSolid.SetActive(false);
			textaccrochage.SetActive(false);
		}
		if(TacticRune==1)
		{
			ImageRuneSolidificationFull.SetActive (false);
			ImageRuneAccrochageFull.SetActive(true);
			ImageRuneSolidification.SetActive (false);
			ImageRuneAccrochage.SetActive(true);
			textSolid.SetActive(false);
			textaccrochage.SetActive(true);
		}
		if(TacticRune==2)
		{
			ImageRuneSolidificationFull.SetActive (true);
			ImageRuneAccrochageFull.SetActive(false);
			ImageRuneSolidification.SetActive (true);
			ImageRuneAccrochage.SetActive(false);
			textSolid.SetActive(true);
			textaccrochage.SetActive(false);
		}

		ImageRuneLeurreFull.GetComponent<Image> ().enabled = false;
		ImageRuneOmbreFull.GetComponent<Image> ().enabled = false;
		ImageRuneSolidificationFull.GetComponent<Image> ().enabled = false;
		ImageRuneAccrochageFull.GetComponent<Image> ().enabled = false;
		ImageRunePiegeFull.GetComponent<Image> ().enabled = false;
		ImageRuneMarquageFull.GetComponent<Image> ().enabled = false;

	}
	// Update is called once per frame
	void Update () {
		

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
		texttrappe.GetComponent<Text> ().enabled = false;
			textaccrochage.GetComponent<Text> ().enabled = false;
			textleure.GetComponent<Text> ().enabled = false;
			textSolid.GetComponent<Text> ().enabled = false;
			textMark.GetComponent<Text> ().enabled = false;
			textOmbre.GetComponent<Text> ().enabled = false;

			animCamOne.speed = 2;
			animCamTwo.speed = 2;
			animCamThree.speed = 2;
			animCamFour.speed = 2;


			myCam.GetComponent<BloomOptimized>().enabled=false;
			//myCamFour.GetComponent<Grayscale>().enabled=false;
			
		
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
		if (Input.GetMouseButtonUp (1))
			canSwitchMode = true;
			
			if (Input.GetMouseButtonDown(1) && RuneModeEnabled==false && myPlatformCharacter.canRune==true && canSwitchMode==true)
		{ 
			canSwitchMode = false;
			
			animCamOne.SetBool ("Blue",true);
			animCamTwo.SetBool ("Blue",true);
			animCamFour.SetBool ("Blue",true);
			animCamThree.SetBool ("Blue",true);
			Time.timeScale = 0.1f;
			AkSoundEngine.PostEvent ("PC_Action_slowMo", gameObject);

			RuneModeEnabled = true;
			myCam.GetComponent<BloomOptimized>().enabled=true;
			//myCam.GetComponent<Grayscale>().enabled=true;

		}
			if (Input.GetMouseButtonDown(1) && RuneModeEnabled==true && canSwitchMode==true)
		{
			canSwitchMode = false;

			Time.timeScale = 1;
			ImageRuneLeurreFull.GetComponent<Image> ().enabled = false;
			ImageRuneOmbreFull.GetComponent<Image> ().enabled = false;
			ImageRuneSolidificationFull.GetComponent<Image> ().enabled = false;
			ImageRuneAccrochageFull.GetComponent<Image> ().enabled = false;
			ImageRunePiegeFull.GetComponent<Image> ().enabled = false;
			ImageRuneMarquageFull.GetComponent<Image> ().enabled = false;

			RuneModeEnabled = false;
		myCam.GetComponent<BloomOptimized>().enabled=false;
		myCam.GetComponent<Grayscale>().enabled=false;
			ThePlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
			ThePlayer.GetComponent<PlatformerCharacter2D> ().enabled = true;
			myPlatUserControl.enabled = true;

		
		}
		
		if (RuneModeEnabled == true) { 
			ThePlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 0;
			ThePlayer.GetComponent<PlatformerCharacter2D> ().enabled = false;
			myPlatUserControl.enabled = false;

			animCamOne.speed = 13;
			animCamTwo.speed = 13;
			animCamThree.speed = 13;
			animCamFour.speed = 13;
			texttrappe.GetComponent<Text> ().enabled = true;
			textaccrochage.GetComponent<Text> ().enabled = true;
			textleure.GetComponent<Text> ().enabled = true;
			textSolid.GetComponent<Text> ().enabled = true;
			textMark.GetComponent<Text> ().enabled = true;
			textOmbre.GetComponent<Text> ().enabled = true;

			

		

			if (Input.GetKeyDown (KeyCode.Alpha2)) {
                
                if (DefFune == 1 && timerDef >= ActualDef && RuneActivated==false) {
					// Rune D'ombre
					ImageRuneOmbreFull.GetComponent<Image> ().enabled = true;

					myShadowInstantiate.enabled = true;
					myShadowInstantiate.InstantiateTheShadow ();
				}
				if (DefFune == 2 && timerDef >= ActualDef && RuneActivated==false) {
					// Rune de Lure
					ImageRuneLeurreFull.GetComponent<Image> ().enabled = true;

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

                m_Anim.SetTrigger("Action");
            }
//
			if (Input.GetKeyDown (KeyCode.Alpha3)) {
                
                // rune d'accrochage
                if (TacticRune == 1 && timerTactic >= ActualTactic && RuneActivated==false) {
					ImageRuneAccrochageFull.GetComponent<Image> ().enabled = true;

					myLineRenderer.enabled = true;
					myLineRenderer.IsActivated ();
				}
				if (TacticRune == 2 && timerTactic >= ActualTactic && RuneActivated==false) {
					// rune solidification Ombre
					ImageRuneSolidificationFull.GetComponent<Image> ().enabled = true;

					mySolidicationEnabled.enabled = true;
					mySolidicationEnabled.SolidificationStart ();
				}

                m_Anim.SetTrigger("Action");
            }

			if (Input.GetKeyDown (KeyCode.Alpha1)) {
                
                // Rune de piege
                if (OffenseRune == 1 && timerOffense >= ActualOffense && RuneActivated==false) {
					ImageRunePiegeFull.GetComponent<Image> ().enabled = true;

					myenabledTrapMode.enabled = true;
					myenabledTrapMode.EnabledTrapMode ();
				}	
				if (OffenseRune == 2 && timerOffense >= ActualOffense && RuneActivated==false) {
					ImageRuneMarquageFull.GetComponent<Image> ().enabled = true;

					// rune de marquage
					print("Blue");
					myMarkEnnemy.enabled = true;
					myMarkEnnemy.EnemyMarkedStart ();
				}

                m_Anim.SetTrigger("Action");
            }
//
//
//
//
//
		}

}

}