using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class SightListenerTemplate_Light : MonoBehaviour {

	// * NOTE: WHEN YOU'RE TESTING EVENTS IN EDITOR, BE SURE THAT GAME WINDOW IS ACTIVE AND VISIBLE 

	// ** DECLARE PUBLIC METHODS FOR LISTENERS

	// *** READ FIRST: http://jacksondunstan.com/articles/3335  (UnityEvents vs C# native Events performance)
//	bool detect =false;
	private bool check = false;
	public GameObject trheviewTrigger;

	Collider2D colliderMy;



	public void Start()
	{
		colliderMy = trheviewTrigger.GetComponent<Collider2D> ();

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

	void Update()
	{

	}


	public void ThismyListener_onEnter(GameObject go){
		//print ("Walla");

		if (go.tag == "Player")
		{
			colliderMy.transform.localScale=new Vector3(4,1,1);
			print ("Walla");

		}

		}


	public void ThismyListener_onExit(GameObject go){
		if (go.tag == "Player")
		{
		colliderMy.transform.localScale=new Vector3(1,1,1);
			print ("Walla");

		}




		}
	
	public void ThismyListener_onInside(GameObject go){
		
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

	public void ThismyListener_TT(){
		print("tt--list");
	}

}