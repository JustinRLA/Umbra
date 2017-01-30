using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{

public class ladderScript : MonoBehaviour {
	public bool canClimb;
	GameObject ThePlayer;
	Animator animPlayer;
	public bool RightLadder;
		PlatformerCharacter2D myPLatformCharacter;


	// Use this for initialization
	void Start () {
		ThePlayer = GameObject.Find ("2DCharacter");
		animPlayer = ThePlayer.GetComponent<Animator> ();
		//ThePlayer
			myPLatformCharacter=ThePlayer.GetComponent<PlatformerCharacter2D>();

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
				myPLatformCharacter.Climb = true;
			
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
			myPLatformCharacter.Climb = false;

		yield return null;
	}
}

}