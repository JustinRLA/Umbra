using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseChangeRune : MonoBehaviour {
	public GameObject MyPlayer;
	public GameObject RuneManagerMy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Continue() {
		MyPlayer.GetComponent<PlatformerCharacter2D> ().enabled = false;
		MyPlayer.GetComponent<Platformer2DUserControl> ().enabled = false;
		gameObject.SetActive (false);
	}


}
