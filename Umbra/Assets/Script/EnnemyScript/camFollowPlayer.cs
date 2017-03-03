using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollowPlayer : MonoBehaviour {
	Vector3 ProjDir;

	SightListenerTemplate mySightListener;
	public GameObject TheSightListener;
	float angle;
	public Transform ThePlayer;
	public GameObject MyPlayer;
	public Transform KLurePlayer;



	// Use this for initialization
	void Start () {
		mySightListener = TheSightListener.GetComponent<SightListenerTemplate> ();
		MyPlayer = GameObject.Find ("2DCharacter");
		ThePlayer = MyPlayer.transform;
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if(mySightListener.inCam==true)
		{
			ProjDir = ThePlayer.position - transform.position;
			angle = Mathf.Atan2 (ProjDir.y, ProjDir.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
			}
		if(mySightListener.LureInCam==true && KLurePlayer != null)
		{
			ProjDir = KLurePlayer.position - transform.position;
			angle = Mathf.Atan2 (ProjDir.y, ProjDir.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
		}

	}
}
