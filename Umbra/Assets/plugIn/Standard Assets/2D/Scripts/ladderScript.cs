using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{

public class ladderScript : MonoBehaviour {
	public bool canClimb;
	public GameObject ThePlayer;
	Animator animPlayer;
	public bool RightLadder;
		public Transform maxxY;

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
				if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.Space)==false && ThePlayer.transform.position.y<maxxY.position.y)
				ThePlayer.transform.Translate (Vector2.up * 2*Time.deltaTime);
			if (Input.GetKey (KeyCode.S))
				ThePlayer.transform.Translate (Vector2.down * 2*Time.deltaTime);
				if (Input.GetKey (KeyCode.Space))
					JumpFromLader ();		

					animPlayer.SetBool ("Climb", true);
				myPLatformCharacter.ClimbTrue = true;

				if (Input.GetKey (KeyCode.E))
					StartCoroutine (ReturnToNormal ());


		}
	
			
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
		void JumpFromLader()
		{
			canClimb = false;

			ThePlayer.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeRotation;
			//ThePlayer.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 10));
			ThePlayer.GetComponent<Rigidbody2D>().velocity=new Vector2(0f, 15);
			animPlayer.SetBool ("Climb", false);
			myPLatformCharacter.ClimbTrue = false;

			StartCoroutine (ReturnToNormal ());

		}

	IEnumerator ReturnToNormal()
	{
			canClimb = false;

			ThePlayer.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeRotation;

//		ThePlayer.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeRotation;
		animPlayer.SetBool ("Climb", false);
			myPLatformCharacter.ClimbTrue = false;
			GetComponent<Collider2D> ().enabled = false;


			yield return new WaitForSeconds(1f);
			GetComponent<Collider2D> ().enabled = true;

	}
}

}