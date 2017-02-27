using UnityEngine;
using System.Collections;

public class DeadScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("Im Dead");
		gameObject.tag="Dead Ennemy";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void EnnemyDeath()
	{
		print("Im Dead");
		gameObject.tag="Dead Ennemy";
		GetComponent<SpriteRenderer> ().color = new Color (0, 0, 0);
		GetComponent<Rigidbody2D> ().isKinematic = true;
	GetComponent<BoxCollider2D> ().isTrigger = true;


	}
}
