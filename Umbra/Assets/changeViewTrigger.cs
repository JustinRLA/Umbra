using UnityEngine;
using System.Collections;

public class changeViewTrigger : MonoBehaviour {
	public GameObject PlayerCenter;
	public GameObject ViewTriger;
	public bool MyLight;
	// Use this for initialization
	void Start () {
		PlayerCenter = GameObject.Find ("2DCharacter");
		ViewTriger=GameObject.Find ("ViewTrigger");
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D col)
	{		
		if (col.gameObject == PlayerCenter)
		{
			if (MyLight == true)
				ViewTriger.transform.localScale = new Vector3 (8,1,1);
			else
				ViewTriger.transform.localScale = new Vector3 (1,1,1);
		}

	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject == PlayerCenter)
		{
			if (MyLight == true)
				ViewTriger.transform.localScale = new Vector3 (4,1,1);
			else
				ViewTriger.transform.localScale = new Vector3 (4,1,1);
		}


	}
	u

}