using UnityEngine;
using System.Collections;
using Pathfinding;

[RequireComponent (typeof (Rigidbody2D))  ]
[RequireComponent (typeof (Seeker))  ]

public class EnnemyAI : MonoBehaviour {
	public Transform target;
	public float updateRate = 2;
	public Seeker seeker;
	public Rigidbody2D RB;
	public Path path;
	private int CurrentWayPOint=0;

	public float AIspeed=300;
	public ForceMode2D ifMode;

	[HideInInspector]
	public bool pathEnding=false;
	public float nextWayPointDistance=3;


	// Use this for initialization
	void Start () {
		seeker = GetComponent<Seeker> ();
		RB = GetComponent<Rigidbody2D> ();
		if(target==null)
		{
			Debug.LogError ("NoPLayerFoundPanick"+path.error);
			return;
		}
		seeker.StartPath (transform.position, target.position, OnPathComplete);
		StartCoroutine (UpdatePath());

	}
	
	// Update is called once per frame
	public void OnPathComplete(Path p)
	{
		Debug.Log ("we ahve a path");
		if(!p.error)
		{
			path = p;
			CurrentWayPOint = 0;
		}
	}
	IEnumerator UpdatePath()
	{
		if (target == null)
			yield return false;
		seeker.StartPath (transform.position, target.position, OnPathComplete);
		yield return new WaitForSeconds (1f / updateRate);
			StartCoroutine (UpdatePath());
		
	}

	void FixedUpdate () {
		if (path == null)
			return;
		if (target == null)
			return;
		if(CurrentWayPOint>=path.vectorPath.Count)
		{
			if (pathEnding)
				return;

			pathEnding = true;
			}
		pathEnding = false;
		//direction to the next waypoint
		Vector3 dir=(path.vectorPath[ CurrentWayPOint ]-transform.position).normalized;
		dir *= AIspeed * Time.fixedDeltaTime;
		RB.AddForce (dir, ifMode);
		float dist=Vector3.Distance(transform.position, path.vectorPath[ CurrentWayPOint ]);
		if (dist < CurrentWayPOint)
		{
			CurrentWayPOint++;
			return;
		}	
	}
}
