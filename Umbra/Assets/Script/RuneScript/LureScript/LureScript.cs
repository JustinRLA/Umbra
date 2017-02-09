using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//namespace UnityStandardAssets._2D
//{

public class LureScript : MonoBehaviour {
	
	public GameObject ThePlayer;
	public GameObject ThePlayerShadow;
		public bool EnnemyDistracted;
		public GameObject RuneManager;
	RuneManagerScript myRuneManagerScript;

	public bool Active=false;
	public float timer;


	// Use this for initialization
	void Start () {
		myRuneManagerScript = GetComponent<RuneManagerScript> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartLure () {
		//	if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.W)) 
		//	{
		Active=true;


			ThePlayerShadow.GetComponent<PlatformerCharacter2D> ().enabled = true;
			ThePlayerShadow.GetComponent<Platformer2DUserControl> ().enabled = true;
		RuneManager.GetComponent<RuneManagerScript> ().timerTactic = 30;
			ThePlayer.GetComponent<PlatformerCharacter2D> ().enabled = false;
			ThePlayer.GetComponent<Platformer2DUserControl> ().enabled = false;
			ThePlayerShadow.SetActive (true);
				StartCoroutine (DistractEnnemy ());
	//}
		}
		IEnumerator DistractEnnemy()
		{
		
			EnnemyDistracted = true;
		ThePlayer.GetComponent<BoxCollider2D> ().enabled = false;
		ThePlayer.GetComponent<Rigidbody2D> ().isKinematic = true;
		//timer += Time.deltaTime;
		timer = 10;
		//ThePlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 150;
		ThePlayer.GetComponent<Collider2D> ().enabled = false;
		ThePlayer.GetComponent<CircleCollider2D> ().enabled = false;
		ThePlayerShadow.transform.parent = null;

			yield return new WaitForSeconds(5f);
		ThePlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;

		myRuneManagerScript.RuneActivated = false;
		myRuneManagerScript.RuneModeEnabled = false;

		myRuneManagerScript.timerDef = 0;
		ThePlayer.GetComponent<BoxCollider2D> ().enabled = true;

		ThePlayer.GetComponent<Collider2D> ().enabled = true;
		ThePlayer.GetComponent<CircleCollider2D> ().enabled = true;
		ThePlayer.GetComponent<Rigidbody2D> ().isKinematic = false;

			Time.timeScale = 1.0f;
		timer = 10;

		ThePlayer.GetComponent<PlatformerCharacter2D> ().enabled = true;
		ThePlayer.GetComponent<Platformer2DUserControl> ().enabled = true;
			ThePlayerShadow.GetComponent<PlatformerCharacter2D> ().enabled = false;
			ThePlayerShadow.GetComponent<Platformer2DUserControl> ().enabled = false;
			yield return new WaitForSeconds(2f);
		timer = 8;
		yield return new WaitForSeconds(2f);
		timer = 6;
		yield return new WaitForSeconds(2f);
		timer = 4;
		yield return new WaitForSeconds(2f);
		timer = 2;
		yield return new WaitForSeconds(2f);

		ThePlayerShadow.transform.parent = ThePlayer.transform;
			EnnemyDistracted = false;
			ThePlayerShadow.transform.position = ThePlayer.transform.position;
			ThePlayerShadow.SetActive (false);
		Active = false;
		}

}
//}