using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonePatrol : MonoBehaviour {
	public float timerState;
	public bool trapped =false;
	//PatrolPart

	public Transform CurrentNavPoint;
	public GameObject CurrentNavPointGo;
	public Transform LurePlayer;
	public GameObject SawLureFeedback;

	public Transform returnPointRight;
	public GameObject returnPointRightObj;

	Collider2D returnRightCol;

	public Transform returnPointLeft;
	public GameObject returnPointLeftObj;
	Collider2D returnPointLeftCol;

	Vector3 movPos;
	public bool CloneIsUp;

	public Transform UpPoint;
	public Transform DownPoint;

	public GameObject Proj;
	public Transform ProjStartPos;
	public GameObject ProjStartObj;
	public GameObject TeleportPoint;


	public bool alertcondition=false;
	public bool suspiciousCondition=false;

	public GameObject PhantomPlayer;
	public Transform PhamomPoint;

	public GameObject MyPlayer;

	public int FlipScale;
	bool isFLippe=false;

	public int NavPointIGot;

	public float speed;
	public float OriginalSpeed;

	Vector2 target;
	Vector3 NewPos;

	GameObject myLight;
	SightListenerTemplate mySighListernetTemplate;
	public GameObject mySighListerner;


	public float delay = 10f;
	// SoundDetection Part

	public int DistranctionsSoud;
	int SoundListerner=50;
	public bool somethingHappen;
	public bool isAClone;

	bool InRange=false;

	public Transform ThePlayer;

	public bool Alert=false;
	public bool Suspicious=false;

	public	float SoundLevel;

	public int attackdelay=1;

	public Transform RightLimit;
	public Transform LeftLimit;
	public GameObject RuneManager;
	RuneManagerScript myRunemanagerScript;
	LureScript myLureScript;
	float direction;
	public bool LureAttention;
	Vector3 ProjDir;
	float angle;

	//	// Use this for initialization
	public void Respawn()
	{
		gameObject.tag="ennemy";
		GetComponent<Rigidbody2D> ().isKinematic = false;
		GetComponent<BoxCollider2D> ().isTrigger = false;
	}

	void Start () {
		returnRightCol = returnPointRightObj.GetComponent<Collider2D> ();
		returnPointLeftCol = returnPointLeftObj.GetComponent<Collider2D> ();
		MyPlayer = GameObject.Find ("2DCharacter");
		ThePlayer = MyPlayer.transform;
		RuneManager = GameObject.Find ("RuneManager");

		myLureScript = RuneManager.GetComponent<LureScript> ();
		myRunemanagerScript = RuneManager.GetComponent<RuneManagerScript> ();
		gameObject.tag="ennemyClone";

		//fsm=StateMachine<States>.Initialize.this;
		mySighListernetTemplate = mySighListerner.GetComponent<SightListenerTemplate> ();
		StartCoroutine (MyAttack());
		//InvokeRepeating ("throwdagger", 1f, attackdelay);
		//dynamicLighting=myLight.GetComponent<DynamicLight2D>();

		//CurrentNavPoint = NavPointOne_Right;

		CurrentNavPointGo = CurrentNavPoint.gameObject;

		OriginalSpeed = speed;
		InvokeRepeating ("flipAlert",5f,1f);
	}
	//	
	//	// Update is called once per frame
	//

	void AlertMode()
	{

	}
	//
	void Update () {



		if(Alert==true )
		{
			if(ThePlayer.position.y<UpPoint.position.y)
			{

				if (CurrentNavPoint.position.x-transform.position.x <0 && isFLippe==false)
					flip ();
				if (CurrentNavPoint.position.x-transform.position.x >0 && isFLippe==true)
					flip ();

				if(ThePlayer.position.x >= LeftLimit.position.x|| CurrentNavPoint.position.x <= RightLimit.position.x)
					CurrentNavPoint = ThePlayer;

				if (ThePlayer.position.x < LeftLimit.position.x)
					CurrentNavPoint = LeftLimit;

				if (ThePlayer.position.x > RightLimit.position.x)
					CurrentNavPoint = RightLimit;
				returnPointLeftCol.enabled = false;
				returnRightCol.enabled = false;


				if (trapped == false) {
					if ((transform.position.x - CurrentNavPoint.position.x) < 5 || (transform.position.x - CurrentNavPoint.position.x) > -5)
						speed = 0;
					if ((transform.position.x - CurrentNavPoint.position.x) > 5 || (transform.position.x - CurrentNavPoint.position.x) <= -5)
						speed = OriginalSpeed;
				}
				else
					speed = 0;

			}
			else
			{
				if(Vector3.Distance(returnPointLeft.position,transform.position)<Vector3.Distance(returnPointRight.position,transform.position))
				{
					returnPointLeftCol.enabled = true;
					CurrentNavPoint = returnPointLeft;
				}
				else
				{
					returnRightCol.enabled = true;
					CurrentNavPoint = returnPointRight;
				}

			}
		}
		if(Suspicious==true )
		{

			if(mySighListernetTemplate.IsawTheLure==true)
			{
				LureAttention = true;
				SawLureFeedback.SetActive (true);
				if(LurePlayer.position.x >= LeftLimit.position.x|| LurePlayer.position.x <= RightLimit.position.x)
					CurrentNavPoint = LurePlayer;

				if (LurePlayer.position.x < LeftLimit.position.x)
					CurrentNavPoint = LeftLimit;

				if (LurePlayer.position.x > RightLimit.position.x)
					CurrentNavPoint = RightLimit;

				timerState = myLureScript.timer;
			}
			else
			{

				SawLureFeedback.SetActive (false);
				LureAttention = false;

				if(PhamomPoint.position.y<UpPoint.position.y)
				{


					if(PhamomPoint.position.x >= LeftLimit.position.x|| PhamomPoint.position.x <= RightLimit.position.x)
						CurrentNavPoint = PhamomPoint;

					if (CurrentNavPoint.position.x < LeftLimit.position.x)
						CurrentNavPoint = LeftLimit;

					if (CurrentNavPoint.position.x > RightLimit.position.x)
						CurrentNavPoint = RightLimit;

					if (trapped == false) {
						if( (transform.position.x-CurrentNavPoint.position.x) <5 || (transform.position.x-CurrentNavPoint.position.x) > -5)
							speed = 0;

						if((transform.position.x-CurrentNavPoint.position.x)>=5 || (transform.position.x-CurrentNavPoint.position.x) <=-5)
							speed = OriginalSpeed;
					}
					else
						speed = 0;

				}
				else
				{
					if(Vector3.Distance(returnPointLeft.position,transform.position)<Vector3.Distance(returnPointRight.position,transform.position))
					{
						returnPointLeftCol.enabled = true;
						CurrentNavPoint = returnPointLeft;
					}
					else
					{
						returnRightCol.enabled = true;
						CurrentNavPoint = returnPointRight;
					}
				}

			}
		}
		if (somethingHappen == false && timerState>-2)
			timerState -= Time.deltaTime;

		if (Alert == true)
			GetComponent<SpriteRenderer> ().color = new Color (0, 1, 1, 1);

		if (Suspicious == true)
			GetComponent<SpriteRenderer> ().color = new Color (1, 0, 1, 1);

		if (Alert == false && Suspicious==false)
			GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 1);


		//the actual way to make ennemy move toward a specific Point
		if(Suspicious==true)
		{
			direction = Mathf.Sign (CurrentNavPoint.position.x - transform.position.x);
			//		print (Mathf.Sign (CurrentNavPoint.position.x - transform.position.x));
			Vector3 movPos = new Vector3 (transform.position.x + ((direction/100)*speed*2* Time.deltaTime) , transform.position.y,transform.position.z);
			transform.position = movPos ;
		}
		if(Alert==true)
		{
			direction = Mathf.Sign (CurrentNavPoint.position.x - transform.position.x);
			//		print (Mathf.Sign (CurrentNavPoint.position.x - transform.position.x));
			Vector3 movPos = new Vector3 (transform.position.x + ((direction/100)*speed*4* Time.deltaTime) , transform.position.y,transform.position.z);
			transform.position = movPos ;
		}
		if(Alert==false && Suspicious==false)
		{
			direction = Mathf.Sign (CurrentNavPoint.position.x - transform.position.x);
			//		print (Mathf.Sign (CurrentNavPoint.position.x - transform.position.x));
			Vector3 movPos = new Vector3 (transform.position.x + ((direction/100)*speed* Time.deltaTime) , transform.position.y,transform.position.z);
			transform.position = movPos ;
		}



		//		if(Alert==true) 
		//			{
		//			if (trapped == false) {
		//				if ((transform.position.x - CurrentNavPoint.position.x) < 5 || (transform.position.x - CurrentNavPoint.position.x) > -5)
		//					speed = 0;
		//				if ((transform.position.x - CurrentNavPoint.position.x) > 5 || (transform.position.x - CurrentNavPoint.position.x) <= -5)
		//					speed = OriginalSpeed;
		//			}
		//			else
		//				speed = 0;
		//		}	

		//			if(Suspicious==true)
		//		{
		//			if (trapped == false) {
		//			if( (transform.position.x-CurrentNavPoint.position.x) <5 || (transform.position.x-CurrentNavPoint.position.x) > -5)
		//			speed = 0;
		//
		//			if((transform.position.x-CurrentNavPoint.position.x)>=5 || (transform.position.x-CurrentNavPoint.position.x) <=-5)
		//			speed = OriginalSpeed;
		//			}
		//			else
		//				speed = 0;
		//		}
		if(InRange==true && LureAttention==false)
		{
			SoundLevel = Vector3.Distance (ThePlayer.transform.position, transform.position);
			if(Alert==false && mySighListernetTemplate.throwAlert==false)
			{
				if ((SoundListerner-DistranctionsSoud) / SoundLevel > 4)
				{
					timerState = 15;
				}	
				else
					suspiciousCondition=false;
			}
			if ((SoundListerner - DistranctionsSoud) / SoundLevel > 8) {
				timerState = 30;
			} 
		}

		if(Alert==false && mySighListernetTemplate.throwAlert==false)
		{
			if (mySighListernetTemplate.throwSuspicious==true)
			{
				//	suspiciousCondition=true;
				//StartCoroutine (SuspicousMode ());
				timerState = 15;
			}
		}	
		else
			suspiciousCondition=false;

		if ( mySighListernetTemplate.throwAlert == true) {
			timerState = 30;
		} 


		if (InRange == false && mySighListernetTemplate.iSeeYou == false)
			somethingHappen = false;
		else
			somethingHappen = true;

		if(timerState>15)
		{
			Alert = true;
			Suspicious = false;
			CurrentNavPointGo = null;
		
		}
		if(timerState>0 && timerState<=15)
		{

			Suspicious = true;
			Alert = false;
			if(timerState>14 &&  timerState<15)
			{

				PhantomPlayer.transform.position = MyPlayer.transform.position;
				PhamomPoint.position = ThePlayer.position;

			}
			//	if(PhamomPoint.position.y<

		

			if (CurrentNavPoint.position.x-transform.position.x <1 && isFLippe==false)
				flip ();
			if (CurrentNavPoint.position.x-transform.position.x >0 && isFLippe==true)
				flip ();


		}
		//}
		if(timerState>-1 &&  timerState<0)
		{
			if(Vector3.Distance(returnPointLeft.position,transform.position)<Vector3.Distance(returnPointRight.position,transform.position))
			{
				returnPointLeftCol.enabled = true;
				CurrentNavPoint = returnPointLeft;
			}
			else
			{
				returnRightCol.enabled = true;
				CurrentNavPoint = returnPointRight;
			}


			if (CurrentNavPoint.position.x-transform.position.x <0 && isFLippe==false)
				flip ();
			if (CurrentNavPoint.position.x-transform.position.x >0 && isFLippe==true)
				flip ();


		}

	}

		IEnumerator MyAttack()
	{
		while(true)
		{
			yield return new WaitForSeconds (attackdelay);
			if(Alert==true && Vector3.Distance(transform.position, ThePlayer.position)<8)
			{
				Instantiate (Proj, ProjStartPos.position, ProjStartPos.rotation);
				attackdelay = 2;
			}	
		}	
	}	

	public void StartCorTrap()
	{
		StartCoroutine (TrapMode ());

	}	

	IEnumerator TrapMode()
	{
		trapped = true;
		speed = 0;
		yield return new WaitForSeconds (10);
		trapped = false;
		speed = OriginalSpeed;
	}	


	void OnTriggerEnter2D (Collider2D col) {

		if (col.tag == "suspiciouis Sound")
			InRange = true;

		if (col.tag == "falseSoundTrigger")
		{
			mySighListernetTemplate.IsawTheLure = true;
			Suspicious = true;
		}

	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.tag == "suspiciouis Sound")
			InRange = false;
	}




	void flipAlert()
	{
		if (Alert == true)
		{
			if (CurrentNavPoint.position.x-transform.position.x <0 && isFLippe==false)
				flip ();
			if (CurrentNavPoint.position.x-transform.position.x >0 && isFLippe==true)
				flip ();
		}

	}
	void flip()
	{

		FlipScale = FlipScale * -1;
		transform.localScale = new Vector3 (FlipScale, 1, 1);
		isFLippe =! isFLippe;

	}

}
