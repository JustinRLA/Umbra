using UnityEngine;
using System.Collections;

public class EnnnemyPatrol : MonoBehaviour {
	public float timerState;
	public bool trapped =false;
	//PatrolPart
	public GameObject NavPoitnOneGo;
	public GameObject NavPoitnTwoGo;
	public GameObject NavPoitnThreeGo;

	public Transform CurrentNavPoint;
	public GameObject CurrentNavPointGo;
	public Transform LurePlayer;
	public GameObject SawLureFeedback;
	public Transform returnPoint;

	public bool CloneIsUp;
	public bool CloneIsDown;

	public Transform UpPoint;
	public Transform DownPoint;

	public Transform NavPointOne_Right;
	public Transform NavPointTwo_Left;
	public Transform NavPointThree_EvenMoreLeft;


	public int waitingTimeNavOne;
	public int waitingTimeNavTwo;
	public int waitingTimeNavThree;

	public GameObject Proj;
	public Transform ProjStartPos;
	public GameObject ProjStartObj;

	public GameObject TeleportPointLeft;

	public GameObject TeleportPointRight;

	public Transform TeleportPointLeftTransform;
	public Transform TeleportPointRightTransform;



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
	float direction;
	bool InRange=false;

	public Transform ThePlayer;

	public bool Alert=false;
	public bool Suspicious=false;

	public	float SoundLevel;

	public int attackdelay=1;

	public Transform RightLimit;
	public Transform LeftLimit;
	public GameObject RuneManager;
	LureScript myLureScript;

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
		MyPlayer = GameObject.Find("2DCharacter(Clone)");
		ThePlayer = MyPlayer.transform;
		RuneManager = GameObject.Find ("RuneManager");

		myLureScript = RuneManager.GetComponent<LureScript> ();
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
		InvokeRepeating ("flipAlert",5f,1f);
	}
