using UnityEngine;
using System.Collections;

public class EnnnemyPatrolUpgraded : MonoBehaviour {
	float timerBetweenPatrolOriginal;
	public float timerBetweenPatrol;
	public float timerState;
	public bool trapped =false;
	RaycastHit2D MortalRay;
	//PatrolPart
	public bool isdead=false;
	public Transform rayPointOf;
	public bool lookRight;
	public Transform CurrentNavPoint;
	public Transform LurePlayer;
	public GameObject SawLureFeedback;
	public GameObject FliPBase;
	public Transform PointToLookWIthOneNavPoint;
	public bool PlayerIsUp;
	public bool PlayerIsDown;
	Vector3 movPos;
	bool routine;
	public float timerAttack;
	bool haveplayedAlert;
	bool havePlayed
	public bool Safe;
	public Transform UpPoint;
	public Transform UpPoint_UpLevel;

	public Transform UpPoint_RegularLevel;
	public Transform UpPoint_DownLev;


	public Transform DownPoint;
	public Transform DownPoint_DownLevel;
	public Transform DownPoint_RegularLevel;
	public Transform DownPoint_UpLevel;

	public Transform NavPointOne_Right;
	public Transform NavPointTwo_Left;
	public Transform NavPointThree_EvenMoreLeft;
	public bool backHome;

	public bool navRight;


	public Transform TeleportPointLeftTransform_Actual;
	public Transform TeleportPointRightTransform_Actual;

	public GameObject TeleportPointLeft_Actual;
	public GameObject TeleportPointRight_Actual;





	public GameObject TeleportPointLeft_RegularLevel;

	public GameObject TeleportPointRight_RegularLevel;

	public Transform TeleportPointLeftTransform_RegularLevel;
	public Transform TeleportPointRightTransform_RegularLevel;


	public GameObject TeleportPointLeft_UpLevel;

	public GameObject TeleportPointRight_UpLevel;

	public Transform TeleportPointLeftTransform_UpLevel;
	public Transform TeleportPointRightTransform_UpLevel;


	public GameObject TeleportPointLeft_DownLevel;

	public GameObject TeleportPointRight_DownLevel;

	public Transform TeleportPointLeftTransform_DownLevel;
	public Transform TeleportPointRightTransform_DownLevel;




	public Transform PhamomPoint;

	public GameObject MyPlayer;
	public Transform regularSpawnPoint;
	public Transform UpSpawmnPoint;
	public Transform DownSpawnPoint;


	public int NavPointIGot;

	public float speed;
	float OriginalSpeed;

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
	float direction;
	bool InRange=false;

	public Transform ThePlayer;
	public int EnnemyLevel;
	//1 down 2 regular 3 up


	public bool Alert=false;
	public bool Suspicious=false;

	public	float SoundLevel;

	public Transform RightLimit;
	public Transform LeftLimit;
	Vector3 myPos;
	Vector3 PlayerPos;



	public Transform RightLimit_RegularLevel;
	public Transform LeftLimit_RegularLevel;

	public Transform RightLimit_UpLevel;
	public Transform LeftLimit_UpLevel;

	public Transform RightLimit_DownLevel;
	public Transform LeftLimit_DownLevel;

	public GameObject RuneManager;
	LureScript myLureScript;

	public bool LureAttention;

//	// Use this for initialization
	void Awake()
	{
		LurePlayer = GameObject.Find ("2DCharacterShadow").transform;

	}

	void Start () {
		routine = true;
		MyPlayer = GameObject.Find("2DCharacter(Clone)");
		ThePlayer = MyPlayer.transform;

		timerBetweenPatrolOriginal = timerBetweenPatrol;
		UpPoint = UpPoint_RegularLevel;
		DownPoint=DownPoint_RegularLevel;

		EnnemyLevel = 2;
		RightLimit = RightLimit_RegularLevel;
		LeftLimit = LeftLimit_RegularLevel;


		TeleportPointLeft_Actual= TeleportPointLeft_RegularLevel;
		TeleportPointLeftTransform_Actual=TeleportPointLeftTransform_RegularLevel;

		TeleportPointRight_Actual= TeleportPointRight_RegularLevel;
		TeleportPointRightTransform_Actual=TeleportPointRightTransform_RegularLevel;

		RuneManager = GameObject.Find ("RuneManager");

		myLureScript = RuneManager.GetComponent<LureScript> ();
		gameObject.tag="ennemy";

		mySighListernetTemplate = mySighListerner.GetComponent<SightListenerTemplate> ();

		CurrentNavPoint = NavPointOne_Right;


		OriginalSpeed = speed;
	}

