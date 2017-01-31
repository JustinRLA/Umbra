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

	public void Start()
	{
		myLureScript = RuneManager.GetComponent<LureScript> ();
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

	void Update()
	{
		if (myLureScript.Active== false)
			IsawTheLure = false;
		
		if(mySight==null)
		{
			iSeeYou = false;
		throwSuspicious = false;
		throwAlert = false;
		}

		if (transform.parent.GetComponent<EnnnemyPatrol> () == null)
			iSeeYou = false;

		if (transform.parent.GetComponent<EnnnemyPatrol> ().Alert == true)
			throwSuspicious = false;

	}


	public void myListener_onEnter(GameObject go){
		//Filter by Hash
		//print(go);
//		if (go.tag == "ennemy")
//		{
//			print(Vector3.Distance(go.transform.position,transform.position));
//			//print()
//			print ("I SawYousdfmjkfnhjusdbhdfbhsf");
//		}
		//&& EnnemyBase.GetComponent<EnnnemyPatrol> ().Alert == false
//		print(transform.parent.name);

		if(throwAlert==false || throwSuspicious==false)
		{
			if (go.tag == "LurePlayer" ) {


				print ("SAWWWWWWWWWWWWWWWWWWWWWWW");
				IsawTheLure = true;
				EnnemyBase.GetComponent<EnnnemyPatrol> ().Suspicious = true;
			} 
//			else
//				IsawTheLure = false;

		}
		if (go.tag == "Player")
		{
			IsawTheLure=false;
			iSeeYou = true;
			//if(transform.parent.GetComponent<EnnnemyPatrol>().Alert==false)
			StartCoroutine (InSight ());
			}
//	if (go.tag == "ennemy")
//		print ("I SawYou");
//
//		//		if (go.tag == "Untagged")
//		//			print ("I SawYou");
//		//		
		if (go.layer == LayerMask.NameToLayer ("Player"))
			//print ("I Saw You");
//		if (go.layer == LayerMask.NameToLayer ("ennemy"))
//			print ("I Saw You");

		if (gameObject.GetHashCode () == go.GetHashCode ()) {
		//	print (go.name + " --> OnEnter() event");
			go.GetComponent<SpriteRenderer>().color = Color.green;
		}
	}

	public void myListener_onExit(GameObject go){
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


		if (gameObject.GetHashCode () == go.GetHashCode ()) {
			//print (go.name + " --> OnExit() event");
			go.GetComponent<SpriteRenderer>().color = Color.white;


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
		throwAlert = true;
		throwSuspicious = false;

	
	}
}
