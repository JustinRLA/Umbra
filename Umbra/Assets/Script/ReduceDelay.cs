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
		transform.position = new Vector3 (transform.position.x, transform.position.y, -1);
		Time.timeScale = 0.04f;
		GetComponent<SpriteRenderer> ().sortingOrder = 10;
		Playa.GetComponent<PlatformerCharacter2D> ().enabled = false;
		yield return new WaitForSeconds (0.05f);
		GetComponent<Animator> ().SetBool ("Play", true);


	}

public void ZeroFixe()
{
	transform.position = new Vector3 (transform.position.x, transform.position.y, 0);
		GetComponent<SpriteRenderer> ().sortingOrder = -2;
		Playa.GetComponent<PlatformerCharacter2D> ().enabled = true;
		Time.timeScale = 1f;


}
}