using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class CollectibleSetter : MonoBehaviour {

	public GameObject LetterOne;
	public GameObject LetterTwo;
	public GameObject LetterThree;
	public GameObject LetterFour;
	public GameObject LetterFive;
	public GameObject LetterComplete;
	int NumberofLetter;
	public GameObject ScoreSetter;


	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("LetterOne") == 1) {
			LetterOne.SetActive (true);
			NumberofLetter++;
		}
		if (PlayerPrefs.GetInt ("LetterTwo") == 1) {
			LetterTwo.SetActive (true);
			NumberofLetter++;
		}
		if (PlayerPrefs.GetInt ("LetterThree") == 1) {
			LetterThree.SetActive (true);
			NumberofLetter++;

		}
		if (PlayerPrefs.GetInt ("LetterFour") == 1) {
			LetterFour.SetActive (true);
			NumberofLetter++;

		}
		if (PlayerPrefs.GetInt ("LetterFive") == 1) {
			LetterFive.SetActive (true);
			NumberofLetter++;
		}
		if(NumberofLetter==5)
			{
			LetterComplete.SetActive (true);

		}
		ScoreSetter.GetComponent<Text> ().text = NumberofLetter.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
