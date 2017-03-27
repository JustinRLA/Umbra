using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ReduceDelay : MonoBehaviour {

	GameObject Playa;
	// Use this for initialization
	void Start () {
		Playa = GameObject.Find ("2DCharacter(Clone)");
		StartCoroutine (Reducing ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Reducing()
	{
		
		Time.timeScale = 0.04f;
		GetComponent<SpriteRenderer> ().sortingOrder = 10;
		Playa.GetComponent<PlatformerCharacter2D> ().enabled = false;
		yield return new WaitForSeconds (0.1f);
		GetComponent<Animator> ().SetBool ("Play", true);
		GetComponent<SpriteRenderer> ().sortingOrder = 0;
		Playa.GetComponent<PlatformerCharacter2D> ().enabled = true;
		Time.timeScale = 1f;

	}
}
