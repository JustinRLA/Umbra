using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineRendererTest : MonoBehaviour {
	RaycastHit2D myRaycast;
		private LineRenderer line; // Reference to LineRenderer
		private Vector3 mousePos;    
	Vector3 dir;
	public float forcedividable;
	private Vector3 PlayerPos;
	public GameObject myPlayer;
	public Transform PlayerMy;
	public Material OutMat;
	public Material GOodMat;
	public Material InMat;
	public Transform HitTransformPoint;
	public int dividable;
	public LayerMask myMask;
//	public GameObject ObjHit;
	public GameObject TheBeam;
	RaycastHit2D hit;
	public bool goThrougt=false;
	public float timeDIstance;
	RuneManagerScript myRuneManagerScript;
	public GameObject[] theBeams;
	Material TestMat;
	public bool TouchGood=false;
	public bool ActivateThisShit=true;
	public	bool touchedBadThing=false;
	public GameObject CamGrap;
	bool redhaveplayed;
	bool greenhaveplayed;
	public GameObject BannerBase;
	RaycastHit2D myStraightraycast;

	GameObject RuneFull;
	float direction;
	Vector3 movPos;
	Vector3 Mousepos;

	Ray ray;
	public GameObject MainCamera;

	void Start()
	{
		
		MainCamera = GameObject.Find ("Main Camera");
		myRuneManagerScript = GetComponent<RuneManagerScript> ();
		myPlayer = GameObject.Find ("2DCharacter(Clone)");
		PlayerMy = myPlayer.transform;

	}
	public void IsActivated()
	{
		TheBeam = null;
		TouchGood = false;
		BannerBase = null;
		RuneFull = GameObject.Find ("AccrochageImageFull");
		RuneFull.GetComponent<Image> ().enabled = true;
		myRuneManagerScript = GetComponent<RuneManagerScript> ();
		AkSoundEngine.PostEvent ("PC_Rune_Accrochage_Equip", gameObject);
		myRuneManagerScript.RuneActivated = true;
		theBeams = GameObject.FindGameObjectsWithTag ("grapRegion");

		foreach (GameObject grapRegion in theBeams)
			grapRegion.GetComponent<Collider2D> ().isTrigger = false;

		ActivateThisShit = true;
		TheBeam = null;
		TouchGood = false;
		BannerBase = null;
		touchedBadThing = true;
	//	CamGrap.SetActive (true);


	}

		void Update () 
	{
		if (ActivateThisShit == false) {
			TouchGood = false;
		}
		gothrought ();

		if(	ActivateThisShit == true)
			{
			Mousepos = (Input.mousePosition);
			Mousepos.z = 0;

			ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			myStraightraycast = Physics2D.Raycast(ray.origin, ray.direction,Mathf.Infinity);



			myRaycast = Physics2D.Linecast (PlayerPos,mousePos,myMask);

				if(line == null)
		{
					createLine();
		}

		if(line !=null)
		{
					

		mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mousePos.z = 0;
		line.SetPosition(0,PlayerMy.position);
		}
			if(Input.GetMouseButtonDown(1))
			{
			if(line)
			{
					Destroy (line);	
				Cancelation();
			}
			}

			if(Input.GetMouseButtonDown(0))
			{
				if(TouchGood==false || touchedBadThing==true)
				{
				if(line)
				{
					Destroy (line);	
					Cancelation();
				}
			}
			}
			if(Input.GetMouseButtonDown(0))
			{
				if(line)
				{
					mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
					mousePos.z = 0;
					line.SetPosition(1,mousePos);
					//addColliderToLine();
				Destroy (line);

				if (TouchGood == true && touchedBadThing == false)
				{
						if(TheBeam!=null)
						TheBeam.GetComponent<ThisIsMyFeedback> ().myFeedbackOn.SetActive (false);

					HitTransformPoint.position = new Vector3 (myRaycast.point.x, myRaycast.point.y, 0);
//					HitTransformPoint.position.y = myRaycast.point.y;
//					HitTransformPoint.position.x = myRaycast.point.x;
					//PlayerMy.GetComponent<Rigidbody2D>().AddForce((HitTransformPoint.position-PlayerMy.position)*20000*Time.smoothDeltaTime);
					goThrougt=true;
						dir =  HitTransformPoint.position-PlayerMy.position;
					timeDIstance = Vector3.Distance (PlayerMy.position,HitTransformPoint.position);
						PlayerMy.GetComponent<VeryfyCol> ().enabled = true;
//						print (timeDIstance);
//					print ("SomethingHappe");
						//PlayerMy.GetComponent<Rigidbody2D>().AddForce((HitTransformPoint.position-PlayerMy.position).normalized *9550);
						BannerBase=TheBeam.transform.parent.gameObject;
						PlayerMy.GetComponent<VeryfyCol>().BeamToTouch=BannerBase;
						if (BannerBase.GetComponent<maxHauteurLadder> ().CheckRight == true && myPlayer.GetComponent<PlatformerCharacter2D> ().m_FacingRight == false)
							myPlayer.GetComponent<PlatformerCharacter2D> ().Flip ();
						else
							if (BannerBase.GetComponent<maxHauteurLadder> ().CheckRight == false && myPlayer.GetComponent<PlatformerCharacter2D> ().m_FacingRight == true)
								myPlayer.GetComponent<PlatformerCharacter2D> ().Flip ();
						
					ActivateThisShit = false;
						myRuneManagerScript.timerTactic = 0;
						Time.timeScale = 1f;
						myPlayer.GetComponent<Rigidbody2D> ().gravityScale = 0;

						Destroy (line);
					//	End ();
				}
			else
			Destroy (line);

					line = null;

				}
			}

				if(line)
				{
			
			if (touchedBadThing == true)
			{
					TouchGood = false;
				line.material = InMat;
					if (redhaveplayed == false) {
						AkSoundEngine.PostEvent ("PC_Rune_Accrochage_Red", gameObject);
						redhaveplayed = true;
					}
			}
			else
			{
					redhaveplayed = false;
					if (TouchGood == false) {
						line.material = OutMat;
					
					}
						else
					line.material = GOodMat;
			}




					mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
					mousePos.z = 0;
					line.SetPosition(1,mousePos);

				//}

			}
		PlayerPos = new Vector3(PlayerMy.position.x, PlayerMy.position.y,0);

			if (myRaycast.collider == null || myRaycast.collider.tag != "grapRegion") {
				TouchGood = false;
				TheBeam = null;
				touchedBadThing = false;
				BannerBase = null;
			}

		if(myRaycast.collider==true)
		{

		if (myRaycast.collider.tag == "bloc")
			touchedBadThing = true;
		else
			touchedBadThing = false;

				if (myStraightraycast.collider.tag == "grapRegion" && touchedBadThing == false) {			
					print ("touchBeam");
					TouchGood = true;
					TheBeam = myStraightraycast.collider.gameObject;
				} else {
					TouchGood = false;
					print ("nioop");
					TheBeam = null;
				}
				if (myStraightraycast.collider.tag != "grapRegion") {
					TouchGood = false;
					TheBeam = null;

				}
				if (TouchGood == true && TheBeam != null && touchedBadThing == false) {
					TheBeam.GetComponent<ThisIsMyFeedback> ().myFeedbackOn.SetActive (true);
					if (greenhaveplayed == false) {
						AkSoundEngine.PostEvent ("PC_Rune_Accrochage_Green", gameObject);
						greenhaveplayed = true;
					}
				
				}
							else
								greenhaveplayed=false;

					if(TheBeam!=null)
				{
				if(TouchGood==false || touchedBadThing==true)
					TheBeam.GetComponent<ThisIsMyFeedback> ().myFeedbackOn.SetActive (false);
				}
				}
		}

		}
		// Following method creates line runtime using Line Renderer component
		private void createLine()
		{
		if(ActivateThisShit==true)
		{
//
//		if (touchedBadThing == false)
//		{
			line = new GameObject("Line").AddComponent<LineRenderer>();
			line.material =  OutMat;
			line.material.color = Color.red;

			line.SetVertexCount(2);
			line.SetWidth(0.1f,0.1f);
			//line.SetColors(Color.black, Color.black);
			line.useWorldSpace = true;    
		}
	}
		// Following method adds collider to created line
	void End()
	{
		myRuneManagerScript.RuneActivated = false;
		myRuneManagerScript.RuneModeEnabled = false;

		TouchGood = false;
		TheBeam.GetComponent<ThisIsMyFeedback> ().myFeedbackOn.SetActive (false);

		MainCamera.GetComponent<BloomOptimized> ().enabled =false;
		ActivateThisShit = false;
		//CamGrap.SetActive (false);
		myPlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		myPlayer.GetComponent<PlatformerCharacter2D> ().enabled = true;
		myPlayer.GetComponent<Platformer2DUserControl> ().enabled = true;
//		print ("this is the end");
		TheBeam.GetComponent<ThisIsMyFeedback> ().myFeedbackOn.SetActive (false);
		myRuneManagerScript.RuneActivated = false;
		AkSoundEngine.PostEvent ("PC_Action_slowMo_End", gameObject);

		GetComponent<LineRendererTest> ().enabled = false;


	}


	public void StopThisThing()
	{
		StartCoroutine (StopGoThrought ());
	}

	IEnumerator StopGoThrought()
	{
		
		yield return new WaitForSeconds (0.1f);
		myPlayer.layer = 13;

		AkSoundEngine.PostEvent ("PC_Rune_Accrochage_Use", gameObject);
		myRuneManagerScript.RuneActivated = false;
		myRuneManagerScript.RuneModeEnabled = false;
		//CamGrap.SetActive (false);
		foreach (GameObject grapRegion in theBeams)
			grapRegion.GetComponent<Collider2D> ().isTrigger = true;
		
		TouchGood = false;
		if(TheBeam!=null)
		TheBeam.GetComponent<ThisIsMyFeedback> ().myFeedbackOn.SetActive (false);

		myRuneManagerScript.timerTactic = 0;
		RuneFull.GetComponent<Image> ().enabled = false;
		myRuneManagerScript.TacticTimer.SetActive (true);
		Time.timeScale = 1f;

	//	yield return new WaitForSeconds (timeDIstance);
		if(TheBeam!=null)
		TheBeam.GetComponent<ThisIsMyFeedback> ().myFeedbackOn.SetActive (false);

		print ("end");
		goThrougt = false;
		myPlayer.GetComponent<Rigidbody2D> ().gravityScale = 3;

		//myPlayer.GetComponent<Rigidbody2D> ().isKinematic = false;
		myPlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		myPlayer.GetComponent<PlatformerCharacter2D> ().enabled = true;
		myPlayer.GetComponent<Platformer2DUserControl> ().enabled = true;
		MainCamera.GetComponent<BloomOptimized> ().enabled = false;
		ActivateThisShit = false;
		//CamGrap.SetActive (false);
		myRuneManagerScript.RuneActivated = false;
		AkSoundEngine.PostEvent ("PC_Action_slowMo_End", gameObject);

		TouchGood = false;

		BannerBase = null;
		TheBeam = null;
		GetComponent<LineRendererTest> ().enabled = false;
	}


	void gothrought()
	{
//		print ("testinggg");
	if(goThrougt==true)
		{

//					direction = Mathf.Sign (HitTransformPoint.position.x - PlayerMy.transform.position.x);
//					//		print (Mathf.Sign (CurrentNavPoint.position.x - transform.position.x));
//					movPos = new Vector3 (transform.position.x + ((direction/100)*4* Time.deltaTime) , transform.position.y,transform.position.z);
			PlayerMy.transform.position +=dir*Time.deltaTime ;

		//	PlayerMy.GetComponent<Rigidbody2D>().AddForce((dir /forcedividable) , ForceMode2D.Impulse+1);
			print ("fly");
		}

		//	PlayerMy.transform.Translate((HitTransformPoint.position-PlayerMy.position)*2*Time.smoothDeltaTime);
		

	}
	void Cancelation()
	{
		TouchGood = false;
		BannerBase = null;
		TheBeam = null;

		RuneFull.GetComponent<Image> ().enabled = false;

		myRuneManagerScript.RuneActivated = false;
		myRuneManagerScript.RuneModeEnabled = false;
		if(TheBeam!=null)
		TheBeam.GetComponent<ThisIsMyFeedback> ().myFeedbackOn.SetActive (false);

		MainCamera.GetComponent<BloomOptimized> ().enabled = false;
		Time.timeScale = 1f;
		ActivateThisShit = false;
		//CamGrap.SetActive (false);
		myPlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		myPlayer.GetComponent<PlatformerCharacter2D> ().enabled = true;
		myPlayer.GetComponent<Platformer2DUserControl> ().enabled = true;
		if(TheBeam!=null)
		TheBeam.GetComponent<ThisIsMyFeedback> ().myFeedbackOn.SetActive (false);
		foreach (GameObject grapRegion in theBeams)
			grapRegion.GetComponent<Collider2D> ().isTrigger = true;
		TouchGood = false;
		BannerBase = null;
		TheBeam = null;

		GetComponent<LineRendererTest> ().enabled = false;

	}

//		private void addColliderToLine()
//		{
//		BoxCollider2D col = gameObject.AddComponent<BoxCollider2D> ();
//	//BoxCollider2D col = new GameObject("Collider").AddComponent<BoxCollider2D> ();
//		col.GetComponent<Collider2D> ().isTrigger = true;
//	
//			col.transform.parent = line.transform; // Collider is added as child object of line
//			float lineLength = Vector3.Distance (startPos, endPos); // length of line
//			col.size = new Vector3 (lineLength, 0.1f, 1f); // size of collider is set where X is length of line, Y is width of line, Z will be set as per requirement
//			Vector3 midPoint = (startPos + endPos)/2;
//			col.transform.position = midPoint; // setting position of collider object
//			// Following lines calculate the angle between startPos and endPos
//			float angle = (Mathf.Abs (startPos.y - endPos.y) / Mathf.Abs (startPos.x - endPos.x));
//			if((startPos.y<endPos.y && startPos.x>endPos.x) || (endPos.y<startPos.y && endPos.x>startPos.x))
//			{
//				angle*=-1;
//			}
//			angle = Mathf.Rad2Deg * Mathf.Atan (angle);
//			col.transform.Rotate (0, 0, angle);
//		}
	void OnTriggerEnter2D(Collider2D col)
	{

		//	Destroy (gameObject);
		}
	void OnTriggerStay2D(Collider2D col)
	{
		print("test");	
		//Destroy (gameObject);
	}
}
	//	- See more at: http://www.theappguruz.com/blog/add-collider-to-line-renderer-unity#sthash.Rp6rug8G.dpuf