	public void LurAttention()
	{
		print ("LureAttention");
			timerState = myLureScript.timer;
			LureAttention = true;
			SawLureFeedback.SetActive (true);
			if(LurePlayer.position.y<UpPoint.position.y && LurePlayer.position.y>DownPoint.position.y)
			{
				PlayerIsUp = false;
				PlayerIsDown = false;
				if(LurePlayer.position.x >= LeftLimit.position.x|| LurePlayer.position.x <= RightLimit.position.x)
					CurrentNavPoint = LurePlayer;

				if (LurePlayer.position.x < LeftLimit.position.x)
					CurrentNavPoint = LeftLimit;

				if (LurePlayer.position.x > RightLimit.position.x)
					CurrentNavPoint = RightLimit;

				if (CurrentNavPoint.position.x-transform.position.x <0)
				{
					lookRight=false;
					flip ();
				}
				if (CurrentNavPoint.position.x-transform.position.x >0)
				{
					lookRight=true;
					flip ();
				}


				//					TeleportPointLeftCol_RegularLevel.enabled = false;
				//					TeleportPointRightCol_RegularLevel.enabled = false;
				//
				//					TeleportPointLeftCol_DownLevel.enabled = false;
				//					TeleportPointRightCol_DownLevel.enabled = false;


				if (trapped == false) {
					if ((transform.position.x - CurrentNavPoint.position.x) < 1 || (transform.position.x - CurrentNavPoint.position.x) > -1)
						speed = 0;
					if ((transform.position.x - CurrentNavPoint.position.x) > 1 || (transform.position.x - CurrentNavPoint.position.x) <= -1)
						speed = OriginalSpeed;
				}
				else
					speed = 0;
			}


			if(LurePlayer.position.y > UpPoint.position.y)
			{
				PlayerIsUp = true;
				if(Vector3.Distance(TeleportPointLeftTransform_Actual.position,transform.position)<Vector3.Distance(TeleportPointRightTransform_Actual.position,transform.position))
					CurrentNavPoint = TeleportPointLeftTransform_Actual;
				else
					CurrentNavPoint = TeleportPointRightTransform_Actual;


				if (CurrentNavPoint.position.x-transform.position.x <0)
				{
					lookRight=false;
					flip ();
				}
				if (CurrentNavPoint.position.x-transform.position.x >0 )
				{
					lookRight=true;
					flip ();
				}
				if(Vector3.Distance (CurrentNavPoint.position, transform.position) < 5 && EnnemyLevel==1)
					goNormalFlood();

				if(Vector3.Distance (CurrentNavPoint.position, transform.position) < 5 && EnnemyLevel==2)
					goUpFloor();

				if (trapped == false) {
					if ((transform.position.x - CurrentNavPoint.position.x) < 2 || (transform.position.x - CurrentNavPoint.position.x) > -2)
						speed = 0;
					if ((transform.position.x - CurrentNavPoint.position.x) > 2 || (transform.position.x - CurrentNavPoint.position.x) <= -2)
						speed = OriginalSpeed;
				}
				else
					speed = 0;

			}

			if(LurePlayer.position.y<DownPoint.position.y)
			{
				PlayerIsDown = true;
				if(Vector3.Distance(TeleportPointLeftTransform_Actual.position,transform.position)<Vector3.Distance(TeleportPointRightTransform_Actual.position,transform.position))
					CurrentNavPoint = TeleportPointLeftTransform_Actual;
				else
					CurrentNavPoint=TeleportPointRightTransform_Actual;


				if (CurrentNavPoint.position.x-transform.position.x <0)
				{
					lookRight=false;
					flip ();
				}
				if (CurrentNavPoint.position.x-transform.position.x >0)
				{
					lookRight=true;
					flip ();
				}
				if(Vector3.Distance (CurrentNavPoint.position, transform.position) < 5 && EnnemyLevel==3)
					goNormalFlood();

				if(Vector3.Distance (CurrentNavPoint.position, transform.position) < 5 && EnnemyLevel==2)
					goDownFloor();




		

			if (trapped == false) {
				if ((transform.position.x - CurrentNavPoint.position.x) < 1 || (transform.position.x - CurrentNavPoint.position.x) > -1)
					speed = 0;
				if ((transform.position.x - CurrentNavPoint.position.x) > 1 || (transform.position.x - CurrentNavPoint.position.x) <= -1)
					speed = OriginalSpeed;
			}
			else
				speed = 0;
		}


	}

