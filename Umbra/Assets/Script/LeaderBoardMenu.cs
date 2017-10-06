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
		BestTimertext.GetComponent<Text>().text=((Mathf.Floor(PlayerPrefs.GetFloat("BestTimer"))/ 60).ToString() + " : "+ ((PlayerPrefs.GetFloat("BestTimer"))% 60).ToString());

		LessDeathtext.GetComponent<Text>().text=(PlayerPrefs.GetInt("LessDeath").ToString());

		LessKilltext.GetComponent<Text>().text=(PlayerPrefs.GetInt("LessKill").ToString());
		MostKilltext.GetComponent<Text>().text=(PlayerPrefs.GetInt("MoreKill").ToString());


		LessSolidtext.GetComponent<Text>().text=(PlayerPrefs.GetInt("LessRuneSolidNumber").ToString());
		MostSolidtext.GetComponent<Text>().text=(PlayerPrefs.GetInt("MoreRuneSolidNumber").ToString());

		LessMarkText.GetComponent<Text>().text=(PlayerPrefs.GetInt("LessRuneMarkNumber").ToString());
		MostMarkText.GetComponent<Text>().text=(PlayerPrefs.GetInt("MoreRuneMarkNumber").ToString());

		LessMarkText.GetComponent<Text>().text=(PlayerPrefs.GetInt("LessRuneShadowNumber").ToString());
		MostMarkText.GetComponent<Text>().text=(PlayerPrefs.GetInt("MoreRuneShadowNumber").ToString());

		LessTrapText.GetComponent<Text>().text=(PlayerPrefs.GetInt("LessRuneTrapNumber").ToString());
		MostTrapText.GetComponent<Text>().text=(PlayerPrefs.GetInt("MoreRuneTrapNumber").ToString());

		LessGrapText.GetComponent<Text>().text=(PlayerPrefs.GetInt("LessRuneGrapNumber").ToString());
		MostGrapText.GetComponent<Text>().text=(PlayerPrefs.GetInt("MoreRuneGrapNumber").ToString());

		LessLureText.GetComponent<Text>().text=(PlayerPrefs.GetInt("LessRuneLureNumber").ToString());
		MostLureText.GetComponent<Text>().text=(PlayerPrefs.GetInt("MoreRuneLureNumber").ToString());

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
