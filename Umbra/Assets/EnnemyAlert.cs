using UnityEngine;
using System.Collections;

public class EnnemyAlert : MonoBehaviour {
	int AlertCondition;

	public int DistranctionsSoud;
	int SoundListerner=50;

	bool InRange=false;

	public Transform ThePlayer;

	public bool Alert=false;
	public bool Suspicious=false;
	public	float SoundLevel;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if (Suspicious == true)
			//StartCoroutine (SuspicousMode ());
		//if (Alert == true)
			//StartCoroutine (AlerMode ());
		

		if(InRange==true)
		{
			SoundLevel = Vector3.Distance (ThePlayer.transform.position, transform.position);
			if ((SoundListerner-DistranctionsSoud) / SoundLevel > 4 && Alert == false)
				StartCoroutine (SuspicousMode ());
			//print ((SoundListerner / SoundLevel));
			if ((SoundListerner-DistranctionsSoud) / SoundLevel > 8)
			{
				StartCoroutine (AlerMode ());
			StopCoroutine (SuspicousMode ());
			}	
					
		}

	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "suspiciouis Sound")
			InRange = true;
	}
	void OnTriggerExit2D(Collider2D col)
	{
		if (col.tag == "suspiciouis Sound")
			InRange = false;
	}

		IEnumerator SuspicousMode()
		{
		Suspicious = true;

			yield return new WaitForSeconds(10f);
			Suspicious=false;
			//return null;
		
		}
		IEnumerator AlerMode()
		{
		Alert = true;
		Suspicious = false;
			yield return new WaitForSeconds(10f);
			Alert=false;
		yield return false;
		}



}
