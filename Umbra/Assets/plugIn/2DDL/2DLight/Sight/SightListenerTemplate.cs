using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class SightListenerTemplate : MonoBehaviour {

	// * NOTE: WHEN YOU'RE TESTING EVENTS IN EDITOR, BE SURE THAT GAME WINDOW IS ACTIVE AND VISIBLE 

	// ** DECLARE PUBLIC METHODS FOR LISTENERS

	// *** READ FIRST: http://jacksondunstan.com/articles/3335  (UnityEvents vs C# native Events performance)
//	bool detect =false;
	public GameObject EnnemyBase;
	public bool iSeeYou;
	private bool check = false;
	public bool throwSuspicious;
	public bool throwAlert;
	public GameObject mySight;
	public GameObject RuneManager;
	LureScript myLureScript;
	public bool IsawTheLure=false;
	public GameObject LurePlayer;
	public int TypeOfObj;
	// 1= Ennemy....2= Camera....3= Light
	public GameObject PlayerView;
	Collider2D ViewCol;
	public bool inCam;
	public bool LureInCam;
	Vector3 Camdir;
	float angle;
	public Transform thePlayer;
	public GameObject myBoute;
	public GameObject EnnemyOne;
	public GameObject EnnemyTwo;
	public GameObject EnnemyThree;
	public GameObject EnnemyFour;
	public GameObject EnnemyFive;
	//public Material OutofSightMat;
	//public Material InSightMat;

	public GameObject dangerLight;
	public GameObject SuspiciousLight;
	public bool InAlert;
	public GameObject NoDangerLight;
	public GameObject NormalGlobe;
	public GameObject DangeGlobe;


	public void Start()
	{
		PlayerView = GameObject.Find ("ViewTrigger");
			//LurePlayer=GameObject.Find("2DCharacterShadow");
//		RuneManager = GameObject.Find ("RuneManager");
		if (TypeOfObj == 3)
			ViewCol = PlayerView.GetComponent<Collider2D> ();
		//myLureScript = RuneManager.GetComponent<LureScript> ();
		//print (gameObject.name);
		//EnnemyBase=
//		print(transform.parent.name);

		if(!check)
		{
			check = true;
			BoxCollider2D box2d = GetComponent<BoxCollider2D> ();
			if (box2d == null) {
				PolygonCollider2D pol2d = GetComponent<PolygonCollider2D>();
				if(pol2d == null)
					gameObject.AddComponent<BoxCollider2D>();
			}

		}

	}

	//IEnumerator Camdetection()



	void Update()
	{
		if(TypeOfObj==1)
		{

//		if (myLureScript.Active== false)
//			IsawTheLure = false;
		
		if(mySight==null)
		{
			iSeeYou = false;
		throwSuspicious = false;
		throwAlert = false;
		}

			if (EnnemyBase.GetComponent<EnnnemyPatrolUpgraded> () == null)
			iSeeYou = false;

			if (EnnemyBase.GetComponent<EnnnemyPatrolUpgraded> ().Alert == true)
			throwSuspicious = false;
		}
		if(TypeOfObj==2)
		{
			if (InAlert == true)
			{
				DangeGlobe.SetActive (true);
				NormalGlobe.SetActive (false);
			}
			if (InAlert == false)
			{
				DangeGlobe.SetActive (false);
				NormalGlobe.SetActive (true);
			}
			if(inCam==true && InAlert==false)
			{
				LureInCam = false;
//				Camdir = thePlayer.position - transform.position;
//				angle = Mathf.Atan2 (Camdir.y, Camdir.x) * Mathf.Rad2Deg;
//				myBoute.transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
				//mySight.GetComponent<Renderer>().material=InSightMat;
				dangerLight.SetActive(false);
				SuspiciousLight.SetActive(true);
				NoDangerLight.SetActive(false);

				}
			if(inCam==false && InAlert==false)
				
			{
				dangerLight.SetActive(false);
				SuspiciousLight.SetActive(false);
				NoDangerLight.SetActive(true);

			}
	
			}
		}



	public void myListener_onEnter(GameObject go){
//		print("There Something");
		if(TypeOfObj==1)
		{
		if(throwAlert==false || throwSuspicious==false)
		{
			if (go.tag == "LurePlayer" ) {

				print ("SAWWWWWWWWWWWWWWWWWWWWWWW");
				IsawTheLure = true;
					EnnemyBase.GetComponent<EnnnemyPatrolUpgraded> ().Suspicious = true;

			} 
//			else
//				IsawTheLure = false;

		}



		if (go.tag == "Player")
		{
//			print ("One");
			IsawTheLure=false;
			iSeeYou = true;
			//if(transform.parent.GetComponent<EnnnemyPatrol>().Alert==false)
			StartCoroutine (InSight ());
		}
		else
			StopCoroutine (InSight ());
		}


		if(TypeOfObj==2)
		{
			if (go.tag == "Player")
			{
				print ("InCam");
				StartCoroutine (CamCoroutine ());
				inCam = true;
			}
			if (go.tag == "LurePlayer")
			{
				print ("LureInCam");

				LureInCam = true;
			}
		}
		if(TypeOfObj==3)
		{
			if (go.tag == "Player")
			{
				ViewCol.transform.localScale = new Vector3 (4,1,1);
			}

		}
			}

//	if (go.tag == "ennemy")
//		print ("I SawYou");
//
//		//		if (go.tag == "Untagged")
//		//			print ("I SawYou");

//		if (go.layer == LayerMask.NameToLayer ("ennemy"))
//			print ("I Saw You");

		//	print (go.name + " --> OnEnter() event");
		
	

	public void myListener_onExit(GameObject go){
			
		if(TypeOfObj==1)
		{
		if (go.tag == "Player")
		{
			StopCoroutine (InSight ());
//			print(Vector3.Distance(go.transform.position,transform.position));
			//print()
		//	print ("I SawYou");
			iSeeYou = false;
			throwSuspicious = false;
			throwAlert = false;
		}
			}

			if(TypeOfObj==2)
			{

				if (go.tag == "Player")
				{
					inCam = false;
				StopCoroutine (CamCoroutine ());
				}
			if (go.tag == "LurePlayer")
			{
				LureInCam = false;
			}
			}
		if (gameObject.GetHashCode () == go.GetHashCode ()) {
			//print (go.name + " --> OnExit() event");
			go.GetComponent<SpriteRenderer>().color = Color.white;

			}

		if(TypeOfObj==3)
		{
			if (go.tag == "Player")
			{
				ViewCol.transform.localScale = new Vector3 (0.3f,0.3f,1);

			}
		}
	
	}
	IEnumerator CamCoroutine()
	{
		yield return new WaitForSeconds (5f);
		if(inCam==true)
		{
		if (EnnemyOne != null)
			EnnemyOne.GetComponent<EnnnemyPatrolUpgraded> ().timerState = 30;
		
		if (EnnemyFive != null)
			EnnemyFive.GetComponent<EnnnemyPatrolUpgraded> ().timerState = 30;
		
		if (EnnemyFour != null)
			EnnemyFour.GetComponent<EnnnemyPatrolUpgraded> ().timerState = 30;
		
		if (EnnemyThree != null)
			EnnemyThree.GetComponent<EnnnemyPatrolUpgraded> ().timerState = 30;
		
		if (EnnemyTwo != null)
			EnnemyTwo.GetComponent<EnnnemyPatrolUpgraded> ().timerState = 30;
			InAlert = true;
			inCam = false;

			dangerLight.SetActive (true);
			SuspiciousLight.SetActive (false);
			NoDangerLight.SetActive (false);

		}	
	}

	public void myListener_onInside(GameObject go){
		
//		if (go.tag == "Player")
//			print ("I SawYou");
//		
//		if (go.tag == "ennemy")
//			print ("I SawYou");
//		
////		if (go.tag == "Untagged")
////			print ("I SawYou");
////		
//		if (go.layer == LayerMask.NameToLayer ("Player"))
//			print ("I Saw You");
//		if (go.layer == LayerMask.NameToLayer ("ennemy"))
//			print ("I Saw You");
//		if (go.layer == LayerMask.NameToLayer ("default"))
//			print ("I Saw You");
		
		
//		if(gameObject.GetHashCode() == go.GetHashCode())
//			print (go.name + " --> OnInside() event");
	}

	public void myListener_TT(){
		print("tt--list");
	}

	IEnumerator InSight()
	{
		if(throwAlert==false)
		throwSuspicious = true;
		yield return new WaitForSeconds (5f);
		if(iSeeYou==true)
		throwAlert = true;
		throwSuspicious = false;
		print ("throoooooooooooo");
		yield return new WaitForSeconds (1f);
		throwAlert = false;
	}
}
