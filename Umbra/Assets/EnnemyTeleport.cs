using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyTeleport : MonoBehaviour {
	public Transform UpSpawnPoint;
	public Transform RegularSpawnPoint;
	public Transform DownSpawnPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag=="ennemy")
		{
			if (col.GetComponent<EnnnemyPatrolUpgraded> ().backHome == true)
			{
				col.gameObject.transform.position = RegularSpawnPoint.position;
				col.GetComponent<EnnnemyPatrolUpgraded> ().UpPoint = col.GetComponent<EnnnemyPatrolUpgraded> ().UpPoint_RegularLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().DownPoint = col.GetComponent<EnnnemyPatrolUpgraded> ().DownPoint_RegularLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_RegularLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeftTransform_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual.transform;
<<<<<<< HEAD
//				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeftCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual.GetComponent<Collider2D> ();

				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_RegularLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightTransform_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.transform;
//				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.GetComponent<Collider2D> ();
=======
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeftCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual.GetComponent<Collider2D> ();

				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_RegularLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightTransform_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.transform;
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.GetComponent<Collider2D> ();
>>>>>>> origin/master
				col.GetComponent<EnnnemyPatrolUpgraded> ().LeftLimit = col.GetComponent<EnnnemyPatrolUpgraded> ().LeftLimit_RegularLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().RightLimit = col.GetComponent<EnnnemyPatrolUpgraded> ().RightLimit_RegularLevel;

				col.GetComponent<EnnnemyPatrolUpgraded> ().EnnemyLevel = 2;


			}

		
			if (col.GetComponent<EnnnemyPatrolUpgraded> ().PlayerIsUp == true)
			{
				if(col.GetComponent<EnnnemyPatrolUpgraded> ().EnnemyLevel==1)
				{	
					col.gameObject.transform.position = RegularSpawnPoint.position;
					col.GetComponent<EnnnemyPatrolUpgraded> ().UpPoint = col.GetComponent<EnnnemyPatrolUpgraded> ().UpPoint_RegularLevel;
					col.GetComponent<EnnnemyPatrolUpgraded> ().DownPoint = col.GetComponent<EnnnemyPatrolUpgraded> ().DownPoint_RegularLevel;
					col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_RegularLevel;
					col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeftTransform_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual.transform;
<<<<<<< HEAD
					//col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeftCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual.GetComponent<Collider2D> ();

					col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_RegularLevel;
					col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightTransform_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.transform;
					//col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.GetComponent<Collider2D> ();
=======
					col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeftCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual.GetComponent<Collider2D> ();

					col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_RegularLevel;
					col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightTransform_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.transform;
					col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.GetComponent<Collider2D> ();
>>>>>>> origin/master
					col.GetComponent<EnnnemyPatrolUpgraded> ().LeftLimit = col.GetComponent<EnnnemyPatrolUpgraded> ().LeftLimit_RegularLevel;
					col.GetComponent<EnnnemyPatrolUpgraded> ().RightLimit = col.GetComponent<EnnnemyPatrolUpgraded> ().RightLimit_RegularLevel;
					col.GetComponent<EnnnemyPatrolUpgraded> ().EnnemyLevel = 2;
				}
				if(col.GetComponent<EnnnemyPatrolUpgraded> ().EnnemyLevel==2)
				{	
					col.gameObject.transform.position = UpSpawnPoint.position;
					col.GetComponent<EnnnemyPatrolUpgraded> ().UpPoint = col.GetComponent<EnnnemyPatrolUpgraded> ().UpPoint_UpLevel;
					col.GetComponent<EnnnemyPatrolUpgraded> ().DownPoint = col.GetComponent<EnnnemyPatrolUpgraded> ().DownPoint_UpLevel;
					col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_UpLevel;
					col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeftTransform_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual.transform;
<<<<<<< HEAD
					//col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeftCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual.GetComponent<Collider2D> ();

					col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_UpLevel;
					col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightTransform_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.transform;
					//col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.GetComponent<Collider2D> ();
=======
					col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeftCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual.GetComponent<Collider2D> ();

					col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_UpLevel;
					col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightTransform_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.transform;
					col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.GetComponent<Collider2D> ();
>>>>>>> origin/master
					col.GetComponent<EnnnemyPatrolUpgraded> ().LeftLimit = col.GetComponent<EnnnemyPatrolUpgraded> ().LeftLimit_UpLevel;
					col.GetComponent<EnnnemyPatrolUpgraded> ().RightLimit = col.GetComponent<EnnnemyPatrolUpgraded> ().RightLimit_UpLevel;
					col.GetComponent<EnnnemyPatrolUpgraded> ().EnnemyLevel = 3;

				}


			}

			if (col.GetComponent<EnnnemyPatrolUpgraded> ().PlayerIsDown == true)
			{
			if(col.GetComponent<EnnnemyPatrolUpgraded> ().EnnemyLevel==3)
			{	
				col.gameObject.transform.position = RegularSpawnPoint.position;
				col.GetComponent<EnnnemyPatrolUpgraded> ().UpPoint = col.GetComponent<EnnnemyPatrolUpgraded> ().UpPoint_RegularLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().DownPoint = col.GetComponent<EnnnemyPatrolUpgraded> ().DownPoint_RegularLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_RegularLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeftTransform_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual.transform;
<<<<<<< HEAD
				//col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeftCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual.GetComponent<Collider2D> ();

				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_RegularLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightTransform_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.transform;
				//col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.GetComponent<Collider2D> ();
=======
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeftCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual.GetComponent<Collider2D> ();

				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_RegularLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightTransform_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.transform;
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.GetComponent<Collider2D> ();
>>>>>>> origin/master
				col.GetComponent<EnnnemyPatrolUpgraded> ().LeftLimit = col.GetComponent<EnnnemyPatrolUpgraded> ().LeftLimit_RegularLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().RightLimit = col.GetComponent<EnnnemyPatrolUpgraded> ().RightLimit_RegularLevel;
					col.GetComponent<EnnnemyPatrolUpgraded> ().EnnemyLevel = 2;

				}
			if(col.GetComponent<EnnnemyPatrolUpgraded> ().EnnemyLevel==2)
			{	
				col.gameObject.transform.position = UpSpawnPoint.position;
				col.GetComponent<EnnnemyPatrolUpgraded> ().UpPoint = col.GetComponent<EnnnemyPatrolUpgraded> ().UpPoint_DownLev;
				col.GetComponent<EnnnemyPatrolUpgraded> ().DownPoint = col.GetComponent<EnnnemyPatrolUpgraded> ().DownPoint_DownLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_DownLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeftTransform_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual.transform;
<<<<<<< HEAD
				//col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeftCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual.GetComponent<Collider2D> ();

				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_DownLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightTransform_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.transform;
				//col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.GetComponent<Collider2D> ();
=======
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeftCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_Actual.GetComponent<Collider2D> ();

				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointLeft_DownLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightTransform_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.transform;
				col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRightCol_Actual = col.GetComponent<EnnnemyPatrolUpgraded> ().TeleportPointRight_Actual.GetComponent<Collider2D> ();
>>>>>>> origin/master
				col.GetComponent<EnnnemyPatrolUpgraded> ().LeftLimit = col.GetComponent<EnnnemyPatrolUpgraded> ().LeftLimit_DownLevel;
				col.GetComponent<EnnnemyPatrolUpgraded> ().RightLimit = col.GetComponent<EnnnemyPatrolUpgraded> ().RightLimit_DownLevel;
					col.GetComponent<EnnnemyPatrolUpgraded> ().EnnemyLevel = 1;

			}

	}
		}
}
}