	public void setLevel()
	{
	}

	void goDownFloor()
	{
		EnnemyLevel=1;
		transform.position=DownSpawnPoint.position;
		UpPoint=UpPoint_DownLev;
		TeleportPointLeft_Actual= TeleportPointLeft_DownLevel;
		TeleportPointLeftTransform_Actual=TeleportPointLeftTransform_DownLevel;
		
		TeleportPointRight_Actual= TeleportPointRight_DownLevel;
		TeleportPointRightTransform_Actual=TeleportPointRightTransform_DownLevel;
		DownPoint=DownPoint_DownLevel;
		LeftLimit=LeftLimit_DownLevel;
		RightLimit=RightLimit_DownLevel;
		
	}


	void goNormalFlood()
	{
		backHome=false;
		EnnemyLevel=2;
		transform.position=regularSpawnPoint.position;
		UpPoint=UpPoint_RegularLevel;
		TeleportPointLeft_Actual= TeleportPointLeft_RegularLevel;
		TeleportPointLeftTransform_Actual=TeleportPointLeftTransform_RegularLevel;

		TeleportPointRight_Actual= TeleportPointRight_RegularLevel;
		TeleportPointRightTransform_Actual=TeleportPointRightTransform_RegularLevel;
		DownPoint=DownPoint_RegularLevel;
		LeftLimit=LeftLimit_RegularLevel;
		RightLimit=RightLimit_RegularLevel;

	}

