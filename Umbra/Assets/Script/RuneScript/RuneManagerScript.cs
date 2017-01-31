using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneManagerScript : MonoBehaviour 
{

	ShadowInstantiate myShadowInstantiate;
	BlindEnnemyRune myBlindEnnemyRune;
	MarkEnnemy myMarkEnnemy;

	public float timerAssassination;
	public float timerEnvironment;
	public float timerUmbra;
	LureScript myLureScript;
	public GameObject ThePlayer;
	PlatformerCharacter2D myPlatformCharacter;

	public int UmbraRune;
	public int EnvironmentRune;
	public int AssassinationRune;
	public int TypeRuneUsed;
	// Use this for initialization
	void Start () {
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
				if (UmbraRune == 1)
					myPlatformCharacter.StartCorou ();
//				if(UmbraRune==2)
//
//
//
			}
//
			if(TypeRuneUsed==2)
			{
				if(EnvironmentRune==1)
					myShadowInstantiate.InstantiateTheShadow();
//				if(EnvironmentRune==2)
//
//
			}
			if(TypeRuneUsed==3)
			{
				if (AssassinationRune == 1)
					myBlindEnnemyRune.EnnemyBlinded ();
				if (AssassinationRune == 2)
					myLureScript.StartLure ();
				if (AssassinationRune == 3)
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