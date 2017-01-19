using UnityEngine;
using System.Collections;

public class ladderScript : MonoBehaviour {
	public bool canClimb;
	GameObject ThePlayer;
	Animator animPlayer;

	// Use this for initialization
	void Start () {
		ThePlayer = GameObject.Find ("2DCharacter");
		animPlayer = ThePlayer.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		//transform.parent.position = transform.position - transform.localPosition;
		if (canClimb == true) {
			ThePlayer.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeAll;
			if (Input.GetKey (KeyCode.W))
				ThePlayer.transform.Translate (Vector2.up * Time.deltaTime);
			if (Input.GetKey (KeyCode.S))
				ThePlayer.transform.Translate (Vector2.down * Time.deltaTime);
			if (Input.GetKey (KeyCode.Space))
				canClimb = false;	
			animPlayer.SetBool ("Climb", true);
		}
		else
			StartCoroutine (ReturnToNormal ());
	
			
	}
	void OnTriggerEnter2D (Collider2D col) {
		if(col.tag=="Player")
		{
			canClimb = true;
			ThePlayer = col.gameObject;

		}
	}
	void OnTriggerExit2D (Collider2D col) {
		if(col.tag=="Player")
		{
			canClimb = false;




		}

}
	IEnumerator ReturnToNormal()
	{
		ThePlayer.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeRotation;
		animPlayer.SetBool ("Climb", false);

		yield return null;
	}
}