	void goUpFloor()
	{
		EnnemyLevel=3;
		transform.position=UpSpawmnPoint.position;
		UpPoint=UpPoint_UpLevel;
		TeleportPointLeft_Actual=TeleportPointLeft_UpLevel;
		TeleportPointLeftTransform_Actual=TeleportPointLeftTransform_UpLevel;

		TeleportPointRight_Actual= TeleportPointRight_RegularLevel;
		TeleportPointRightTransform_Actual=TeleportPointRightTransform_UpLevel;
		DownPoint=DownPoint_UpLevel;
		LeftLimit=LeftLimit_UpLevel;
		RightLimit=RightLimit_UpLevel;


	}
	public void Respawn()
	{
		gameObject.tag="ennemy";
		GetComponent<Rigidbody2D> ().isKinematic = false;
		GetComponent<BoxCollider2D> ().isTrigger = false;
	}
//	
//	// Update is called once per frame
//
	void AlertInMode()
	{
		timerAttack -= Time.deltaTime;
		routine = false;
		Alert = true;
		Suspicious = false;
		backHome = false;
		if(Vector3.Distance(transform.position, ThePlayer.position)<5 && Safe==false && timerAttack<=0)
		{

			MyPlayer.GetComponent<PlatformerCharacter2D> ().Death ();
		}


		if(ThePlayer.position.y<UpPoint.position.y && ThePlayer.position.y>DownPoint.position.y)
		{
			PlayerIsUp = false;
			PlayerIsDown = false;
			if (CurrentNavPoint.position.x-transform.position.x <0)
			{
				lookRight=false;
				flip ();
			}
			else
			{
				lookRight=true;
				flip ();
			}


			if(ThePlayer.position.x >= LeftLimit.position.x|| CurrentNavPoint.position.x <= RightLimit.position.x)
				CurrentNavPoint = ThePlayer;

			if (ThePlayer.position.x < LeftLimit.position.x)
				CurrentNavPoint = LeftLimit;

			if (ThePlayer.position.x > RightLimit.position.x)
				CurrentNavPoint = RightLimit;

			//					TeleportPointLeftCol_RegularLevel.enabled = false;
			//					TeleportPointRightCol_RegularLevel.enabled = false;
			//
			//					TeleportPointLeftCol_DownLevel.enabled = false;
			//					TeleportPointRightCol_DownLevel.enabled = false;


			if (trapped == false) {
				if ((transform.position.x - CurrentNavPoint.position.x) < 2 || (transform.position.x - CurrentNavPoint.position.x) > -2)
					speed = 0;
				if ((transform.position.x - CurrentNavPoint.position.x) > 2 || (transform.position.x - CurrentNavPoint.position.x) <= -2)
					speed = OriginalSpeed;
			}
			else
				speed = 0;
		}


		if(ThePlayer.position.y > UpPoint.position.y)
		{
			PlayerIsUp = true;
			if(Vector3.Distance(TeleportPointLeftTransform_Actual.position,transform.position)<Vector3.Distance(TeleportPointRightTransform_Actual.position,transform.position))
				CurrentNavPoint=TeleportPointLeftTransform_Actual;
			else
				CurrentNavPoint=TeleportPointRightTransform_Actual;

			if (CurrentNavPoint.position.x-transform.position.x <0)
			{
				lookRight=false;
				flip ();
			}
			if (CurrentNavPoint.position.x-transform.position.x >0)
			{
				lookRight=true;
				flip ();
			}

				if(Vector3.Distance (CurrentNavPoint.position, transform.position) < 5 && EnnemyLevel==1)
					goNormalFlood();

				if(Vector3.Distance (CurrentNavPoint.position, transform.position) < 5 && EnnemyLevel==2)
					goUpFloor();

			if (trapped == false) {
				if ((transform.position.x - CurrentNavPoint.position.x) < 2 || (transform.position.x - CurrentNavPoint.position.x) >= -2)
					speed = 0;
				if ((transform.position.x - CurrentNavPoint.position.x) > 2 || (transform.position.x - CurrentNavPoint.position.x) <= -2)
					speed = OriginalSpeed;
			}
			else
				speed = 0;


		}

		if(ThePlayer.position.y<DownPoint.position.y)
		{
			PlayerIsDown = true;
			if(Vector3.Distance(TeleportPointLeftTransform_Actual.position,transform.position)<Vector3.Distance(TeleportPointRightTransform_Actual.position,transform.position))
				CurrentNavPoint = TeleportPointLeftTransform_Actual;
			else
				CurrentNavPoint = TeleportPointRightTransform_Actual;

				if (CurrentNavPoint.position.x-transform.position.x <0)
				{
					lookRight=false;
				flip ();
				}
				if (CurrentNavPoint.position.x-transform.position.x >0)
				{
					lookRight=true;
					flip ();
				}

				if(Vector3.Distance (CurrentNavPoint.position, transform.position) < 5 && EnnemyLevel==3)
					goNormalFlood();

				if(Vector3.Distance (CurrentNavPoint.position, transform.position) < 5 && EnnemyLevel==2)
					goDownFloor();
	
			if (trapped == false) {
				if ((transform.position.x - CurrentNavPoint.position.x) < 2 || (transform.position.x - CurrentNavPoint.position.x) > -2)
					speed = 0;
				if ((transform.position.x - CurrentNavPoint.position.x) > 2 || (transform.position.x - CurrentNavPoint.position.x) <= -2)
					speed = OriginalSpeed;
			}
			else
				speed = 0;

		}
	}

