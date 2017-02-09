using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehaviour : MonoBehaviour {
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = transform.right * 50;
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player")
			col.GetComponent<PlatformerCharacter2D> ().Death ();

		if (col.tag == "Untagged")
			Destroy (gameObject);

}

}
