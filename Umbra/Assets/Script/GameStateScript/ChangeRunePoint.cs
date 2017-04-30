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
	public GameObject pauseBase;

	PauseMenu myPauseMenu;


	GameObject MyBorneBase;
	BorneBase BorneBasescript;


	public GameObject FeedBackImage;
	public GameObject UIMode;
	public GameObject playerMy;
	// Use this for initialization
	void Start () {
		pauseBase = GameObject.Find ("PauseBase");
		myPauseMenu = pauseBase.GetComponent<PauseMenu> ();
		playerMy=GameObject.Find("2DCharacter(Clone)");
		MyBorneBase = GameObject.Find ("BorneBase");

		RuneManager=GameObject.Find("RuneManager");
		BorneBasescript = MyBorneBase.GetComponent<BorneBase> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E) && canChange == true && playerMy.GetComponent<PlatformerCharacter2D> ().canChangeRune == true && playerMy.GetComponent<PlatformerCharacter2D> ().canPressHideBtn == true && myPauseMenu.isPause==false)
		{
			playerMy.GetComponent<PlatformerCharacter2D> ().canPressHideBtn = false;
			UIMode.SetActive (true);
			AkSoundEngine.PostEvent ("PC_Rune_Select", gameObject);
		playerMy.GetComponent<PlatformerCharacter2D> ().enabled = false;
			playerMy.GetComponent<Platformer2DUserControl> ().enabled = false;
			BorneBasescript.ReceiveInfo ();
			Cursor.visible=true;
		}
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
			GetComponent<SpriteRenderer> ().sprite = SpawnerNormal;

		}

	}

}