	void InSuspiciousMode()
	{
		routine = false;
		if(timerState>14 &&  timerState<=15)
		{

			PhamomPoint.position = ThePlayer.position;

		}
		Alert = false;
		Suspicious = true;
		backHome = false;


			SawLureFeedback.SetActive (false);
			LureAttention = false;
			backHome = false;

			if(PhamomPoint.position.y<UpPoint.position.y && PhamomPoint.position.y>DownPoint.position.y)
			{
				PlayerIsUp = false;
				PlayerIsDown = false;
				if (CurrentNavPoint.position.x-transform.position.x <0)
				{
					lookRight=false;
					flip ();
				}
				if (CurrentNavPoint.position.x-transform.position.x >0)
				{
					lookRight=true;
					flip ();
				}

				if(PhamomPoint.position.x >= LeftLimit.position.x|| CurrentNavPoint.position.x <= RightLimit.position.x)
					CurrentNavPoint = PhamomPoint;

				if (PhamomPoint.position.x < LeftLimit.position.x)
					CurrentNavPoint = LeftLimit;

				if (PhamomPoint.position.x > RightLimit.position.x)
					CurrentNavPoint = RightLimit;

				//					TeleportPointLeftCol_RegularLevel.enabled = false;
				//					TeleportPointRightCol_RegularLevel.enabled = false;
				//
				//					TeleportPointLeftCol_DownLevel.enabled = false;
				//					TeleportPointRightCol_DownLevel.enabled = false;


				if (trapped == false) {
					if ((transform.position.x - CurrentNavPoint.position.x) < 1 || (transform.position.x - CurrentNavPoint.position.x) > -1)
						speed = 0;
					if ((transform.position.x - CurrentNavPoint.position.x) > 1 || (transform.position.x - CurrentNavPoint.position.x) <= -1)
						speed = OriginalSpeed;
				}
				else
					speed = 0;
			}


			if(PhamomPoint.position.y > UpPoint.position.y)
			{
				PlayerIsUp = true;
				if(Vector3.Distance(TeleportPointLeftTransform_Actual.position,transform.position)<Vector3.Distance(TeleportPointRightTransform_Actual.position,transform.position))
					CurrentNavPoint = TeleportPointLeftTransform_Actual;
					else
						CurrentNavPoint = TeleportPointRightTransform_Actual;


					if (CurrentNavPoint.position.x-transform.position.x <0)
					{
						lookRight=false;
						flip ();
					}
					if (CurrentNavPoint.position.x-transform.position.x >0 )
					{
						lookRight=true;
						flip ();
					}
					if(Vector3.Distance (CurrentNavPoint.position, transform.position) < 5 && EnnemyLevel==1)
						goNormalFlood();
					
					if(Vector3.Distance (CurrentNavPoint.position, transform.position) < 5 && EnnemyLevel==2)
						goUpFloor();
			
				if (trapped == false) {
					if ((transform.position.x - CurrentNavPoint.position.x) < 2 || (transform.position.x - CurrentNavPoint.position.x) > -2)
						speed = 0;
					if ((transform.position.x - CurrentNavPoint.position.x) > 2 || (transform.position.x - CurrentNavPoint.position.x) <= -2)
						speed = OriginalSpeed;
				}
				else
					speed = 0;

			}

			if(PhamomPoint.position.y<DownPoint.position.y)
			{
				PlayerIsDown = true;
				if(Vector3.Distance(TeleportPointLeftTransform_Actual.position,transform.position)<Vector3.Distance(TeleportPointRightTransform_Actual.position,transform.position))
					CurrentNavPoint = TeleportPointLeftTransform_Actual;
				else
					CurrentNavPoint=TeleportPointRightTransform_Actual;


					if (CurrentNavPoint.position.x-transform.position.x <0)
					{
						lookRight=false;
						flip ();
					}
					if (CurrentNavPoint.position.x-transform.position.x >0)
					{
						lookRight=true;
						flip ();
					}
				if(Vector3.Distance (CurrentNavPoint.position, transform.position) < 5 && EnnemyLevel==3)
					goNormalFlood();
				
				if(Vector3.Distance (CurrentNavPoint.position, transform.position) < 5 && EnnemyLevel==2)
					goDownFloor();




				if (trapped == false) {
					if ((transform.position.x - CurrentNavPoint.position.x) < 2 || (transform.position.x - CurrentNavPoint.position.x) > -2)
						speed = 0;
					if ((transform.position.x - CurrentNavPoint.position.x) > 2 || (transform.position.x - CurrentNavPoint.position.x) <= -2)
						speed = OriginalSpeed;
				}
				else
					speed = 0;

			}


	
	}



