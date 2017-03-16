using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapEnnemy : MonoBehaviour {
	public GameObject ObjectArray;
	public GameObject ParticleExplosion;
	public GameObject PastParticle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D col) {

		if (col.tag == "ennemy")
		{
			col.GetComponent<EnnnemyPatrolUpgraded> ().StartCorTrap ();
			PastParticle.SetActive (false);
			GetComponent<Collider2D> ().enabled = false;
			StartCoroutine (Countown ());
		}

	}
	IEnumerator Countown()
	{
		
		ObjectArray.SetActive (true);
		ParticleExplosion.SetActive (true);
		yield return new WaitForSeconds (2f);
		ObjectArray.SetActive (false);
		Destroy (gameObject);

	}

}
