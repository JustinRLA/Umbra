using UnityEngine;
using System.Collections;

public class DeadScript : MonoBehaviour {
	public GameObject ViewBase;
	public GameObject ViewManager;

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
		ViewManager.SetActive (false);
		ViewBase.SetActive (false);

		GetComponent<SpriteRenderer> ().color = new Color (0, 0, 0);
		GetComponent<Rigidbody2D> ().isKinematic = true;
	GetComponent<BoxCollider2D> ().isTrigger = true;


	}
}