	void NeutralMode ()
	{
		if (EnnemyLevel == 1 || EnnemyLevel == 3)
			backHome = true;
		
		if (backHome == true) {
			PlayerIsUp = false;
			PlayerIsDown = false;
			if (Vector3.Distance (TeleportPointLeftTransform_Actual.position, transform.position) < Vector3.Distance (TeleportPointRightTransform_Actual.position, transform.position)) {
				CurrentNavPoint = TeleportPointLeftTransform_Actual;
			} else {
				CurrentNavPoint = TeleportPointRightTransform_Actual;
			}


			if (Vector3.Distance (CurrentNavPoint.position, transform.position) < 3)
				goNormalFlood ();

			if (CurrentNavPoint.position.x - transform.position.x < 0) {
				lookRight = false;
				flip ();
			}
			if (CurrentNavPoint.position.x - transform.position.x > 0) {
				lookRight = true;
				flip ();
			}
		}

//		print ("that suspiciopus");
		Suspicious = false;
		if (trapped == false)
			speed = OriginalSpeed;
		else
			speed = 0;

		if (backHome == false) {
			if (EnnemyLevel == 2) {
				if (NavPointTwo_Left != null) {

					if ((Vector3.Distance (transform.position, NavPointOne_Right.position)) < (Vector3.Distance (transform.position, NavPointTwo_Left.position))) {
						CurrentNavPoint = NavPointOne_Right;
						NavPointIGot = 2;
						//	if(NavPointTwo_Left !=null)
//						NavPoitnTwoGo.GetComponent<Collider2D>().enabled = false;
						//	NavPoitnOneGo.GetComponent<Collider2D>().enabled = true;
					} else {
						CurrentNavPoint = NavPointTwo_Left;
						NavPointIGot = 1;
					}

				}

				if (NavPointTwo_Left == null) {
					CurrentNavPoint = NavPointOne_Right;
					NavPointIGot = 2;

				}


				if (CurrentNavPoint.position.x - transform.position.x < 0) {
					lookRight = false;
					flip ();
				}
				if (CurrentNavPoint.position.x - transform.position.x > 0) {
					lookRight = true;
					flip ();
				}


			}

			routine = true;
		}
	





		}



	void Routine()
	{

		if(NavPointTwo_Left==null && Alert==false && Suspicious == false)
		{
			if (Vector3.Distance (CurrentNavPoint.position, transform.position) < 2)
			{
				speed = 0;
				//				print ("near");
				if (PointToLookWIthOneNavPoint.GetComponent<lookPosition>().RightTo==false)
				{
					lookRight=false;
					flip ();
				}
				else
				{
					lookRight=true;
					flip ();
				}
			}
		}

		if(NavPointTwo_Left !=null)
		{
			if(Vector3.Distance (CurrentNavPoint.position, transform.position) < 3 && Alert==false && Suspicious==false)
			{
				//flip();
				//			print("Close");
				navRight =!navRight;
				timerBetweenPatrol -= Time.deltaTime;
				speed = 0;
				if(navRight==true && timerBetweenPatrol<=0)
				{
					CurrentNavPoint=NavPointOne_Right;
					timerBetweenPatrol = timerBetweenPatrolOriginal;
					if (CurrentNavPoint.position.x-transform.position.x <0)
					{
						lookRight=false;
						flip ();
					}
					if (CurrentNavPoint.position.x-transform.position.x >0)
					{
						lookRight=true;
						flip ();
					}
					speed = OriginalSpeed;

				}
				if(navRight == false && timerBetweenPatrol<=0)
				{
					CurrentNavPoint=NavPointTwo_Left;
					timerBetweenPatrol = timerBetweenPatrolOriginal;			
					if (CurrentNavPoint.position.x-transform.position.x <0)
					{
						lookRight=false;
						flip ();
					}
					if (CurrentNavPoint.position.x-transform.position.x >0)
					{
						lookRight=true;
						flip ();
					}
					speed = OriginalSpeed;

				}
			}


		}
	}


