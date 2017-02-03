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
		if(timerDef>0)
		{
			timerDef -= Time.deltaTime;
		}
		if(timerTactic>0)
		{
			timerDef -= Time.deltaTime;
		}
		if(timerOffense>0)
		{
			timerDef -= Time.deltaTime;
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
				if (DefFune == 1 && timerDef >= 0.1f)
				{
					myShadowInstantiate.enabled = true;
					myShadowInstantiate.InstantiateTheShadow();
				}
				
				if (DefFune == 1 && timerDef >= 0.1f)
				{
					myLureScript.enabled = true;
					myLureScript.StartLure ();
				}

			}
//
			if(Input.GetKeyDown (KeyCode.Alpha2))
			{
				if (TacticRune == 1 && timerTactic >=0.1f)
				{
					myLineRenderer.enabled =true;
					myLineRenderer.IsActivated ();
				}
				if (TacticRune == 2 && timerTactic >=0.1f)
				{
					mySolidicationEnabled.enabled = true;
					mySolidicationEnabled.SolidificationStart ();
				}


			}
			if(Input.GetKeyDown (KeyCode.Alpha3))
			{
				if (OffenseRune == 1 && timerOffense >=0.1f)
				{
					myenabledTrapMode.enabled = true;
					myenabledTrapMode.EnabledTrapMode ();
				}	
				if (OffenseRune == 2  && timerOffense >=0.1f)
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