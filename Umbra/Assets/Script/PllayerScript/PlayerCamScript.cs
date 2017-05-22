using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamScript : MonoBehaviour {
	public GameObject PlayerMy;
	public bool activateLeurreCam;
	public GameObject Leurre;
	public float direction;
	Vector3 movPos;
	public float PanUp;
	public float timerLeurre;
	PlatformerCharacter2D myPlatformCharacter;


	public float speed;

	// Use this for initialization
	void Start () {
		PlayerMy = GameObject.Find("2DCharacter(Clone)");
		myPlatformCharacter = PlayerMy.GetComponent<PlatformerCharacter2D> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
	
	}
	void Update () {
		if (Input.GetAxis("Vertical")<0 && PanUp > -2 && myPlatformCharacter.m_Grounded==true)
			PanUp -= Time.smoothDeltaTime * 6;
		if (Input.GetAxis("Vertical")>0 && PanUp <2 && myPlatformCharacter.m_Grounded==true)
			PanUp += Time.smoothDeltaTime * 6;
		if (Input.GetAxis("Vertical")==0 && PanUp>0)
			PanUp -= Time.smoothDeltaTime * 6;
		if (Input.GetAxis("Vertical")==0 && PanUp<0)
			PanUp += Time.smoothDeltaTime * 6;
		if (myPlatformCharacter.m_Grounded==false && PanUp>0)
			PanUp -= Time.smoothDeltaTime * 6;
		if ( myPlatformCharacter.m_Grounded==false && PanUp<0)
			PanUp += Time.smoothDeltaTime * 6;
			

		if(activateLeurreCam==false && timerLeurre>0)
		{
			movPos = new Vector3(PlayerMy.transform.position.x - transform.position.x, PlayerMy.transform.position.y - transform.position.y,0);
			if(transform.position !=PlayerMy.transform.position)
			transform.position += movPos * Time.deltaTime*2;

			timerLeurre -= Time.deltaTime;

		}
		if(activateLeurreCam==false && timerLeurre<=0)
			transform.position = new Vector3(PlayerMy.transform.position.x, PlayerMy.transform.position.y+PanUp,-13);

		if(activateLeurreCam==true)
		{
			transform.position = new Vector3(Leurre.transform.position.x, Leurre.transform.position.y,-13);
			timerLeurre = 2;
		}




	}
}
