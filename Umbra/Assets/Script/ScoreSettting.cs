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
		Cursor.visible = true;
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
			PlayerPrefs.SetInt("LessDeath",PlayerPrefs.GetInt("Death"));
		else
			if(PlayerPrefs.GetInt("LessDeath")>PlayerPrefs.GetInt("Death"))
				PlayerPrefs.SetInt("LessDeath",PlayerPrefs.GetInt("Death"));
		//More Kill
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetInt("MoreKill",PlayerPrefs.GetInt("Kill"));
		else
			if(PlayerPrefs.GetInt("MoreKill")<PlayerPrefs.GetInt("Kill"))
				PlayerPrefs.SetInt("MoreKill",PlayerPrefs.GetInt("Kill"));
		//Less Kill
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetInt("LessKill",PlayerPrefs.GetInt("Kill"));
		else
			if(PlayerPrefs.GetInt("LessKill")>PlayerPrefs.GetInt("Kill"))
				PlayerPrefs.SetInt("LessKill",PlayerPrefs.GetInt("Kill"));

		// More Shadow Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetInt("MoreRuneShadowNumber",PlayerPrefs.GetInt("RuneShadowNumber"));
		else
			if(PlayerPrefs.GetInt("MoreRuneShadowNumber")<PlayerPrefs.GetInt("RuneShadowNumber"))
				PlayerPrefs.SetInt("MoreRuneShadowNumber",PlayerPrefs.GetInt("RuneShadowNumber"));

		// Less Shadow Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetInt("LessRuneShadowNumber",PlayerPrefs.GetInt("RuneShadowNumber"));
		else
			if(PlayerPrefs.GetInt("LessRuneShadowNumber")>PlayerPrefs.GetInt("RuneShadowNumber"))
				PlayerPrefs.SetInt("LessRuneShadowNumber",PlayerPrefs.GetInt("RuneShadowNumber"));

		// More Mark Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetInt("MoreRuneMarkNumber",PlayerPrefs.GetInt("RuneMarkNumber"));
		else
			if(PlayerPrefs.GetInt("MoreRuneMarkNumber")<PlayerPrefs.GetInt("RuneMarkNumber"))
				PlayerPrefs.SetInt("MoreRuneMarkNumber",PlayerPrefs.GetInt("RuneMarkNumber"));

		// Less Mark Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetInt("LessRuneMarkNumber",PlayerPrefs.GetInt("RuneMarkNumber"));
		else
			if(PlayerPrefs.GetInt("LessRuneMarkNumber")>PlayerPrefs.GetInt("RuneMarkNumber"))
				PlayerPrefs.SetInt("LessRuneMarkNumber",PlayerPrefs.GetInt("RuneMarkNumber"));
		
		// More Solid Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.GetInt("MoreRuneSolidNumber",PlayerPrefs.GetInt("RuneSolidNumber"));
		else
			if(PlayerPrefs.GetInt("MoreRuneSolidNumber")<PlayerPrefs.GetInt("RuneSolidNumber"))
				PlayerPrefs.SetInt("MoreRuneSolidNumber",PlayerPrefs.GetInt("RuneSolidNumber"));

		// Less Solid Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.GetInt("LessRuneSolidNumber",PlayerPrefs.GetInt("RuneSolidNumber"));
		else
			if(PlayerPrefs.GetInt("LessRuneSolidNumber")>PlayerPrefs.GetInt("RuneSolidNumber"))
				PlayerPrefs.SetInt("LessRuneSolidNumber",PlayerPrefs.GetInt("RuneSolidNumber"));
		
		// More Trap Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetInt("MoreRuneTrapNumber",PlayerPrefs.GetInt("RuneTrapNumber"));
		else
			if(PlayerPrefs.GetInt("MoreRuneTrapNumber")<PlayerPrefs.GetInt("RuneTrapNumber"))
				PlayerPrefs.SetInt("MoreRuneTrapNumber",PlayerPrefs.GetInt("RuneTrapNumber"));

		// Less Trap Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetInt("LessRuneTrapNumber",PlayerPrefs.GetInt("RuneTrapNumber"));
		else
			if(PlayerPrefs.GetInt("LessRuneTrapNumber")>PlayerPrefs.GetInt("RuneTrapNumber"))
				PlayerPrefs.SetInt("LessRuneTrapNumber",PlayerPrefs.GetInt("RuneTrapNumber"));

		// More Lure Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetInt("MoreRuneLureNumber",PlayerPrefs.GetInt("RuneLureNumber"));
		else
			if(PlayerPrefs.GetInt("MoreRuneLureNumber")<PlayerPrefs.GetInt("RuneLureNumber"))
				PlayerPrefs.SetInt("MoreRuneLureNumber",PlayerPrefs.GetInt("RuneLureNumber"));

		// Less Lure Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.GetInt("LessRuneLureNumber",PlayerPrefs.GetInt("RuneLureNumber"));
		else
			if(PlayerPrefs.GetInt("LessRuneLureNumber")>PlayerPrefs.GetInt("RuneLureNumber"))
				PlayerPrefs.SetInt("LessRuneLureNumber",PlayerPrefs.GetInt("RuneLureNumber"));
		
		// More Grap Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetInt("MoreRuneGrapNumber",PlayerPrefs.GetInt("RuneGrapNumber"));
		else
			if(PlayerPrefs.GetInt("MoreRuneGrapNumber")<PlayerPrefs.GetInt("RuneGrapNumber"))
				PlayerPrefs.SetInt("MoreRuneGrapNumber",PlayerPrefs.GetInt("RuneGrapNumber"));

		// Less Grap Use
		if((PlayerPrefs.GetInt ("PartieFinies")==0))
			PlayerPrefs.SetInt("LessRuneGrapNumber",PlayerPrefs.GetInt("RuneGrapNumber"));
		else
			if(PlayerPrefs.GetInt("LessRuneGrapNumber")>PlayerPrefs.GetInt("RuneGrapNumber"))
				PlayerPrefs.SetInt("LessRuneGrapNumber",PlayerPrefs.GetInt("RuneGrapNumber"));
		


		Timertext.GetComponent<Text>().text=((Mathf.Floor(PlayerPrefs.GetFloat("Timer"))/ 60).ToString() + " : "+ ((PlayerPrefs.GetFloat("Timer"))% 60).ToString());

		BestTimertext.GetComponent<Text>().text=((Mathf.Floor(PlayerPrefs.GetFloat("BestTimer"))/ 60).ToString() + " : "+ ((PlayerPrefs.GetFloat("BestTimer"))% 60).ToString());


		Deathtext.GetComponent<Text>().text=(PlayerPrefs.GetInt("Death").ToString());
		LessDeathtext.GetComponent<Text>().text=(PlayerPrefs.GetInt("LessDeath").ToString());

		Killtext.GetComponent<Text>().text=(PlayerPrefs.GetInt("Kill").ToString());
		LessKilltext.GetComponent<Text>().text=(PlayerPrefs.GetInt("LessKill").ToString());
		MostKilltext.GetComponent<Text>().text=(PlayerPrefs.GetInt("MoreKill").ToString());

		Solidtext.GetComponent<Text>().text=(PlayerPrefs.GetInt("RuneSolidNumber").ToString());
		LessSolidtext.GetComponent<Text>().text=(PlayerPrefs.GetInt("LessRuneSolidNumber").ToString());
		MostSolidtext.GetComponent<Text>().text=(PlayerPrefs.GetInt("MoreRuneSolidNumber").ToString());

		MarkText.GetComponent<Text>().text=(PlayerPrefs.GetInt("RuneMarkNumber").ToString());
		LessMarkText.GetComponent<Text>().text=(PlayerPrefs.GetInt("LessRuneMarkNumber").ToString());
		MostMarkText.GetComponent<Text>().text=(PlayerPrefs.GetInt("MoreRuneMarkNumber").ToString());

		MarkText.GetComponent<Text>().text=(PlayerPrefs.GetInt("RuneShadowNumber").ToString());
		LessMarkText.GetComponent<Text>().text=(PlayerPrefs.GetInt("LessRuneShadowNumber").ToString());
		MostMarkText.GetComponent<Text>().text=(PlayerPrefs.GetInt("MoreRuneShadowNumber").ToString());

		TrapText.GetComponent<Text>().text=(PlayerPrefs.GetInt("RuneTrapNumber").ToString());
		LessTrapText.GetComponent<Text>().text=(PlayerPrefs.GetInt("LessRuneTrapNumber").ToString());
		MostTrapText.GetComponent<Text>().text=(PlayerPrefs.GetInt("MoreRuneTrapNumber").ToString());

		GrapText.GetComponent<Text>().text=(PlayerPrefs.GetInt("RuneGrapNumber").ToString());
		LessGrapText.GetComponent<Text>().text=(PlayerPrefs.GetInt("LessRuneGrapNumber").ToString());
		MostGrapText.GetComponent<Text>().text=(PlayerPrefs.GetInt("MoreRuneGrapNumber").ToString());

		LureText.GetComponent<Text>().text=(PlayerPrefs.GetInt("RuneLureNumber").ToString());
		LessLureText.GetComponent<Text>().text=(PlayerPrefs.GetInt("LessRuneLureNumber").ToString());
		MostLureText.GetComponent<Text>().text=(PlayerPrefs.GetInt("MoreRuneLureNumber").ToString());


		PlayerPrefs.SetInt ("PartieFinies", (PlayerPrefs.GetInt ("PartieFinies") + 1));

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
