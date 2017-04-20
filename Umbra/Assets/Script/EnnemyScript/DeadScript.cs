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
		if(ViewManager!=null)
		ViewManager.SetActive (false);
		if(ViewBase !=null)
		ViewBase.SetActive (false);

		GetComponent<SpriteRenderer> ().color = new Color (0, 0, 0);
		GetComponent<Rigidbody2D> ().isKinematic = true;
	GetComponent<BoxCollider2D> ().isTrigger = true;
		AkSoundEngine.PostEvent ("NPC_Destroy", gameObject);
		StartCoroutine (destroydelai ());


	}
	IEnumerator destroydelai()
	{

		yield return new WaitForSeconds (0.5f);
		Destroy (transform.parent.gameObject);
	}
}
