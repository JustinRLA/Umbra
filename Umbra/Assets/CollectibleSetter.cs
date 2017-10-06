using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class CollectibleSetter : MonoBehaviour {

	public Sprite[] LetterComplete;
	public GameObject[] LetterBase;
	public GameObject ArrowLeft;
	public GameObject ArrowRight;
	public int StateofLetter;
	public GameObject PageNumber;


	int NumberofLetter;
	public GameObject ScoreSetter;


	// Use this for initialization
	void Start () {
		
		if (PlayerPrefs.GetInt ("LetterOne") == 1) {
			LetterBase [0].GetComponent<Image> ().sprite = LetterComplete [0];
			NumberofLetter++;
		}
		if (PlayerPrefs.GetInt ("LetterTwo") == 1) {
			LetterBase [1].GetComponent<Image> ().sprite = LetterComplete [1];
			NumberofLetter++;
		}
		if (PlayerPrefs.GetInt ("LetterThree") == 1) {
			LetterBase [2].GetComponent<Image> ().sprite = LetterComplete [2];
			NumberofLetter++;

		}
		if (PlayerPrefs.GetInt ("LetterFour") == 1) {
			LetterBase [3].GetComponent<Image> ().sprite = LetterComplete [3];
			NumberofLetter++;

		}
		if (PlayerPrefs.GetInt ("LetterFive") == 1) {
			LetterBase [4].GetComponent<Image> ().sprite = LetterComplete [4];
			NumberofLetter++;
		}
		if(NumberofLetter==5)
			{

		}
		ScoreSetter.GetComponent<Text> ().text = NumberofLetter.ToString();
	}
	public void Reset()
	{
		
		StateofLetter = 0;
		ScoreSetter.GetComponent<Text> ().text = StateofLetter+1.ToString();

			ArrowLeft.SetActive (false);
		ArrowRight.SetActive (true);
		LetterBase [0].SetActive (true);
		LetterBase [1].SetActive (false);
		LetterBase [2].SetActive (false);
		LetterBase [3].SetActive (false);
		LetterBase [4].SetActive (false);



	}

	public void GoLeft () {
		StateofLetter--;
		ScoreSetter.GetComponent<Text> ().text = StateofLetter+1.ToString();

		LetterBase [StateofLetter + 1].SetActive (false);
		LetterBase [StateofLetter].SetActive (true);

		if (StateofLetter <= 0)
			ArrowLeft.SetActive (false);
		ArrowRight.SetActive (true);
	}
	public void GoRight () {
		StateofLetter++;
		ScoreSetter.GetComponent<Text> ().text = StateofLetter+1.ToString();

		LetterBase [StateofLetter - 1].SetActive (false);
		LetterBase [StateofLetter].SetActive (true);

		if (StateofLetter >= 4)
			ArrowRight.SetActive (false);
		ArrowLeft.SetActive (true);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
