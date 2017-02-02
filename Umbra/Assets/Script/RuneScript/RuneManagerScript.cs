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

	public float timerAssassination;
	public float timerEnvironment;
	public float timerUmbra;
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
	}
	
	// Update is called once per frame
	void Update () {

		// RuneUmbra
		if (Input.GetKeyDown (KeyCode.Alpha1))
			TypeRuneUsed = 1;
		// Rune Environnement
		if (Input.GetKeyDown (KeyCode.Alpha2))
			TypeRuneUsed = 2;

		// Rune Assassination
		if (Input.GetKeyDown (KeyCode.Alpha3))
			TypeRuneUsed = 3;

		if(Input.GetKeyDown (KeyCode.E))
		{
			if(TypeRuneUsed==1)
			{
				if (DefFune == 1)
					myShadowInstantiate.InstantiateTheShadow();
				
				if (DefFune == 1)
				myLureScript.StartLure ();
			}
//
			if(TypeRuneUsed==2)
			{
				if (TacticRune == 1)
					myLineRenderer.IsActivated ();
				if (TacticRune == 2)
					mySolidicationEnabled.SolidificationStart ();
				

						
						//
//
			}
			if(TypeRuneUsed==3)
			{
				if (OffenseRune == 1)
					print ("Piege");
				if (OffenseRune == 2)
					myMarkEnnemy.EnemyMarkedStart ();

			}
//
//
//
//
//
}
}
}