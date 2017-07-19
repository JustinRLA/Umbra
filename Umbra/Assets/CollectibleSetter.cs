using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class CollectibleSetter : MonoBehaviour {
	public Sprite LetterOneSprite;
	public Sprite LetterTwoSprite;
	public Sprite LetterThreeSprite;
	public Sprite LetterFourSprite;
	public Sprite LetterFiveSprite;

	public GameObject LetterOne;
	public GameObject LetterTwo;
	public GameObject LetterThree;
	public GameObject LetterFour;
	public GameObject LetterFive;

	int NumberofLetter;
	public GameObject ScoreSetter;


	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("LetterOne") == 1) {
			LetterOne.GetComponent<SpriteRenderer> ().sprite = LetterOneSprite;
			NumberofLetter++;
		}
		if (PlayerPrefs.GetInt ("LetterTwo") == 1) {
			LetterTwo.GetComponent<SpriteRenderer> ().sprite = LetterTwoSprite;
			NumberofLetter++;
		}
		if (PlayerPrefs.GetInt ("LetterThree") == 1) {
			LetterThree.GetComponent<SpriteRenderer> ().sprite = LetterThreeSprite;
			NumberofLetter++;

		}
		if (PlayerPrefs.GetInt ("LetterFour") == 1) {
			LetterFour.GetComponent<SpriteRenderer> ().sprite = LetterFourSprite;
			NumberofLetter++;

		}
		if (PlayerPrefs.GetInt ("LetterFive") == 1) {
			LetterFive.GetComponent<SpriteRenderer> ().sprite = LetterFiveSprite;
			NumberofLetter++;
		}
		ScoreSetter.GetComponent<Text> ().text = NumberofLetter.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