	void Update () 
	{
		if (LurePlayer.gameObject.activeInHierarchy ==false)
			LureAttention = false;

		PlayerPos = new Vector3 (ThePlayer.position.x, ThePlayer.position.y, 0);
		myPos = new Vector3 (rayPointOf.position.x, rayPointOf.position.y, 0);
		MortalRay = Physics2D.Linecast (myPos, PlayerPos);

	
		if(MortalRay.collider==true)
		{
			if (MortalRay.collider.tag == "bloc" || MortalRay.collider.tag == "ennemy" || MortalRay.collider.tag == "BlocOeillere")
				Safe = true;
			else
				Safe = false;
			
//		if(SolidOmbreTouch =! null)
//		{
//			if(SolidOmbreTouch.tag=="Ombre")
//			{
//				if(QualityLevel
//				LeftLimit=left
//			}
//
//		}
		}

		//PlayerPos = new Vector3 (ThePlayer.position.x, ThePlayer.position.y, 0);
		//myPos = transform.position;
		Debug.DrawRay(myPos, PlayerPos);



	

		if (somethingHappen == false && timerState>-2)
			timerState -= Time.deltaTime;
		
	
	
		//the actual way to make ennemy move toward a specific Point
		if(Suspicious==true)
		{
		direction = Mathf.Sign (CurrentNavPoint.position.x - transform.position.x);
//		print (Mathf.Sign (CurrentNavPoint.position.x - transform.position.x));
		movPos = new Vector3 (transform.position.x + ((direction/100)*speed*2* Time.deltaTime) , transform.position.y,transform.position.z);
		transform.position = movPos ;
		}
		if(Alert==true)
		{
			direction = Mathf.Sign (CurrentNavPoint.position.x - transform.position.x);
			//		print (Mathf.Sign (CurrentNavPoint.position.x - transform.position.x));
			movPos = new Vector3 (transform.position.x + ((direction/100)*speed*4* Time.deltaTime) , transform.position.y,transform.position.z);
			transform.position = movPos ;
		}
		if(Alert==false && Suspicious==false)
		{
			direction = Mathf.Sign (CurrentNavPoint.position.x - transform.position.x);
			//		print (Mathf.Sign (CurrentNavPoint.position.x - transform.position.x));
			Vector3 movPos = new Vector3 (transform.position.x + ((direction/100)*speed* Time.deltaTime) , transform.position.y,transform.position.z);
			transform.position = movPos ;
		}

		if(InRange==true && LureAttention==false)
		{
			SoundLevel = Vector3.Distance (ThePlayer.transform.position, transform.position);
			if(Alert==false && mySighListernetTemplate.throwAlert==false)
			{
				if ((SoundListerner-DistranctionsSoud) / SoundLevel > 4)
				{
				timerState = 15;
			}	
			}
			if ((SoundListerner - DistranctionsSoud) / SoundLevel > 8) {
				timerState = 24;
				print ("tryeeee");
			} 
		}

			if(Alert==false && mySighListernetTemplate.throwAlert==false)
			{
				if (mySighListernetTemplate.throwSuspicious==true)
				{
				//StartCoroutine (SuspicousMode ());
				timerState = 15;
				}
			}	

			if ( mySighListernetTemplate.throwAlert == true) {
				timerState = 24;
			print ("tryeeee");

			} 

		
		if (InRange == false && mySighListernetTemplate.iSeeYou == false)
			somethingHappen = false;
		else
			somethingHappen = true;

		if(LureAttention==false)
		{
		if(timerState>15)
		{
		AlertInMode();
		}
		if(timerState>0 && timerState<=15 && mySighListernetTemplate.IsawTheLure==false)
		{
		InSuspiciousMode();
			}
			if (timerState <= 0 && routine == false)
				NeutralMode ();
			if (timerState <= 0 && routine == true)
				Routine ();
		}

		if(LureAttention==true)
			LurAttention ();
		

		if (mySighListernetTemplate.IsawTheLure == true)
			LureAttention = true;
	}

	IEnumerator MyAttack()
	{
		while(true)
		{
		if(Alert==true && Vector3.Distance(transform.position, ThePlayer.position)<15)
		{
				print ("Attack");
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
		yield return new WaitForSeconds (15f);
		trapped = false;
		speed = OriginalSpeed;
	}	
//
//
	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Ţrap")
		{
			AkSoundEngine.PostEvent("PC_Rune_Trap_Stunt",gameObject);
			StartCoroutine (TrapMode ());
			Destroy (col.gameObject);
		}
		//detect soundCollider

		if (col.tag == "suspiciouis Sound")
			InRange = true;

		if (col.tag == "falseSoundTrigger")
		{
			LureAttention = true;
		}
//		if (col.gameObject == CurrentNavPointGo && CurrentNavPointGo==NavPoitnThreeGo)
//		{
//			NavPointIGot = 3;
//			StartCoroutine(changenavPoint());
//		}
//
//	if (col.gameObject == CurrentNavPointGo && CurrentNavPointGo==NavPoitnTwoGo)
//	{
//		NavPointIGot = 2;
//		StartCoroutine(changenavPoint());
//	}
//	
//	if (col.gameObject == CurrentNavPointGo && CurrentNavPointGo==NavPoitnOneGo)
//	{
//			print ("There tghere");
//		NavPointIGot = 1;
//		StartCoroutine(changenavPoint());
//	}

	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.tag == "suspiciouis Sound")
			InRange = false;
	}
//
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player" )
			col.gameObject.GetComponent<PlatformerCharacter2D> ().Death ();

//		if(col.gameObject.tag=="SolidOmbre")
//		{
//
//
//		}
	}