//	
//	// Update is called once per frame
//
	void Update () {
		

		if(NavPointTwo_Left==null && Alert==false && Suspicious == false)
		{
			if (Vector3.Distance (CurrentNavPoint.position, transform.position) < 2)
				speed = 0;
		}

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
				if(Vector3.Distance(TeleportPointLeftTransform.position,transform.position)<Vector3.Distance(TeleportPointRightTransform.position,transform.position))
				{
					CurrentNavPoint = TeleportPointLeftTransform;
				}
				else
				{
					CurrentNavPoint = TeleportPointRightTransform;
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
					if(Vector3.Distance(TeleportPointLeftTransform.position,transform.position)<Vector3.Distance(TeleportPointRightTransform.position,transform.position))
					{
						CurrentNavPoint = TeleportPointLeftTransform;
					}
					else
					{
						CurrentNavPoint = TeleportPointRightTransform;
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


			Suspicious = false;
			if (trapped == false)
				speed = OriginalSpeed;
			else
				speed = 0;
			if(NavPointTwo_Left!=null)
			{

				if((Vector3.Distance(transform.position,NavPointOne_Right.position))>(Vector3.Distance(transform.position,NavPointTwo_Left.position)))
			{
				CurrentNavPoint = NavPointOne_Right;
				CurrentNavPointGo = NavPoitnOneGo;
				NavPointIGot = 2;
				
			}
				if((Vector3.Distance(transform.position,NavPointOne_Right.position))<=(Vector3.Distance(transform.position,NavPointTwo_Left.position))) 
				
			{
				CurrentNavPoint = NavPointTwo_Left;
				CurrentNavPointGo = NavPoitnTwoGo;
				NavPointIGot = 1;
				}
				
			}

						if(NavPointTwo_Left==null)

						{
							CurrentNavPoint = NavPointOne_Right;
							CurrentNavPointGo = NavPoitnOneGo;
							NavPointIGot = 2;

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
		
//		if (col.tag == "Ţrap")
//		{
//			StartCoroutine (TrapMode ());
//			Destroy (col.gameObject);
//		}
		//detect soundCollider

		if (col.tag == "suspiciouis Sound")
			InRange = true;

		if (col.tag == "falseSoundTrigger")
		{
			mySighListernetTemplate.IsawTheLure = true;
			Suspicious = true;
		}
		if (col.gameObject == CurrentNavPointGo && CurrentNavPointGo==NavPoitnThreeGo)
		{
			NavPointIGot = 3;
			StartCoroutine(changenavPoint());
		}

	if (col.gameObject == CurrentNavPointGo && CurrentNavPointGo==NavPoitnTwoGo)
	{
		NavPointIGot = 2;
		StartCoroutine(changenavPoint());
	}
	
	if (col.gameObject == CurrentNavPointGo && CurrentNavPointGo==NavPoitnOneGo)
	{
		NavPointIGot = 1;
		StartCoroutine(changenavPoint());
	}

	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.tag == "suspiciouis Sound")
			InRange = false;
	}



		IEnumerator changenavPoint()
	{
		if(Alert==false || Suspicious==false)
		{
			if (NavPointIGot==1)
		{
			speed = 0;
				CurrentNavPoint = NavPointTwo_Left;
				CurrentNavPointGo = NavPoitnTwoGo;
				NavPoitnTwoGo.GetComponent<Collider2D> ().enabled = true;
				NavPoitnOneGo.GetComponent<Collider2D> ().enabled = false;
			yield return new WaitForSeconds (waitingTimeNavOne);
				NavPoitnOneGo.GetComponent<Collider2D> ().enabled = false;
			//Basically if the targer pos is back and the sprite is not flipped, he will flip
			if (CurrentNavPoint.position.x-transform.position.x <0 && isFLippe==false)
				flip ();
			if (CurrentNavPoint.position.x-transform.position.x >0 && isFLippe==true)
				flip ();
			
			speed = OriginalSpeed;
				yield return new WaitForSeconds (3);
				NavPoitnOneGo.GetComponent<Collider2D> ().enabled = true;

			yield return null;
				
		}
		if (NavPointIGot==2)
		{
			speed = 0;
				NavPoitnTwoGo.GetComponent<Collider2D> ().enabled = false;
				NavPoitnOneGo.GetComponent<Collider2D> ().enabled = true;


				if(NavPoitnThreeGo==null)
			{
					CurrentNavPoint = NavPointOne_Right;
				CurrentNavPointGo=NavPoitnOneGo;
				yield return new WaitForSeconds(waitingTimeNavTwo);

				if (CurrentNavPoint.position.x-transform.position.x <0 && isFLippe==false)
					flip ();
				if (CurrentNavPoint.position.x-transform.position.x >0 && isFLippe==true)
					flip ();

			}
			if(NavPoitnThreeGo!=null)	
			{
				CurrentNavPointGo=NavPoitnThreeGo;
					CurrentNavPoint = NavPointThree_EvenMoreLeft;


				yield return new WaitForSeconds(waitingTimeNavTwo);

				if (CurrentNavPoint.position.x-transform.position.x <0 && isFLippe==false)
					flip ();
				if (CurrentNavPoint.position.x-transform.position.x >0 && isFLippe==true)
					flip ();

		}
			speed = OriginalSpeed;

			yield return null;

				
		}
		if (NavPointIGot==3)
		{
			speed = 0;
				CurrentNavPoint = NavPointOne_Right;


			CurrentNavPointGo = NavPoitnOneGo;
			yield return new WaitForSeconds(waitingTimeNavThree);
			//FlipCheckCollider.enabled = true;
			if (CurrentNavPoint.position.x-transform.position.x <1 && isFLippe==false)
				flip ();
			if (CurrentNavPoint.position.x-transform.position.x >0 && isFLippe==true)
				flip ();
			speed = OriginalSpeed;
			yield return null;

			}
		}

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