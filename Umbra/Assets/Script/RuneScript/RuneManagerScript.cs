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

	public float ActualDef;
	public float ActualOffense;
	public float ActualTactic;

	LureScript myLureScript;
	public GameObject ThePlayer;
	PlatformerCharacter2D myPlatformCharacter;

	public int DefFune;
	public int OffenseRune;
	public int TacticRune;
	public int TypeRuneUsed;
	// Use this for initialization
	void Start () {
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
		if(timerDef>ActualDef)
		{
			timerDef += Time.deltaTime;
		}
		if(timerTactic>ActualTactic)
		{
			timerDef += Time.deltaTime;
		}
		if(timerOffense>ActualOffense)
		{
			timerDef += Time.deltaTime;
		}
		if (Input.GetKeyDown (KeyCode.E))
			RuneModeEnabled = true;


		// RuneUmbra
		if (Input.GetKeyDown (KeyCode.Alpha1))
			TypeRuneUsed = 1;
		// Rune Environnement
		if (Input.GetKeyDown (KeyCode.Alpha2))
			TypeRuneUsed = 2;

		// Rune Assassination
		if (Input.GetKeyDown (KeyCode.Alpha3))
			TypeRuneUsed = 3;

		if(RuneModeEnabled==true)
		{
			if(Input.GetKeyDown (KeyCode.Alpha1))
			{
				if (DefFune == 1 && timerDef >= ActualDef)
				{
					myShadowInstantiate.enabled = true;
					myShadowInstantiate.InstantiateTheShadow();
				}
				
				if (DefFune == 1 && timerDef >= ActualDef)
				{
					myLureScript.enabled = true;
					myLureScript.StartLure ();
				}

			}
//
			if(Input.GetKeyDown (KeyCode.Alpha2))
			{
				if (TacticRune == 1 && timerTactic >=ActualTactic)
				{
					myLineRenderer.enabled =true;
					myLineRenderer.IsActivated ();
				}
				if (TacticRune == 2 && timerTactic >=ActualTactic)
				{
					mySolidicationEnabled.enabled = true;
					mySolidicationEnabled.SolidificationStart ();
				}


			}
			if(Input.GetKeyDown (KeyCode.Alpha3))
			{
				if (OffenseRune == 1 && timerOffense >=ActualOffense)
				{
					myenabledTrapMode.enabled = true;
					myenabledTrapMode.EnabledTrapMode ();
				}	
				if (OffenseRune == 2  && timerOffense >=ActualOffense)
				{
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