using UnityEngine;
using System.Collections;

public class EnnnemyPatrolUpgraded : MonoBehaviour {
	public float timerBetweenPatrolOriginal;
	public float timerBetweenPatrol;
	public float timerState;
	public bool trapped =false;
	//PatrolPart
	public GameObject NavPoitnOneGo;
	public GameObject NavPoitnTwoGo;
	public GameObject NavPoitnThreeGo;
	public bool lookRight;
	public Transform CurrentNavPoint;
	public GameObject CurrentNavPointGo;
	public Transform LurePlayer;
	public GameObject SawLureFeedback;
	public Transform returnPoint;
	public GameObject FliPBase;
	public GameObject StateObj;
	public Transform PointToLookWIthOneNavPoint;

	public bool PlayerIsUp;
	public bool PlayerIsDown;
	Vector3 movPos;


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
	public int waitingTimeNavOne;
	public int waitingTimeNavTwo;
	public int waitingTimeNavThree;

	public GameObject Proj;
	public Transform ProjStartPos;
	public GameObject ProjStartObj;

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



	public bool alertcondition=false;
	public bool suspiciousCondition=false;

	public GameObject PhantomPlayer;
	public Transform PhamomPoint;

	public GameObject MyPlayer;
	public Transform regularSpawnPoint;
	public Transform UpSpawmnPoint;
	public Transform DownSpawnPoint;

	public int FlipScale;
	public bool isFLippe=false;

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
	float direction;
	bool InRange=false;

	public Transform ThePlayer;
	public int EnnemyLevel;
	//1 down 2 regular 3 up


	public bool Alert=false;
	public bool Suspicious=false;

	public	float SoundLevel;

	public int attackdelay=1;
	public Transform RightLimit;
	public Transform LeftLimit;



	public Transform RightLimit_RegularLevel;
	public Transform LeftLimit_RegularLevel;

	public Transform RightLimit_UpLevel;
	public Transform LeftLimit_UpLevel;

	public Transform RightLimit_DownLevel;
	public Transform LeftLimit_DownLevel;

	public GameObject RuneManager;
	RuneManagerScript myRunemanagerScript;
	LureScript myLureScript;

	public bool LureAttention;
	Vector3 ProjDir;
	float angle;

//	// Use this for initialization
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

