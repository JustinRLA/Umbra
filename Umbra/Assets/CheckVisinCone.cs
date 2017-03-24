using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVisinCone : MonoBehaviour {
	public Transform[] EnnemyInScene;
	RaycastHit2D EnnmyRay;
	RaycastHit2D EnnmyRayTwo;
	RaycastHit2D EnnmyRayThree;
	RaycastHit2D EnnmyRayFour;
	RaycastHit2D EnnmyRayFive;
	RaycastHit2D EnnmyRaySix;
	RaycastHit2D EnnmyRaySeven;
	RaycastHit2D EnnmyRayEight;


	Transform player;
	public bool CanSee;
	public bool CanSeeTwo;
	public bool CanSeeThree;
	public bool CanSeeFour;
	public bool CanSeeFive;
	public bool CanSeeSix;
	public bool CanSeeSeven;
	public bool CanSeeEight;


	ConVisible ConvisibleOne;
	ConVisible ConvisibleTwo;
	ConVisible ConvisibleThree;
	ConVisible ConvisibleFour;
	ConVisible ConvisibleFive;
	ConVisible ConvisibleSix;
	ConVisible ConvisibleSeven;
	ConVisible ConvisibleEight;


	EnnnemyPatrolUpgraded PatrolOne;
	EnnnemyPatrolUpgraded PatrolTwo;
	EnnnemyPatrolUpgraded Patrolthree;
	EnnnemyPatrolUpgraded PatrolFour;	
	EnnnemyPatrolUpgraded PatrolFive;
	EnnnemyPatrolUpgraded PatrolSix;
	EnnnemyPatrolUpgraded PatrolSeven;
	EnnnemyPatrolUpgraded PatrolEight;

	// Use this for initialization
	void Start () {
		//player=GameObject.Find("2DCharacter(Clone)").transform;
	//	EnnmyRay [0] = Physics2D.Linecast (player.position, EnnemyInScene [0].position);
		PatrolOne= EnnemyInScene[0].GetComponent<EnnnemyPatrolUpgraded>();
		PatrolTwo= EnnemyInScene[1].GetComponent<EnnnemyPatrolUpgraded>();
		Patrolthree= EnnemyInScene[2].GetComponent<EnnnemyPatrolUpgraded>();
		PatrolFour= EnnemyInScene[3].GetComponent<EnnnemyPatrolUpgraded>();
		PatrolFive= EnnemyInScene[4].GetComponent<EnnnemyPatrolUpgraded>();
		PatrolSix= EnnemyInScene[5].GetComponent<EnnnemyPatrolUpgraded>();
		PatrolSeven= EnnemyInScene[6].GetComponent<EnnnemyPatrolUpgraded>();
		PatrolEight= EnnemyInScene[7].GetComponent<EnnnemyPatrolUpgraded>();

		ConvisibleOne = EnnemyInScene [0].GetComponent<ConVisible> ();
		ConvisibleTwo = EnnemyInScene [1].GetComponent<ConVisible> ();
		ConvisibleThree = EnnemyInScene [2].GetComponent<ConVisible> ();
		ConvisibleFour = EnnemyInScene [3].GetComponent<ConVisible> ();
		ConvisibleFive = EnnemyInScene [4].GetComponent<ConVisible> ();
		ConvisibleSix = EnnemyInScene [5].GetComponent<ConVisible> ();
		ConvisibleSeven = EnnemyInScene [6].GetComponent<ConVisible> ();
		ConvisibleEight = EnnemyInScene [7].GetComponent<ConVisible> ();



	}
	
	// Update is called once per frame
	void Update () {
		if(EnnemyInScene[0] != null)
		{
//			if(EnnmyRay  !=null)
//			{
				EnnmyRay  = Physics2D.Linecast (transform.position, EnnemyInScene [0].position);
			if (EnnmyRay.collider.tag == "bloc")
				CanSee = false;
			else
				CanSee = true;
			if (CanSee == true) {
				if (PatrolOne != null)
					ConvisibleOne.HisSight.GetComponent<MeshRenderer> ().enabled = true;
			}
				else
			{
				if (PatrolOne != null)
					ConvisibleOne.HisSight.GetComponent<MeshRenderer> ().enabled = false;
			}
			
			
		//	}

		}
		if(EnnemyInScene[1] != null)
		{
			//			if(EnnmyRay  !=null)
			//			{
			EnnmyRayTwo  = Physics2D.Linecast (transform.position, EnnemyInScene [1].position);
			if (EnnmyRayTwo.collider.tag == "bloc")
				CanSeeTwo = false;
			else
				CanSeeTwo = true;
			if (CanSeeTwo == true) {
				if (PatrolTwo != null)
					ConvisibleTwo.HisSight.GetComponent<MeshRenderer> ().enabled = true;
			}
			else
			{
				if (PatrolTwo != null)
					ConvisibleTwo.HisSight.GetComponent<MeshRenderer> ().enabled = false;
			}
		}
			if(EnnemyInScene[2] != null)
			{
				//			if(EnnmyRay  !=null)
				//			{
				EnnmyRayThree  = Physics2D.Linecast (transform.position, EnnemyInScene [2].position);
				if (EnnmyRayThree.collider.tag == "bloc")
					CanSeeThree = false;
				else
					CanSeeThree = true;
				if (CanSeeThree == true) {
					if (Patrolthree != null)
						ConvisibleThree.HisSight.GetComponent<MeshRenderer> ().enabled = true;
				}
				else
				{
					if (Patrolthree != null)
						ConvisibleThree.HisSight.GetComponent<MeshRenderer> ().enabled = false;
				}
			//	}

		}

			if(EnnemyInScene[3] != null)
			{
				//			if(EnnmyRay  !=null)
				//			{
				EnnmyRayFour  = Physics2D.Linecast (transform.position, EnnemyInScene [3].position);
				if (EnnmyRayFour.collider.tag == "bloc")
					CanSeeFour = false;
				else
					CanSeeFour = true;
				if (CanSeeFour == true) {
					if (PatrolFour != null)
						ConvisibleFour.HisSight.GetComponent<MeshRenderer> ().enabled = true;
				}
				else
				{
					if (PatrolFour != null)
						ConvisibleFour.HisSight.GetComponent<MeshRenderer> ().enabled = false;
				}
				//	}

			}

			if(EnnemyInScene[4] != null)
			{
				//			if(EnnmyRay  !=null)
				//			{
				EnnmyRayFive  = Physics2D.Linecast (transform.position, EnnemyInScene [4].position);
				if (EnnmyRayFive.collider.tag == "bloc")
					CanSeeFive = false;
				else
					CanSeeFive = true;
				if (CanSeeSix == true) {
					if (PatrolFive != null)
						ConvisibleFive.HisSight.GetComponent<MeshRenderer> ().enabled = true;
				}
				else
				{
					if (PatrolFive != null)
						ConvisibleFive.HisSight.GetComponent<MeshRenderer> ().enabled = false;
				}
				//	}

			}

			if(EnnemyInScene[5] != null)
			{
				//			if(EnnmyRay  !=null)
				//			{
				EnnmyRaySix  = Physics2D.Linecast (transform.position, EnnemyInScene [5].position);
				if (EnnmyRaySix.collider.tag == "bloc")
					CanSeeFive = false;
				else
					CanSeeSix = true;
				if (CanSeeSix == true) {
					if (PatrolSix != null)
						ConvisibleSix.HisSight.GetComponent<MeshRenderer> ().enabled = true;
				}
				else
				{
					if (PatrolSix != null)
						ConvisibleSix.HisSight.GetComponent<MeshRenderer> ().enabled = false;
				}
				//	}

			}

			if(EnnemyInScene[6] != null)
			{
				//			if(EnnmyRay  !=null)
				//			{
				EnnmyRaySeven  = Physics2D.Linecast (transform.position, EnnemyInScene [6].position);
				if (EnnmyRaySeven.collider.tag == "bloc")
					CanSeeSeven = false;
				else
					CanSeeSeven = true;
				if (CanSeeSeven == true) {
					if (PatrolSeven != null)
						ConvisibleSeven.HisSight.GetComponent<MeshRenderer> ().enabled = true;
				}
				else
				{
					if (PatrolSeven != null)
						ConvisibleSeven.HisSight.GetComponent<MeshRenderer> ().enabled = false;
				}
				//	}

			}

			if(EnnemyInScene[7] != null)
			{
				//			if(EnnmyRay  !=null)
				//			{
				EnnmyRayEight  = Physics2D.Linecast (transform.position, EnnemyInScene [7].position);
				if (EnnmyRayEight.collider.tag == "bloc")
					CanSeeEight = false;
				else
					CanSeeEight = true;
				if (CanSeeEight == true) {
					if (PatrolEight != null)
						ConvisibleEight.HisSight.GetComponent<MeshRenderer> ().enabled = true;
				}
				else
				{
					if (PatrolEight != null)
						ConvisibleEight.HisSight.GetComponent<MeshRenderer> ().enabled = false;
				}
				//	}

			}
	}
}
