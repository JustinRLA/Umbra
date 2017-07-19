using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSettting : MonoBehaviour {
	public GameObject LetterOne;
	public GameObject LetterTwo;
	public GameObject LetterThree;
	public GameObject LetterFour;
	public GameObject LetterFive;


	public GameObject Timertext;
	public GameObject BestTimertext;

	public GameObject Deathtext;
	public GameObject LessDeathtext;

	public GameObject Killtext;
	public GameObject MostKilltext;
	public GameObject LessKilltext;


	public GameObject Solidtext;
	public GameObject LessSolidtext;
	public GameObject MostSolidtext;

	public GameObject Shadowtext;
	public GameObject MostShadowtext;
	public GameObject LessShadowtext;

	public GameObject TrapText;	
	public GameObject MostTrapText;
	public GameObject LessTrapText;



	public GameObject GrapText;
	public GameObject LessGrapText;
	public GameObject MostGrapText;

	public GameObject MarkText;
	public GameObject MostMarkText;
	public GameObject LessMarkText;

	public GameObject LureText;
	public GameObject MostLureText;
	public GameObject LessLureText;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("LetterOne") == 1)
			LetterOne.SetActive (true);
		
		if (PlayerPrefs.GetInt ("LetterTwo") == 1)
			LetterTwo.SetActive (true);
		if (PlayerPrefs.GetInt ("LetterThree") == 1)
			LetterThree.SetActive (true);
		if (PlayerPrefs.GetInt ("LetterFour") == 1)
			LetterFour.SetActive (true);
		if (PlayerPrefs.GetInt ("LetterFive") == 1)
			LetterFive.SetActive (true);
		// best time
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetFloat("BestTimer",PlayerPrefs.GetFloat("Timer"));
			else
			if(PlayerPrefs.GetFloat("BestTimer")>PlayerPrefs.GetFloat("Timer"))
				PlayerPrefs.SetFloat("BestTimer",PlayerPrefs.GetFloat("Timer"));
		// Less death
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetFloat("LessDeath",PlayerPrefs.GetFloat("Death"));
		else
			if(PlayerPrefs.GetFloat("LessDeath")>PlayerPrefs.GetFloat("Death"))
				PlayerPrefs.SetFloat("LessDeath",PlayerPrefs.GetFloat("Death"));
		//More Kill
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetFloat("MoreKill",PlayerPrefs.GetFloat("Kill"));
		else
			if(PlayerPrefs.GetFloat("MoreKill")<PlayerPrefs.GetFloat("Kill"))
				PlayerPrefs.SetFloat("MoreKill",PlayerPrefs.GetFloat("Kill"));
		//Less Kill
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetFloat("LessKill",PlayerPrefs.GetFloat("Kill"));
		else
			if(PlayerPrefs.GetFloat("LessKill")>PlayerPrefs.GetFloat("Kill"))
				PlayerPrefs.SetFloat("LessKill",PlayerPrefs.GetFloat("Kill"));

		// More Shadow Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetFloat("MoreRuneShadowNumber",PlayerPrefs.GetFloat("RuneShadowNumber"));
		else
			if(PlayerPrefs.GetFloat("MoreRuneShadowNumber")<PlayerPrefs.GetFloat("RuneShadowNumber"))
				PlayerPrefs.SetFloat("MoreRuneShadowNumber",PlayerPrefs.GetFloat("RuneShadowNumber"));

		// Less Shadow Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetFloat("LessRuneShadowNumber",PlayerPrefs.GetFloat("RuneShadowNumber"));
		else
			if(PlayerPrefs.GetFloat("LessRuneShadowNumber")>PlayerPrefs.GetFloat("RuneShadowNumber"))
				PlayerPrefs.SetFloat("LessRuneShadowNumber",PlayerPrefs.GetFloat("RuneShadowNumber"));

		// More Mark Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetFloat("MoreRuneMarkNumber",PlayerPrefs.GetFloat("RuneMarkNumber"));
		else
			if(PlayerPrefs.GetFloat("MoreRuneMarkNumber")<PlayerPrefs.GetFloat("RuneMarkNumber"))
				PlayerPrefs.SetFloat("MoreRuneMarkNumber",PlayerPrefs.GetFloat("RuneMarkNumber"));

		// Less Mark Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetFloat("LessRuneMarkNumber",PlayerPrefs.GetFloat("RuneMarkNumber"));
		else
			if(PlayerPrefs.GetFloat("LessRuneMarkNumber")>PlayerPrefs.GetFloat("RuneMarkNumber"))
				PlayerPrefs.SetFloat("LessRuneMarkNumber",PlayerPrefs.GetFloat("RuneMarkNumber"));
		
		// More Solid Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetFloat("MoreRuneSolidNumber",PlayerPrefs.GetFloat("RuneSolidNumber"));
		else
			if(PlayerPrefs.GetFloat("MoreRuneSolidNumber")<PlayerPrefs.GetFloat("RuneSolidNumber"))
				PlayerPrefs.SetFloat("MoreRuneSolidNumber",PlayerPrefs.GetFloat("RuneSolidNumber"));

		// Less Solid Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetFloat("LessRuneSolidNumber",PlayerPrefs.GetFloat("RuneSolidNumber"));
		else
			if(PlayerPrefs.GetFloat("LessRuneSolidNumber")>PlayerPrefs.GetFloat("RuneSolidNumber"))
				PlayerPrefs.SetFloat("LessRuneSolidNumber",PlayerPrefs.GetFloat("RuneSolidNumber"));
		
		// More Trap Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetFloat("MoreRuneTrapNumber",PlayerPrefs.GetFloat("RuneTrapNumber"));
		else
			if(PlayerPrefs.GetFloat("MoreRuneTrapNumber")<PlayerPrefs.GetFloat("RuneTrapNumber"))
				PlayerPrefs.SetFloat("MoreRuneTrapNumber",PlayerPrefs.GetFloat("RuneTrapNumber"));

		// Less Trap Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetFloat("LessRuneTrapNumber",PlayerPrefs.GetFloat("RuneTrapNumber"));
		else
			if(PlayerPrefs.GetFloat("LessRuneTrapNumber")>PlayerPrefs.GetFloat("RuneTrapNumber"))
				PlayerPrefs.SetFloat("LessRuneTrapNumber",PlayerPrefs.GetFloat("RuneTrapNumber"));

		// More Lure Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetFloat("MoreRuneLureNumber",PlayerPrefs.GetFloat("RuneLureNumber"));
		else
			if(PlayerPrefs.GetFloat("MoreRuneLureNumber")<PlayerPrefs.GetFloat("RuneLureNumber"))
				PlayerPrefs.SetFloat("MoreRuneLureNumber",PlayerPrefs.GetFloat("RuneLureNumber"));

		// Less Lure Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetFloat("LessRuneLureNumber",PlayerPrefs.GetFloat("RuneLureNumber"));
		else
			if(PlayerPrefs.GetFloat("LessRuneLureNumber")>PlayerPrefs.GetFloat("RuneLureNumber"))
				PlayerPrefs.SetFloat("LessRuneLureNumber",PlayerPrefs.GetFloat("RuneLureNumber"));
		
		// More Grap Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetFloat("MoreRuneGrapNumber",PlayerPrefs.GetFloat("RuneGrapNumber"));
		else
			if(PlayerPrefs.GetFloat("MoreRuneGrapNumber")<PlayerPrefs.GetFloat("RuneGrapNumber"))
				PlayerPrefs.SetFloat("MoreRuneGrapNumber",PlayerPrefs.GetFloat("RuneGrapNumber"));

		// Less Grap Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetFloat("LessRuneGrapNumber",PlayerPrefs.GetFloat("RuneGrapNumber"));
		else
			if(PlayerPrefs.GetFloat("LessRuneGrapNumber")>PlayerPrefs.GetFloat("RuneGrapNumber"))
				PlayerPrefs.SetFloat("LessRuneGrapNumber",PlayerPrefs.GetFloat("RuneGrapNumber"));
		

		Timertext.GetComponent<Text>().text=(PlayerPrefs.GetFloat("Timer").ToString());
		BestTimertext.GetComponent<Text>().text=(PlayerPrefs.GetFloat("BestTimer").ToString());


		Deathtext.GetComponent<Text>().text=(PlayerPrefs.GetFloat("Death").ToString());
		LessDeathtext.GetComponent<Text>().text=(PlayerPrefs.GetFloat("LessDeath").ToString());

		Killtext.GetComponent<Text>().text=(PlayerPrefs.GetFloat("Kill").ToString());
		LessKilltext.GetComponent<Text>().text=(PlayerPrefs.GetFloat("LessKill").ToString());
		MostKilltext.GetComponent<Text>().text=(PlayerPrefs.GetFloat("MoreKill").ToString());


		Solidtext.GetComponent<Text>().text=(PlayerPrefs.GetFloat("RuneSolidNumber").ToString());
		LessSolidtext.GetComponent<Text>().text=(PlayerPrefs.GetFloat("LessRuneSolidNumber").ToString());
		MostSolidtext.GetComponent<Text>().text=(PlayerPrefs.GetFloat("MoreRuneSolidNumber").ToString());

		MarkText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("RuneMarkNumber").ToString());
		LessMarkText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("LessRuneMarkNumber").ToString());
		MostMarkText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("MoreRuneMarkNumber").ToString());

		MarkText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("RuneShadowNumber").ToString());
		LessMarkText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("LessRuneShadowNumber").ToString());
		MostMarkText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("MoreRuneShadowNumber").ToString());

		TrapText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("RuneTrapNumber").ToString());
		LessTrapText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("LessRuneTrapNumber").ToString());
		MostTrapText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("MoreRuneTrapNumber").ToString());

		GrapText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("RuneGrapNumber").ToString());
		LessGrapText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("LessRuneGrapNumber").ToString());
		MostGrapText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("MoreRuneGrapNumber").ToString());

		LureText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("RuneLureNumber").ToString());
		LessLureText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("LessRuneLureNumber").ToString());
		MostLureText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("MoreRuneLureNumber").ToString());


		PlayerPrefs.SetInt ("PartieFinies", (PlayerPrefs.GetInt ("PartieFinies") + 1));

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