	void Start () {
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

		MyPlayer = GameObject.Find ("2DCharacter");
		ThePlayer = MyPlayer.transform;
		RuneManager = GameObject.Find ("RuneManager");

		myLureScript = RuneManager.GetComponent<LureScript> ();
		myRunemanagerScript = RuneManager.GetComponent<RuneManagerScript> ();
		gameObject.tag="ennemy";

		//fsm=StateMachine<States>.Initialize.this;
		mySighListernetTemplate = mySighListerner.GetComponent<SightListenerTemplate> ();
		StartCoroutine (MyAttack());
		//InvokeRepeating ("throwdagger", 1f, attackdelay);
		//dynamicLighting=myLight.GetComponent<DynamicLight2D>();
	
		CurrentNavPoint = NavPointOne_Right;

		CurrentNavPointGo = CurrentNavPoint.gameObject;

		OriginalSpeed = speed;
		NavPoitnOneGo = NavPointOne_Right.gameObject;

		if(NavPointTwo_Left!=null)
		NavPoitnTwoGo = NavPointTwo_Left.gameObject;

		if(NavPointThree_EvenMoreLeft!=null)
			NavPoitnThreeGo = NavPointThree_EvenMoreLeft.gameObject;
		//InvokeRepeating ("flipAlert",5f,1f);
	}
//	
//	// Update is called once per frame
//
	void AlertInMode()
	{
		Alert = true;
		Suspicious = false;
		backHome = false;

		if(ThePlayer.position.y<UpPoint.position.y && ThePlayer.position.y>DownPoint.position.y)
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
				if ((transform.position.x - CurrentNavPoint.position.x) < 4 || (transform.position.x - CurrentNavPoint.position.x) > -4)
					speed = 0;
				if ((transform.position.x - CurrentNavPoint.position.x) > 5 || (transform.position.x - CurrentNavPoint.position.x) <= -5)
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
				if ((transform.position.x - CurrentNavPoint.position.x) < 4 || (transform.position.x - CurrentNavPoint.position.x) > -4)
					speed = 0;
				if ((transform.position.x - CurrentNavPoint.position.x) > 5 || (transform.position.x - CurrentNavPoint.position.x) <= -5)
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
				if ((transform.position.x - CurrentNavPoint.position.x) < 4 || (transform.position.x - CurrentNavPoint.position.x) > -5)
					speed = 0;
				if ((transform.position.x - CurrentNavPoint.position.x) > 4 || (transform.position.x - CurrentNavPoint.position.x) <= -5)
					speed = OriginalSpeed;
			}
			else
				speed = 0;

		}
	}

	void InSuspiciousMode()
	{
		Alert = false;
		Suspicious = true;
		backHome = false;

		if(mySighListernetTemplate.IsawTheLure==true)
		{
			timerState = myLureScript.timer;
			LureAttention = true;
			SawLureFeedback.SetActive (true);
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


			if (trapped == false) {
				if ((transform.position.x - CurrentNavPoint.position.x) < 4 || (transform.position.x - CurrentNavPoint.position.x) > -5)
					speed = 0;
				if ((transform.position.x - CurrentNavPoint.position.x) > 4 || (transform.position.x - CurrentNavPoint.position.x) <= -5)
					speed = OriginalSpeed;
			}
			else
				speed = 0;
			
		}
		else
		{
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
					if ((transform.position.x - CurrentNavPoint.position.x) < 4 || (transform.position.x - CurrentNavPoint.position.x) > -5)
						speed = 0;
					if ((transform.position.x - CurrentNavPoint.position.x) > 4 || (transform.position.x - CurrentNavPoint.position.x) <= -5)
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


					if (CurrentNavPoint.position.x-transform.position.x <0 && isFLippe==false)
					{
						lookRight=false;
						flip ();
					}
					if (CurrentNavPoint.position.x-transform.position.x >0 && isFLippe==true)
					{
						lookRight=true;
						flip ();
					}
					if(Vector3.Distance (CurrentNavPoint.position, transform.position) < 5 && EnnemyLevel==1)
						goNormalFlood();
					
					if(Vector3.Distance (CurrentNavPoint.position, transform.position) < 5 && EnnemyLevel==2)
						goUpFloor();
			
				if (trapped == false) {
					if ((transform.position.x - CurrentNavPoint.position.x) < 4 || (transform.position.x - CurrentNavPoint.position.x) > -5)
						speed = 0;
					if ((transform.position.x - CurrentNavPoint.position.x) > 4 || (transform.position.x - CurrentNavPoint.position.x) <= -5)
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
					if ((transform.position.x - CurrentNavPoint.position.x) < 4 || (transform.position.x - CurrentNavPoint.position.x) > -5)
						speed = 0;
					if ((transform.position.x - CurrentNavPoint.position.x) > 4 || (transform.position.x - CurrentNavPoint.position.x) <= -5)
						speed = OriginalSpeed;
				}
				else
					speed = 0;

			}
		}

	
	}

	void NeutralMode()
	{
		if(EnnemyLevel==1 || EnnemyLevel ==3)
			backHome=true;

		Suspicious = false;
		if (trapped == false)
			speed = OriginalSpeed;
		else
			speed = 0;
		if(EnnemyLevel==2)
		{
			if(NavPointTwo_Left!=null)
			{

				if((Vector3.Distance(transform.position,NavPointOne_Right.position))<(Vector3.Distance(transform.position,NavPointTwo_Left.position)))
				{
					CurrentNavPoint = NavPointOne_Right;
					CurrentNavPointGo = NavPoitnOneGo;
					NavPointIGot = 2;
				//	if(NavPointTwo_Left !=null)
//						NavPoitnTwoGo.GetComponent<Collider2D>().enabled = false;
				//	NavPoitnOneGo.GetComponent<Collider2D>().enabled = true;
				}
					else	
					{
					CurrentNavPoint = NavPointTwo_Left;
					CurrentNavPointGo = NavPoitnTwoGo;
					NavPointIGot = 1;
				//	NavPoitnOneGo.GetComponent<Collider2D>().enabled = false;
					//NavPoitnTwoGo.GetComponent<Collider2D>().enabled = true;
				}

			}

			if(NavPointTwo_Left==null)

			{
				CurrentNavPoint = NavPointOne_Right;
				CurrentNavPointGo = NavPoitnOneGo;
				NavPointIGot = 2;

			}


			if (CurrentNavPoint.position.x-transform.position.x <0 && isFLippe==false)
			{
				lookRight=false;
				flip ();
			}
			if (CurrentNavPoint.position.x-transform.position.x >0 && isFLippe==true)
			{
				lookRight=true;
				flip ();
			}


		}

		if(backHome==true)
		{
			PlayerIsUp = false;
			PlayerIsDown = false;
			if(Vector3.Distance(TeleportPointLeftTransform_Actual.position,transform.position)<Vector3.Distance(TeleportPointRightTransform_Actual.position,transform.position))
			{
				CurrentNavPoint = TeleportPointLeftTransform_Actual;
			}
			else
			{
				CurrentNavPoint = TeleportPointRightTransform_Actual;
			}


		if(Vector3.Distance (CurrentNavPoint.position, transform.position) < 3)
			goNormalFlood();
		



		}

	}




	void Update () 
	{
		if(NavPointTwo_Left==null && Alert==false && Suspicious == false)
		{
			if (Vector3.Distance (CurrentNavPoint.position, transform.position) < 2)
			{
				speed = 0;
				print ("near");
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
			print("Close");
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


	

		if (somethingHappen == false && timerState>-2)
			timerState -= Time.deltaTime;
		
		if (Alert == true)
			StateObj.GetComponent<SpriteRenderer> ().color = new Color (0, 1, 1, 1);
		
		if (Suspicious == true)
			StateObj.GetComponent<SpriteRenderer> ().color = new Color (1, 0, 1, 1);
		
		if (Alert == false && Suspicious==false)
			StateObj.GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 1);
	
	
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
		AlertInMode();
		CurrentNavPointGo = null;
			if(NavPointTwo_Left !=null)
			{
			NavPoitnTwoGo.GetComponent<Collider2D>().enabled = false;
			NavPoitnOneGo.GetComponent<Collider2D>().enabled = false;
		}
		}

		if(timerState>0 && timerState<=15 || mySighListernetTemplate.IsawTheLure==true)
		{
		InSuspiciousMode();
		if(timerState>14 &&  timerState<15)
			{
				
				PhantomPlayer.transform.position = MyPlayer.transform.position;
			PhamomPoint.position = ThePlayer.position;

			}
		//	if(PhamomPoint.position.y<

	
			
			}
	//}
		if(timerState>-1 &&  timerState<0)
		{
			NeutralMode ();
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
//
//
	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Ţrap")
		{
			StartCoroutine (TrapMode ());
			Destroy (col.gameObject);
		}
		//detect soundCollider

		if (col.tag == "suspiciouis Sound")
			InRange = true;

		if (col.tag == "falseSoundTrigger")
		{
			mySighListernetTemplate.IsawTheLure = true;
			print ("ISAWLURRRE");
			Suspicious = true;
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
//			FlipScale = FlipScale * -1;
//		transform.localScale = new Vector3 (FlipScale, 1, 1);
		isFLippe =! isFLippe;

	}

}