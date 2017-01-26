using UnityEngine;
using System.Collections;

public class EnnnemyPatrol : MonoBehaviour {
	//PatrolPart
	public GameObject NavPoitnOneGo;
	public GameObject NavPoitnTwoGo;
	public GameObject NavPoitnThreeGo;
	public int waitingTimeNavOne;
	public int waitingTimeNavTwo;
	public int waitingTimeNavThree;
	flipIfNecessary myflipIsNecessary;

	public GameObject PhantomPlayer;
	public Transform PhamomPoint;

	public GameObject MyPlayer;

	public int FlipScale;
	bool isFLippe=false;
	public int NavPointIGot;
	public float speed;
	public Transform NavPointOne;
	public Transform NavPointTwo;
	public Transform NavPointThree;
	public Transform CurrentNavPoint;
	public GameObject CurrentNavPointGo;
	public float OriginalSpeed;
	Vector2 dir;
	Vector2 target;
	Vector3 NewPos;
	GameObject myLight;
	SightListenerTemplate mySighListernetTemplate;
	public GameObject mySighListerner;
	public float delay = 10f;

	// SoundDetection Part
	int AlertCondition;

	public int DistranctionsSoud;
	int SoundListerner=50;

	bool InRange=false;

	public Transform ThePlayer;

	public bool Alert=false;
	public bool Suspicious=false;
	public	float SoundLevel;
	public int attackdelay=1;

//
//	// Use this for initialization
	void Start () {
		mySighListernetTemplate = mySighListerner.GetComponent<SightListenerTemplate> ();
		StartCoroutine (MyAttack());
		//InvokeRepeating ("throwdagger", 1f, attackdelay);
		//dynamicLighting=myLight.GetComponent<DynamicLight2D>();
	
		CurrentNavPoint = NavPointOne;
		CurrentNavPointGo = CurrentNavPoint.gameObject;
		OriginalSpeed = speed;
		NavPoitnOneGo = NavPointOne.gameObject;
		NavPoitnTwoGo = NavPointTwo.gameObject;

		if(NavPointThree!=null)
		NavPoitnThreeGo = NavPointThree.gameObject;
		InvokeRepeating ("flipAlert",5f,1f);
	}
//	
//	// Update is called once per frame
//
	void Update () {
		if (mySighListernetTemplate.throwSuspicious == true)
			StartCoroutine (SuspicousMode ());
		
		if (mySighListernetTemplate.throwAlert == true)
		{
			
			StopCoroutine (SuspicousMode ());
			StartCoroutine (AlerMode ());

		}


		if (Alert == true)
			GetComponent<SpriteRenderer> ().color = new Color (0, 1, 1, 1);
		if (Suspicious == true)
			GetComponent<SpriteRenderer> ().color = new Color (1, 0, 1, 1);
		if (Alert == false && Suspicious==false)
			GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 1);
	
	
//		StartCoroutine(MyAttack());
		// to make the script work with a transform.right. work pretty much as well as the 
		//official solution, we can consider this one as well

//		transform.Translate(transform.right * Time.deltaTime*speed);
//
//		if(Alert==true||Suspicious==true)
//		{	
//		if (CurrentNavPoint.position.x-transform.position.x <0 && isFLippe==false)
//			flip ();
//		if (CurrentNavPoint.position.x-transform.position.x >0 && isFLippe==true)
//			flip ();
//			
//			if (Vector3.Distance (CurrentNavPoint.position, transform.position)<1)
//				speed = 0;
//			else
//				speed = OriginalSpeed;
//
	//	}

		//the actual way to make ennemy move toward a specific Point

		float direction = Mathf.Sign (CurrentNavPoint.position.x - transform.position.x);
//		print (Mathf.Sign (CurrentNavPoint.position.x - transform.position.x));
		Vector3 movPos = new Vector3 (transform.position.x + ((direction/100)*speed) , transform.position.y,transform.position.z);
		transform.position = movPos;

		// A test for moving on the x pos with the vector 2 dont work so far  
//		transform.Translate(speed,0,0);
//		Vector3 dirEction = ((CurrentNavPoint.position.x - transform.position.x),).normalized;

				//Test1

//		dir =(CurrentNavPoint.position- transform.position);
//
//		transform.position += dir*Time.deltaTime*speed;

					//Test2

		//dir =new Vector2(CurrentNavPoint.position.x - transform.position.x),transform.position.y);

//		dir =new Vector2(CurrentNavPoint.position.x,transform.position.y);
//
//		transform.position += dir*Time.deltaTime*speed;

		//
					//test3

//		NewPos =(CurrentNavPoint.position);
//
//		dir = transform.position;
//		NewPos.x = dir.x * Time.deltaTime;
//		transform.position = NewPos;

		if(Alert==true)
		{
			CurrentNavPoint = ThePlayer;
		}


//		if(Alert==true && Vector3.Distance(transform.position, ThePlayer.position)<4)
//		{
//			speed = 0;
//		}
//		if(Alert==true && Vector3.Distance(transform.position, ThePlayer.position)>=4)
//		{
//			speed = OriginalSpeed;
//		}
//
		if(Alert==true) 
			{
			if((transform.position.x-CurrentNavPoint.position.x) <5 ||  (transform.position.x-CurrentNavPoint.position.x)>-5)
			speed = 0;
			if ( (transform.position.x-CurrentNavPoint.position.x) >5 || (transform.position.x-CurrentNavPoint.position.x)<=-5)
			speed = OriginalSpeed;
		}


//		if(Alert==true && (transform.position.x-CurrentNavPoint.position.x)>=3 || Alert==true && (transform.position.x-CurrentNavPoint.position.x)>-3)
//		{
//			speed = OriginalSpeed;
//		}
//
//		if(Suspicious==true && Vector3.Distance(transform.position, CurrentNavPoint.position)<4)
//		{
//			speed = 0;
//		}
//
//		if(Suspicious==true && Vector3.Distance(transform.position, CurrentNavPoint.position)>=4)
//		{
//			speed = OriginalSpeed;
//		}

