using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLastShit : MonoBehaviour {
	public GameObject LastGrap;
	public GameObject LastTrap;
	public GameObject LastCache;
	public GameObject LastJudas;
	public GameObject LastOeillere;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Player") {
			LastGrap.SetActive (true);
			LastJudas.SetActive (true);
			LastCache.SetActive (true);
			LastTrap.SetActive (true);
			LastOeillere.SetActive (true);

		}

	}

}
