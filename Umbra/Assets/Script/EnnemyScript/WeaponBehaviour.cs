using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehaviour : MonoBehaviour {
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	//	transform.localScale = new Vector3 (1,);
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = transform.right * 23;
	}

	void OnTriggerEnter2D(Collider2D col)
	{

		if (col.tag == "bloc")
			Destroy (gameObject);

}

}
