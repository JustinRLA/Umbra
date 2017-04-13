using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeRunePoint : MonoBehaviour {
	public bool canChange;
	public int myTempoDefRune;
	public int myTempoOffRune;
	public int myTempoTacticRune;
	public GameObject RuneManager;
	public Sprite SpawnerNormal;
	public Sprite SpawnerOver;


	GameObject MyBorneBase;
	BorneBase BorneBasescript;


	public GameObject FeedBackImage;
	public GameObject UIMode;
	public GameObject playerMy;
	// Use this for initialization
	void Start () {
		playerMy=GameObject.Find("2DCharacter(Clone)");
		MyBorneBase = GameObject.Find ("BorneBase");

		RuneManager=GameObject.Find("RuneManager");
		FeedBackImage = GameObject.Find ("feedbackRuneChange");
		BorneBasescript = MyBorneBase.GetComponent<BorneBase> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E) && canChange == true && playerMy.GetComponent<PlatformerCharacter2D> ().canChangeRune == true)
		{
			UIMode.SetActive (true);

		playerMy.GetComponent<PlatformerCharacter2D> ().enabled = false;
			playerMy.GetComponent<Platformer2DUserControl> ().enabled = false;
			BorneBasescript.ReceiveInfo ();
			Cursor.visible=true;
		}
		if (canChange == true && playerMy.GetComponent<PlatformerCharacter2D> ().canChangeRune == true)
			FeedBackImage.GetComponent<SpriteRenderer> ().enabled = true;
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player")
		{
			GetComponent<SpriteRenderer> ().sprite = SpawnerOver;
			playerMy = col.gameObject;
			canChange = true;
		}
	}
	void OnTriggerExit2D(Collider2D col)
	{
		if (col.tag == "Player") {
			canChange = false;
			FeedBackImage.GetComponent<SpriteRenderer> ().enabled = false;
			GetComponent<SpriteRenderer> ().sprite = SpawnerNormal;

		}

	}

}