//
//
//		IEnumerator changenavPoint()
//	{
//		if(Alert==false || Suspicious==false)
//		{
//			if (NavPointIGot==1)
//		{
//			speed = 0;
//				CurrentNavPoint = NavPointTwo_Left;
//				CurrentNavPointGo = NavPoitnTwoGo;
//				NavPoitnTwoGo.GetComponent<Collider2D> ().enabled = true;
//				NavPoitnOneGo.GetComponent<Collider2D> ().enabled = false;
//			yield return new WaitForSeconds (waitingTimeNavOne);
//				NavPoitnOneGo.GetComponent<Collider2D> ().enabled = false;
//			//Basically if the targer pos is back and the sprite is not flipped, he will flip
//				if (CurrentNavPoint.position.x-transform.position.x <0)
//				{
//					lookRight=false;
//					flip ();
//				}
//				if (CurrentNavPoint.position.x-transform.position.x >0)
//				{
//					lookRight=true;
//					flip ();
//				}
//			
//			speed = OriginalSpeed;
//				yield return new WaitForSeconds (3);
//				NavPoitnOneGo.GetComponent<Collider2D> ().enabled = true;
//
//			yield return null;
//				
//		}
//		if (NavPointIGot==2)
//		{
//			speed = 0;
//				NavPoitnTwoGo.GetComponent<Collider2D> ().enabled = false;
//				NavPoitnOneGo.GetComponent<Collider2D> ().enabled = true;
//
//
//				if(NavPoitnThreeGo==null)
//			{
//					CurrentNavPoint = NavPointOne_Right;
//				CurrentNavPointGo=NavPoitnOneGo;
//				yield return new WaitForSeconds(waitingTimeNavTwo);
//
//					if (CurrentNavPoint.position.x-transform.position.x <0)
//					{
//						lookRight=false;
//						flip ();
//					}
//					if (CurrentNavPoint.position.x-transform.position.x >0)
//					{
//						lookRight=true;
//						flip ();
//					}
//
//			}
//			if(NavPoitnThreeGo!=null)	
//			{
//				CurrentNavPointGo=NavPoitnThreeGo;
//					CurrentNavPoint = NavPointThree_EvenMoreLeft;
//
//
//				yield return new WaitForSeconds(waitingTimeNavTwo);
//
//					if (CurrentNavPoint.position.x-transform.position.x <0)
//					{
//						lookRight=false;
//						flip ();
//					}
//					if (CurrentNavPoint.position.x-transform.position.x >0)
//					{
//						lookRight=true;
//						flip ();
//					}
//
//
//		}
//			speed = OriginalSpeed;
//
//			yield return null;
//
//				
//		}
//		if (NavPointIGot==3)
//		{
//			speed = 0;
//				CurrentNavPoint = NavPointOne_Right;
//
//
//			CurrentNavPointGo = NavPoitnOneGo;
//			yield return new WaitForSeconds(waitingTimeNavThree);
//			//FlipCheckCollider.enabled = true;
//			if (CurrentNavPoint.position.x-transform.position.x <1)
//				flip ();
//			if (CurrentNavPoint.position.x-transform.position.x >0)
//				flip ();
//			speed = OriginalSpeed;
//			yield return null;
//
//			}
//		}
//
//	}
//
//	void flipAlert()
//	{
//		if (Alert == true)
//		{
//			if (CurrentNavPoint.position.x-transform.position.x <0)
//			{
//				lookRight=false;
//				flip ();
//			}
//			if (CurrentNavPoint.position.x-transform.position.x >0)
//			{
//				lookRight=true;
//				flip ();
//			}
//
//		}
//
//	}
	void flip()
	{
		if(lookRight==false)
		{
		GetComponent<SpriteRenderer>().flipX=true;
		FliPBase.transform.eulerAngles=new Vector3(0,0,180);
		}
		else
		{
			GetComponent<SpriteRenderer>().flipX=false;
			FliPBase.transform.eulerAngles=new Vector3(0,0,0);
		}



//

	}

}