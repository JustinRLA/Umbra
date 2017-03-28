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

	public bool[] AlerEnnemy;

	public LayerMask LayerMaskOne;


	public EnnemyMarked MarkOne;
	public EnnemyMarked MarkTwo;
	public EnnemyMarked MarkThree;
	public EnnemyMarked MarkFour;
	public EnnemyMarked MarkFive;
	public EnnemyMarked MarkSix;
	public EnnemyMarked MarkSeven;
	public EnnemyMarked MarkEight;


	public bool CanSee;
	public bool CanSeeTwo;
	public bool CanSeeThree;
	public bool CanSeeFour;
	public bool CanSeeFive;
	public bool CanSeeSix;
	public bool CanSeeSeven;
	public bool CanSeeEight;


	public ConVisible ConvisibleOne;
	public ConVisible ConvisibleTwo;
	public ConVisible ConvisibleThree;
	public ConVisible ConvisibleFour;
	public ConVisible ConvisibleFive;
	public ConVisible ConvisibleSix;
	public ConVisible ConvisibleSeven;
	public ConVisible ConvisibleEight;


	public EnnnemyPatrolUpgraded PatrolOne;
	public EnnnemyPatrolUpgraded PatrolTwo;
	public EnnnemyPatrolUpgraded Patrolthree;
	public EnnnemyPatrolUpgraded PatrolFour;	
	public EnnnemyPatrolUpgraded PatrolFive;
	public EnnnemyPatrolUpgraded PatrolSix;
	public EnnnemyPatrolUpgraded PatrolSeven;
	public EnnnemyPatrolUpgraded PatrolEight;
	GameObject Playa;
	PlatformerCharacter2D pplatformscript;



	// Use this for initialization
	void Start () {
		Playa = GameObject.Find ("2DCharacter(Clone)");
		pplatformscript = Playa.GetComponent<PlatformerCharacter2D> ();


	}
	
	// Update is called once per frame
	void Update () { 
		
		if (EnnemyInScene [0] != null) {
			
			if (PatrolOne != null)
			{
			if (PatrolOne.Alert == true)
				AlerEnnemy [0] = true;
			else
				AlerEnnemy [0] = false;
			}	
			else
				AlerEnnemy [0] = false;

		
			EnnmyRay  = Physics2D.Linecast (transform.position, EnnemyInScene [0].position,LayerMaskOne);

			if (EnnmyRay.collider != null) {
				
			if (EnnmyRay.collider.tag == "bloc")
				CanSee = false;
			else
				CanSee = true;
			if (CanSee == true || MarkOne.isMarked==true) {
				if (PatrolOne != null)
					ConvisibleOne.HisSight.GetComponent<MeshRenderer> ().enabled = true;
			}
			if(CanSee == false && MarkOne.isMarked==false)
			{
				if (PatrolOne != null)
					ConvisibleOne.HisSight.GetComponent<MeshRenderer> ().enabled = false;
			}
			}
	}
		else
			AlerEnnemy [0] = false;
		
		if (EnnemyInScene [1] != null) {
			if (PatrolTwo != null)
			{
			if (PatrolTwo.Alert == true)
				AlerEnnemy [1] = true;
			else
				AlerEnnemy [1] = false;
		}
		else
			AlerEnnemy [1] = false;
		
			EnnmyRayTwo  = Physics2D.Linecast (transform.position, EnnemyInScene [1].position,LayerMaskOne);
			if (EnnmyRayTwo.collider != null) {
			if (EnnmyRayTwo.collider.tag == "bloc")
				CanSeeTwo = false;
			else
				CanSeeTwo = true;
			if (CanSeeTwo == true || MarkTwo.isMarked==true) {
				if (PatrolTwo != null)
					ConvisibleTwo.HisSight.GetComponent<MeshRenderer> ().enabled = true;
			}
			if(CanSeeTwo == false && MarkTwo.isMarked==false)
			{
				if (PatrolTwo != null)
					ConvisibleTwo.HisSight.GetComponent<MeshRenderer> ().enabled = false;
				}
			}

		}
		else
			AlerEnnemy [1] = false;
		
		if (EnnemyInScene [2] != null) {
			if (Patrolthree != null){
			if (Patrolthree.Alert == true)
				AlerEnnemy [2] = true;
			else
				AlerEnnemy [2] = false;
		}
		else
			AlerEnnemy [2] = false;
		
			EnnmyRayThree  = Physics2D.Linecast (transform.position, EnnemyInScene [2].position,LayerMaskOne);
			if (EnnmyRayThree.collider != null) {
				
				if (EnnmyRayThree.collider.tag == "bloc")
					CanSeeThree = false;
				else
					CanSeeThree = true;
			if (CanSeeThree == true || MarkThree.isMarked==true) {
					if (Patrolthree != null)
						ConvisibleThree.HisSight.GetComponent<MeshRenderer> ().enabled = true;
				}
			if(CanSeeThree == false && MarkThree.isMarked==false)
				{
					if (Patrolthree != null)
						ConvisibleThree.HisSight.GetComponent<MeshRenderer> ().enabled = false;
				}
			//	}
			}
		}
		else
			AlerEnnemy [2] = false;


		if (EnnemyInScene [3] != null) {
			if (PatrolFour != null)
			{	
			if (PatrolFour.Alert == true)
				AlerEnnemy [3] = true;
			else
				AlerEnnemy [3] = false;
		}
		else
			AlerEnnemy [3] = false;
				//			if(EnnmyRay  !=null)
				//			{
			EnnmyRayFour  = Physics2D.Linecast (transform.position, EnnemyInScene [3].position,LayerMaskOne);
			if (EnnmyRayFour.collider != null) {
				if (EnnmyRayFour.collider.tag == "bloc")
					CanSeeFour = false;
				else
					CanSeeFour = true;
				if (CanSeeFour == true || MarkFour.isMarked == true) {
					if (PatrolFour != null)
						ConvisibleFour.HisSight.GetComponent<MeshRenderer> ().enabled = true;
				}
				if (CanSeeFour == false && MarkFour.isMarked == false) {
					if (PatrolFour != null)
						ConvisibleFour.HisSight.GetComponent<MeshRenderer> ().enabled = false;
				}
			}
				//	}

			}
		else
			AlerEnnemy [3] = false;

		if (EnnemyInScene [4] != null) {
			if (PatrolFive != null)
			{
			if (PatrolFive.Alert == true)
				AlerEnnemy [4] = true;
			else
				AlerEnnemy [4] = false;
		}
		else
			AlerEnnemy [4] = false;
				//			if(EnnmyRay  !=null)
				//			{
			EnnmyRayFive  = Physics2D.Linecast (transform.position, EnnemyInScene [4].position,LayerMaskOne);
			if (EnnmyRayFive.collider != null) {
			if (EnnmyRayFive.collider.tag == "bloc")
					CanSeeFive = false;
				else
					CanSeeFive = true;
			if (CanSeeFive == true || MarkFive.isMarked==true) {
					if (PatrolFive != null)
						ConvisibleFive.HisSight.GetComponent<MeshRenderer> ().enabled = true;
				}
			if (CanSeeFive == false && MarkFive.isMarked==false) {
				{
					if (PatrolFive != null)
						ConvisibleFive.HisSight.GetComponent<MeshRenderer> ().enabled = false;
				}
				//	}
				}
			}
		}
		else
			AlerEnnemy [4] = false;


		if (EnnemyInScene [5] != null) {
			if (PatrolSix != null) {
				if (PatrolSix.Alert == true)
					AlerEnnemy [5] = true;
				else
					AlerEnnemy [5] = false;
			}
			else
				AlerEnnemy [5] = false;
			//			if(EnnmyRay  !=null)
			//			{
			EnnmyRaySix = Physics2D.Linecast (transform.position, EnnemyInScene [5].position, LayerMaskOne);
			if (EnnmyRaySix.collider != null) {
				
				if (EnnmyRaySix.collider.tag == "bloc")
					CanSeeSix = false;
				else
					CanSeeSix = true;
				if (CanSeeSix == true || MarkSix == true) {
					if (PatrolSix != null)
						ConvisibleSix.HisSight.GetComponent<MeshRenderer> ().enabled = true;
				}
				if (CanSeeSix == false && MarkSix == false) {
					{
						if (PatrolSix != null)
							ConvisibleSix.HisSight.GetComponent<MeshRenderer> ().enabled = false;
					}
					//	}

				}
			}
		} else
			AlerEnnemy [5] = false;

			if(EnnemyInScene[6] != null)
			{
				if (PatrolSeven != null)
				{
		if (PatrolSeven.Alert == true)
			AlerEnnemy [6] = true;
		else
			AlerEnnemy [6] = false;
	}
	else
		AlerEnnemy [6] = false;
	
			EnnmyRaySeven  = Physics2D.Linecast (transform.position, EnnemyInScene [6].position,LayerMaskOne);
			if (EnnmyRaySeven.collider != null) {
				
				if (EnnmyRaySeven.collider.tag == "bloc")
					CanSeeSeven = false;
				else
					CanSeeSeven = true;
			if (CanSeeSeven == true || MarkSeven.isMarked==true) {
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
			}
else
	AlerEnnemy [6] = false;

			if(EnnemyInScene[7] != null)
			{
	if (PatrolSeven != null) {
		if (PatrolEight.Alert == true)
			AlerEnnemy [7] = true;
		else
			AlerEnnemy [7] = false;
	}
	else
		AlerEnnemy [7] = false;
	
			EnnmyRayEight  = Physics2D.Linecast (transform.position, EnnemyInScene [7].position,LayerMaskOne);
			if (EnnmyRayEight.collider != null) {
				
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
else
	AlerEnnemy [7] = false;

		if (AlerEnnemy [0] == false && AlerEnnemy [1] == false && AlerEnnemy [2] == false && AlerEnnemy [3] == false && AlerEnnemy [4] == false && AlerEnnemy [5] == false && AlerEnnemy [6] == false && AlerEnnemy [7] == false)
			pplatformscript.canhideThree = true;
		else
			pplatformscript.canhideThree = false;
		
	}


}
