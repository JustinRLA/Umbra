using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererTest : MonoBehaviour {
	RaycastHit2D myRaycast;
		private LineRenderer line; // Reference to LineRenderer
		private Vector3 mousePos;    
		private Vector3 startPos;    // Start position of line
		private Vector3 endPos;    // End position of line
	Vector3 dir;
	public float forcedividable;
	private Vector3 PlayerPos;
	public GameObject myPlayer;
	public Transform PlayerMy;
	public float movespeed;
	public Material OutMat;
	public Material GOodMat;
	public Material InMat;
	public Transform HitTransformPoint;
	public int dividable;
//	public GameObject ObjHit;
	public GameObject TheBeam;
	RaycastHit2D hit;
	public bool goThrougt=false;
	public float timeDIstance;
	RuneManagerScript myRuneManagerScript;
	public GameObject[] theBeams;
	Material TestMat;
	Color ColorBadStart= Color.red;
	Color ColorBadEnd= Color.red;
	public bool TouchGood=false;
	public bool ActivateThisShit=true;
	public	bool touchedBadThing=false;
	public GameObject CamGrap;

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
		theBeams = GameObject.FindGameObjectsWithTag ("grapRegion");

		foreach (GameObject grapRegion in theBeams)
			grapRegion.GetComponent<Collider2D> ().isTrigger = false;

		ActivateThisShit = true;

	}

		void Update () 
	{
		gothrought ();

		if(	ActivateThisShit == true)
			{
			CamGrap.SetActive (true);
		myRaycast = Physics2D.Linecast (mousePos, PlayerPos);

				if(line == null)
		{
					createLine();
		}

		if(line !=null)
		{
					

		mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mousePos.z = 0;
		line.SetPosition(0,PlayerMy.position);
		startPos = PlayerMy.position;
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
					endPos = mousePos;
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
//						print (timeDIstance);
//					print ("SomethingHappe");
						//PlayerMy.GetComponent<Rigidbody2D>().AddForce((HitTransformPoint.position-PlayerMy.position).normalized *9550);

					ActivateThisShit = false;
						myRuneManagerScript.timerTactic = 0;
						Time.timeScale = 1f;
					StartCoroutine (StopGoThrought());
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
				line.material = InMat;
			}
			else
			{
				if(TouchGood==false)
				line.material = OutMat;
				else
					line.material = GOodMat;
			}




					mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
					mousePos.z = 0;
					line.SetPosition(1,mousePos);

				//}

			}
		PlayerPos = new Vector3(PlayerMy.position.x, PlayerMy.position.y,0);

		if(myRaycast.collider==true)
		{
		if (myRaycast.collider.tag == "bloc")
			touchedBadThing = true;
		else
			touchedBadThing = false;

		if (myRaycast.collider.tag == "grapRegion")
						{			
					print ("touchBeam");
			TouchGood = true;
							TheBeam=myRaycast.collider.gameObject;
						}
		else
			TouchGood = false;

				if (TouchGood == true && TheBeam != null && touchedBadThing==false)
					TheBeam.GetComponent<ThisIsMyFeedback> ().myFeedbackOn.SetActive (true);
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
		CamGrap.SetActive (false);
		myPlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		myPlayer.GetComponent<PlatformerCharacter2D> ().enabled = true;
		myPlayer.GetComponent<Platformer2DUserControl> ().enabled = true;
//		print ("this is the end");
		TheBeam.GetComponent<ThisIsMyFeedback> ().myFeedbackOn.SetActive (false);

		GetComponent<LineRendererTest> ().enabled = false;


	}

	IEnumerator StopGoThrought()
	{
		myRuneManagerScript.RuneActivated = false;
		myRuneManagerScript.RuneModeEnabled = false;
		CamGrap.SetActive (false);
		foreach (GameObject grapRegion in theBeams)
			grapRegion.GetComponent<Collider2D> ().isTrigger = true;
		
		TouchGood = false;
		if(TheBeam!=null)
		TheBeam.GetComponent<ThisIsMyFeedback> ().myFeedbackOn.SetActive (false);

		myRuneManagerScript.timerTactic = 0;
		Time.timeScale = 1f;
		myPlayer.GetComponent<Rigidbody2D> ().gravityScale = 0;
		yield return new WaitForSeconds (timeDIstance / dividable);
		myPlayer.GetComponent<Rigidbody2D> ().gravityScale = 3;

	//	yield return new WaitForSeconds (timeDIstance);
		if(TheBeam!=null)
		TheBeam.GetComponent<ThisIsMyFeedback> ().myFeedbackOn.SetActive (false);

		print ("end");
		goThrougt = false;
		//myPlayer.GetComponent<Rigidbody2D> ().isKinematic = false;
		myPlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		myPlayer.GetComponent<PlatformerCharacter2D> ().enabled = true;
		myPlayer.GetComponent<Platformer2DUserControl> ().enabled = true;
		MainCamera.GetComponent<BloomOptimized> ().enabled = false;
		ActivateThisShit = false;
		CamGrap.SetActive (false);

		GetComponent<LineRendererTest> ().enabled = false;
	}


	void gothrought()
	{
		print ("testinggg");
	if(goThrougt==true)
		{
			PlayerMy.GetComponent<Rigidbody2D>().AddForce(dir /forcedividable,ForceMode2D.Impulse);
			print ("fly");
		}

		//	PlayerMy.transform.Translate((HitTransformPoint.position-PlayerMy.position)*2*Time.smoothDeltaTime);
		

	}
	void Cancelation()
	{
		myRuneManagerScript.RuneActivated = false;
		myRuneManagerScript.RuneModeEnabled = false;
		if(TheBeam!=null)
		TheBeam.GetComponent<ThisIsMyFeedback> ().myFeedbackOn.SetActive (false);

		MainCamera.GetComponent<BloomOptimized> ().enabled = false;
		Time.timeScale = 1f;
		ActivateThisShit = false;
		CamGrap.SetActive (false);
		myPlayer.GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 10;
		myPlayer.GetComponent<PlatformerCharacter2D> ().enabled = true;
		myPlayer.GetComponent<Platformer2DUserControl> ().enabled = true;
		if(TheBeam!=null)
		TheBeam.GetComponent<ThisIsMyFeedback> ().myFeedbackOn.SetActive (false);
		foreach (GameObject grapRegion in theBeams)
			grapRegion.GetComponent<Collider2D> ().isTrigger = true;
		
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