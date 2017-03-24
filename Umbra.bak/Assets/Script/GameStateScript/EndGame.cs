using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndGame : MonoBehaviour {
	public GameObject tempoFeedback;
	public GameObject Player;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void EndOfGame()
	{
		StartCoroutine(EndGameEnum());

	}

	IEnumerator EndGameEnum()
	{
		tempoFeedback.SetActive (true);
		Player.GetComponent<PlatformerCharacter2D> ().enabled = false;
		Player.GetComponent<CharacterController> ().enabled = false;

		yield return new WaitForSeconds (2);
		SceneManager.LoadScene ("Main menu");

	}
	void OnTriggerEnter2D( Collider2D col)
	{
		if(col.tag=="Player")
			StartCoroutine(EndGameEnum());
		
		
		}


}