			if(Suspicious==true)
		{
			if( (transform.position.x-CurrentNavPoint.position.x) <5 || (transform.position.x-CurrentNavPoint.position.x) > -5)
			speed = 0;

			if((transform.position.x-CurrentNavPoint.position.x)>=5 || (transform.position.x-CurrentNavPoint.position.x) <=-5)
			speed = OriginalSpeed;
		}
		if(InRange==true)
		{
			SoundLevel = Vector3.Distance (ThePlayer.transform.position, transform.position);
			if(Alert==false)
			{
				if ((SoundListerner-DistranctionsSoud) / SoundLevel > 4 || mySighListernetTemplate.throwAlert==false)
				StartCoroutine (SuspicousMode ());
			}	
			//print ((SoundListerner / SoundLevel));
			if ((SoundListerner-DistranctionsSoud) / SoundLevel > 8 || mySighListernetTemplate.throwSuspicious==true)
			{
				StopCoroutine (SuspicousMode ());
				StartCoroutine (AlerMode ());
			}	
		}
	}

//	void throwdagger()
//	{
//		print ("dagger");
//		}	

	IEnumerator MyAttack()
	{
		while(true)
		{
		yield return new WaitForSeconds (attackdelay);
		if(Alert==true && Vector3.Distance(transform.position, ThePlayer.position)<8)
		{
			GetComponent<AudioSource> ().Play();
			attackdelay = 2;
			//StartCoroutine (MyAttack ());
		//	yield return null;
			}	
		}	
	}	
	void OnTriggerEnter2D (Collider2D col) {
		//detect soundCollider
		if (col.tag == "suspiciouis Sound")
			InRange = true;

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
				CurrentNavPoint = NavPointTwo;
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
					CurrentNavPoint = NavPointOne;
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
				CurrentNavPoint = NavPointThree;


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
			CurrentNavPoint = NavPointOne;


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
	//		
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
//
//
	public IEnumerator SuspicousMode()
	{

			Suspicious = true; 

		NavPoitnTwoGo.GetComponent<Collider2D>().enabled = false;
		NavPoitnOneGo.GetComponent<Collider2D>().enabled = false;

		//speed = 7;
		PhantomPlayer.transform.position = MyPlayer.transform.position;
		PhamomPoint.position = ThePlayer.position;
		CurrentNavPoint = PhamomPoint;
		CurrentNavPointGo = null;
//		if (transform.position == CurrentNavPoint.position)
//			speed = 0;
	
	if (CurrentNavPoint.position.x-transform.position.x <1 && isFLippe==false)
			flip ();
	if (CurrentNavPoint.position.x-transform.position.x >0 && isFLippe==true)
			flip ();
		
		yield return new WaitForSeconds(delay);
		if(mySighListernetTemplate.iSeeYou==false)
		Suspicious=false;
		if(Suspicious==false)
		{
			if((Vector3.Distance(transform.position,NavPointOne.position))>(Vector3.Distance(transform.position,NavPointTwo.position)))
			{
		CurrentNavPoint = NavPointOne;
		CurrentNavPointGo = NavPoitnOneGo;
				NavPointIGot = 2;
				NavPoitnTwoGo.GetComponent<Collider2D>().enabled = false;
				NavPoitnOneGo.GetComponent<Collider2D>().enabled = true;

			}
			if((Vector3.Distance(transform.position,NavPointOne.position))<=(Vector3.Distance(transform.position,NavPointTwo.position)))
				
			{
				CurrentNavPoint = NavPointTwo;
				CurrentNavPointGo = NavPoitnTwoGo;
				NavPointIGot = 1;
				NavPoitnOneGo.GetComponent<Collider2D>().enabled = false;
				NavPoitnTwoGo.GetComponent<Collider2D>().enabled = true;


			}

		}

		
		speed = OriginalSpeed;
		if (CurrentNavPoint.position.x-transform.position.x <0 && isFLippe==false)
			flip ();
		if (CurrentNavPoint.position.x-transform.position.x >0 && isFLippe==true)
			flip ();
		//return null;
		yield return null;
	}
//
//
	public IEnumerator AlerMode()
	{	
		Alert = true;
		Suspicious = false;
		CurrentNavPointGo = null;

		print ("NumberOfAlert");
		NavPoitnTwoGo.GetComponent<Collider2D>().enabled = false;
		NavPoitnOneGo.GetComponent<Collider2D>().enabled = false;

	if (CurrentNavPoint.position.x-transform.position.x <1 && isFLippe==false)
		flip ();
	if (CurrentNavPoint.position.x-transform.position.x >0 && isFLippe==true)
			flip ();


		print ("How Many");
		//Alert = true;
		yield return new WaitForSeconds(delay);
		if(mySighListernetTemplate.iSeeYou==false)
		{	
		Alert=false;
		StartCoroutine (SuspicousMode());
		}
//		if (CurrentNavPoint.position.x-transform.position.x <0 && isFLippe==false)
//			flip ();
//		if (CurrentNavPoint.position.x-transform.position.x >0 && isFLippe==true)
//			flip ();
//		
		//speed = OriginalSpeed;

		attackdelay=1;
		yield return null;
	}
//
//
}