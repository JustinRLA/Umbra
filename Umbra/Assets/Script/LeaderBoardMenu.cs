using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoardMenu : MonoBehaviour {
	public GameObject BestTimertext;

	public GameObject LessDeathtext;

	public GameObject MostKilltext;
	public GameObject LessKilltext;


	public GameObject LessSolidtext;
	public GameObject MostSolidtext;

	public GameObject MostShadowtext;
	public GameObject LessShadowtext;

	public GameObject MostTrapText;
	public GameObject LessTrapText;



	public GameObject LessGrapText;
	public GameObject MostGrapText;

	public GameObject MostMarkText;
	public GameObject LessMarkText;

	public GameObject MostLureText;
	public GameObject LessLureText;

	// Use this for initialization
	void Start () {
		LessDeathtext.GetComponent<Text>().text=(PlayerPrefs.GetFloat("LessDeath").ToString());

		LessKilltext.GetComponent<Text>().text=(PlayerPrefs.GetFloat("LessKill").ToString());
		MostKilltext.GetComponent<Text>().text=(PlayerPrefs.GetFloat("MoreKill").ToString());


		LessSolidtext.GetComponent<Text>().text=(PlayerPrefs.GetFloat("LessRuneSolidNumber").ToString());
		MostSolidtext.GetComponent<Text>().text=(PlayerPrefs.GetFloat("MoreRuneSolidNumber").ToString());

		LessMarkText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("LessRuneMarkNumber").ToString());
		MostMarkText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("MoreRuneMarkNumber").ToString());

		LessMarkText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("LessRuneShadowNumber").ToString());
		MostMarkText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("MoreRuneShadowNumber").ToString());

		LessTrapText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("LessRuneTrapNumber").ToString());
		MostTrapText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("MoreRuneTrapNumber").ToString());

		LessGrapText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("LessRuneGrapNumber").ToString());
		MostGrapText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("MoreRuneGrapNumber").ToString());

		LessLureText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("LessRuneLureNumber").ToString());
		MostLureText.GetComponent<Text>().text=(PlayerPrefs.GetFloat("MoreRuneLureNumber").ToString());

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
