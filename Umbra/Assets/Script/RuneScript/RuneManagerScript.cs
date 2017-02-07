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

	LureScript myLureScript;
	public GameObject ThePlayer;
	PlatformerCharacter2D myPlatformCharacter;

	public int DefFune;
	public int OffenseRune;
	public int TacticRune;
	public int TypeRuneUsed;
	// Use this for initialization
	void Start () {
		

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

		if (RuneModeEnabled == true)
		{
			myCam.GetComponent<Animator> ().speed = 13;

			myCam.GetComponent<Animator> ().SetBool ("Blue",true);
		}

		if ( RuneModeEnabled == false)
		{
			myCam.GetComponent<Animator> ().speed = 2;

			myCam.GetComponent<Animator> ().SetBool ("Blue",false);
		}
		//if (Input.GetKeyDown (KeyCode.E) && RuneModeEnabled == false)
			//myCam.GetComponent<Animator> ().speed = 10.0f;

	//	if (Input.GetKeyDown (KeyCode.E) && RuneModeEnabled == true)
		//	myCam.GetComponent<Animator> (). = -10.0f;



	//	myCam.GetComponent<Animator> ().SetBool ("Blue",true);

		if (Input.GetKeyDown (KeyCode.Q) && RuneModeEnabled==false)
			RuneModeEnabled = true;

		if (Input.GetKeyDown (KeyCode.T) && RuneModeEnabled==true)
			RuneModeEnabled = false;
		
		
		if (RuneModeEnabled == true) { 
			myCam.GetComponent<ColorCorrectionCurves>().enabled=true;
			Time.timeScale = 0.1f;
			if (Input.GetKeyDown (KeyCode.Alpha1)) {

				if (DefFune == 1 && timerDef >= ActualDef && RuneActivated==false) {
					myShadowInstantiate.enabled = true;
					myShadowInstantiate.InstantiateTheShadow ();
				}
				
				if (DefFune == 2 && timerDef >= ActualDef && RuneActivated==false) {
					myLureScript.enabled = true;
					myLureScript.StartLure ();
				}

			}
//
			if (Input.GetKeyDown (KeyCode.Alpha2)) {
				if (TacticRune == 1 && timerTactic >= ActualTactic && RuneActivated==false) {
					myLineRenderer.enabled = true;
					myLineRenderer.IsActivated ();
				}
				if (TacticRune == 2 && timerTactic >= ActualTactic && RuneActivated==false) {
					mySolidicationEnabled.enabled = true;
					mySolidicationEnabled.SolidificationStart ();
				}


			}
			if (Input.GetKeyDown (KeyCode.Alpha3)) {
				if (OffenseRune == 1 && timerOffense >= ActualOffense && RuneActivated==false) {
					myenabledTrapMode.enabled = true;
					myenabledTrapMode.EnabledTrapMode ();
				}	
				if (OffenseRune == 2 && timerOffense >= ActualOffense && RuneActivated==false) {
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
		else {
			myCam.GetComponent<ColorCorrectionCurves>().enabled=false;

			Time.timeScale = 1;
		}
}

}