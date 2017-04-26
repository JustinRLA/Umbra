using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTutoEvent : MonoBehaviour {
	//ENNEMY BAIT!!!!!!!!!!!!!!!!
	public GameObject EnnemyTarget;
	public Transform PhantomPoint;
	public GameObject Shield;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag=="Player")
		{
			EnnemyTarget.GetComponent<EnnnemyPatrolUpgraded> ().PhamomPoint.position = PhantomPoint.position;
			EnnemyTarget.GetComponent<EnnnemyPatrolUpgraded> ().timerState = 13.6f;
			Shield.GetComponent<Animator> ().SetBool ("Play", true);
			GetComponent<Collider2D> ().enabled = false;
			StartCoroutine (timeanim ());
		}

	}

	IEnumerator timeanim()
	{
		yield return new WaitForSeconds (0.4f);
		AkSoundEngine.PostEvent ("SFX_Scripted_Shield",gameObject);

	}
}
