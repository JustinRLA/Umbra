using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererTest : MonoBehaviour {
	RaycastHit2D myRaycast;
		private LineRenderer line; // Reference to LineRenderer
		private Vector3 mousePos;    
		private Vector3 startPos;    // Start position of line
		private Vector3 endPos;    // End position of line
	private Vector3 PlayerPos;
	public GameObject myPlayer;
	public Transform PlayerMy;
	public Material OutMat;
	public Material GOodMat;
	public Material InMat;
	public Transform HitTransformPoint;
	RaycastHit2D hit;
	public bool goThrougt=false;
	public float timeDIstance;
	RuneManagerScript myRuneManagerScript;

	Material TestMat;
	Color ColorBadStart= Color.red;
	Color ColorBadEnd= Color.red;
	public bool TouchGood=false;
	public bool ActivateThisShit=true;
	public	bool touchedBadThing=false;
	void Start()
	{
		myRuneManagerScript = GetComponent<RuneManagerScript> ();
		myPlayer = GameObject.Find("2DCharacter");
		PlayerMy = myPlayer.transform;

	}
	public void IsActivated()
	{
		ActivateThisShit = true;
	}

		void Update () 
	{
		if(	ActivateThisShit == true)
			{
		gothrought ();

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
					HitTransformPoint.position = new Vector3 (myRaycast.point.x, myRaycast.point.y, 0);
//					HitTransformPoint.position.y = myRaycast.point.y;
//					HitTransformPoint.position.x = myRaycast.point.x;
					//PlayerMy.GetComponent<Rigidbody2D>().AddForce((HitTransformPoint.position-PlayerMy.position)*20000*Time.smoothDeltaTime);
					goThrougt=true;
					timeDIstance = Vector3.Distance (PlayerMy.position,HitTransformPoint.position);
					print ("SomethingHappe");
					ActivateThisShit = false;
					StartCoroutine (StopGoThrought());
					Destroy (line);

				}
			else
			Destroy (line);

					line = null;

				}
			}
//			else if(Input.GetMouseButton(0))
//			{
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
//		if(Physics.Raycast(PlayerMy.position,PlayerMy.position-endPos, out myRaycast))
//		{
//			print("Work MOtherfucker");
//			if(myRaycast.transform.gameObject.tag=="Player")
//				print("Work MOtherfucker");
//
//			if(myRaycast.transform.gameObject.tag=="Untagged")
//				print("Work MOtherfucker");
//		}
		PlayerPos = new Vector3(PlayerMy.position.x, PlayerMy.position.y,0);
		// On mouse down new line will be created 
		//			if(Input.GetMouseButtonDown(0))
		if(myRaycast.collider==true)
		{
		if (myRaycast.collider.tag == "Untagged")
			touchedBadThing = true;
		else
			touchedBadThing = false;

		if (myRaycast.collider.tag == "grapRegion")
			TouchGood = true;
		else
			TouchGood = false;
		}
		}
			//line.GetComponent<Renderer> ().material.color = Color.red;
			//line.SetColors(Color.red, Color.red);
		//}

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
		//line.material =  new Material(Shader.Find("Unlit/Texture"));
			line.material =  OutMat;
//			line.SetColors(Color.black, Color.black);
			line.material.color = Color.red;
//
//		}
//		if (touchedBadThing == true)
//		{
//			line = new GameObject("Line").AddComponent<LineRenderer>();
//
////			line.material =  new Material(Shader.Find("Unlit/Texture"));
////			line.SetColors(Color.red, Color.red);
//			line.material=InMat;
//
//		}

			line.SetVertexCount(2);
			line.SetWidth(0.1f,0.1f);
			//line.SetColors(Color.black, Color.black);
			line.useWorldSpace = true;    
		}
	}
		// Following method adds collider to created line
	IEnumerator StopGoThrought()
	{
		TouchGood = false;
		myRuneManagerScript.timerTactic = myRuneManagerScript.ActualTactic;
		Time.timeScale = 1f;
		myPlayer.GetComponent<Rigidbody2D> ().isKinematic = true;
		yield return new WaitForSeconds (timeDIstance / 15);
		goThrougt = false;
		myPlayer.GetComponent<Rigidbody2D> ().isKinematic = false;
		GetComponent<LineRendererTest> ().enabled = false;
	}


	void gothrought()
	{
		if(goThrougt==true)
			PlayerMy.transform.Translate((HitTransformPoint.position-PlayerMy.position)*2*Time.smoothDeltaTime);
		

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