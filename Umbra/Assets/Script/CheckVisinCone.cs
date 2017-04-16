﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVisinCone : MonoBehaviour {
	public Transform[] EnnemyInScene;
	public GameObject SuspiciousFeedback;
	public GameObject AlertFeedback;

	RaycastHit2D EnnmyRay;
	RaycastHit2D EnnmyRayTwo;
	RaycastHit2D EnnmyRayThree;
	RaycastHit2D EnnmyRayFour;
	RaycastHit2D EnnmyRayFive;
	RaycastHit2D EnnmyRaySix;
	bool thereisAnAlert;
	bool ThereisAsuspicious;

	public bool[] AlerEnnemy;
	public bool[] SuspiciousEnnemy;

	public LayerMask LayerMaskOne;


	public EnnemyMarked MarkOne;
	public EnnemyMarked MarkTwo;
	public EnnemyMarked MarkThree;
	public EnnemyMarked MarkFour;
	public EnnemyMarked MarkFive;
	public EnnemyMarked MarkSix;



	public bool CanSee;
	public bool CanSeeTwo;
	public bool CanSeeThree;
	public bool CanSeeFour;
	public bool CanSeeFive;
	public bool CanSeeSix;


	public ConVisible ConvisibleOne;
	public ConVisible ConvisibleTwo;
	public ConVisible ConvisibleThree;
	public ConVisible ConvisibleFour;
	public ConVisible ConvisibleFive;
	public ConVisible ConvisibleSix;
	bool AlertHavePlayer;
	bool RetrnHavePlayed;
	bool suspiciousHavePlayed;

	public EnnnemyPatrolUpgraded PatrolOne;
	public EnnnemyPatrolUpgraded PatrolTwo;
	public EnnnemyPatrolUpgraded Patrolthree;
	public EnnnemyPatrolUpgraded PatrolFour;	
	public EnnnemyPatrolUpgraded PatrolFive;
	public EnnnemyPatrolUpgraded PatrolSix;

	GameObject Playa;
	PlatformerCharacter2D pplatformscript;



	// Use this for initialization
	void Start () {
		SuspiciousFeedback = GameObject.Find ("SuspiciousLune");
		AlertFeedback = GameObject.Find ("DangerLune");
		Playa = GameObject.Find ("2DCharacter(Clone)");
		pplatformscript = Playa.GetComponent<PlatformerCharacter2D> ();
		InvokeRepeating ("MainComposante", 1, 1);

	}
	
	// Update is called once per frame

			void MainComposante()
	{

				if (EnnemyInScene [0] != null) {

					if (PatrolOne != null)
					{
						if (PatrolOne.Alert == true)
							AlerEnnemy [0] = true;
						else
							AlerEnnemy [0] = false;
						if (PatrolOne.Suspicious == true)
							SuspiciousEnnemy [0] = true;
						else
							SuspiciousEnnemy [0] = false;
					}	
					else
					{
						AlerEnnemy [0] = false;
						SuspiciousEnnemy[0]=false;
					}

					EnnmyRay  = Physics2D.Linecast (transform.position, EnnemyInScene [0].position,LayerMaskOne);

					if (EnnmyRay.collider != null) {

						if (EnnmyRay.collider.tag == "bloc")
							CanSee = false;
						else
							CanSee = true;
						if (CanSee == true || MarkOne.isMarked==true) {
							if (PatrolOne != null)
						ConvisibleOne.HisSight.SetActive(true);
						}
						if(CanSee == false && MarkOne.isMarked==false)
						{
							if (PatrolOne != null)
						ConvisibleOne.HisSight.SetActive(false);
						}
					}
				}
				else
				{
					AlerEnnemy [0] = false;
					SuspiciousEnnemy[0]=false;
				}

				if (EnnemyInScene [1] != null) {
					if (PatrolTwo != null)
					{
						if (PatrolTwo.Alert == true)
							AlerEnnemy [1] = true;
						else
							AlerEnnemy [1] = false;

						if (PatrolTwo.Suspicious == true)
							SuspiciousEnnemy [1] = true;
						else
							SuspiciousEnnemy [1] = false;

					}
					else
					{
						AlerEnnemy [1] = false;
						SuspiciousEnnemy[1]=false;
					}

					EnnmyRayTwo  = Physics2D.Linecast (transform.position, EnnemyInScene [1].position,LayerMaskOne);
					if (EnnmyRayTwo.collider != null) {
						if (EnnmyRayTwo.collider.tag == "bloc")
							CanSeeTwo = false;
						else
							CanSeeTwo = true;
						if (CanSeeTwo == true || MarkTwo.isMarked==true) {
							if (PatrolTwo != null)
						ConvisibleTwo.HisSight.SetActive(true);
						}
						if(CanSeeTwo == false && MarkTwo.isMarked==false)
						{
							if (PatrolTwo != null)
						ConvisibleTwo.HisSight.SetActive(false);
						}
					}

				}
				else
				{
					AlerEnnemy [1] = false;
					SuspiciousEnnemy[1]=false;
				}

				if (EnnemyInScene [2] != null) {
					if (Patrolthree != null){
						if (Patrolthree.Alert == true)
							AlerEnnemy [2] = true;
						else
							AlerEnnemy [2] = false;

						if (Patrolthree.Suspicious == true)
							SuspiciousEnnemy [2] = true;
						else
							SuspiciousEnnemy [2] = false;

					}
					else
					{
						AlerEnnemy [2] = false;
						SuspiciousEnnemy[2]=false;
					}
					EnnmyRayThree  = Physics2D.Linecast (transform.position, EnnemyInScene [2].position,LayerMaskOne);
					if (EnnmyRayThree.collider != null) {

						if (EnnmyRayThree.collider.tag == "bloc")
							CanSeeThree = false;
						else
							CanSeeThree = true;
						if (CanSeeThree == true || MarkThree.isMarked==true) {
							if (Patrolthree != null)
						ConvisibleThree.HisSight.SetActive(true);
						}
						if(CanSeeThree == false && MarkThree.isMarked==false)
						{
							if (Patrolthree != null)
						ConvisibleThree.HisSight.SetActive(false);
						}
						//	}
					}
				}
				else
				{
					AlerEnnemy [2] = false;
					SuspiciousEnnemy[2]=false;
				}

				if (EnnemyInScene [3] != null) {
					if (PatrolFour != null) {	
						if (PatrolFour.Alert == true)
							AlerEnnemy [3] = true;
						else
							AlerEnnemy [3] = false;

						if (PatrolFour.Suspicious == true)
							SuspiciousEnnemy [3] = true;
						else
							SuspiciousEnnemy [3] = false;

					} else {
						AlerEnnemy [3] = false;
						SuspiciousEnnemy [3] = false;
					}

					//			if(EnnmyRay  !=null)
					//			{
					EnnmyRayFour = Physics2D.Linecast (transform.position, EnnemyInScene [3].position, LayerMaskOne);
					if (EnnmyRayFour.collider != null) {
						if (EnnmyRayFour.collider.tag == "bloc")
							CanSeeFour = false;
						else
							CanSeeFour = true;
						if (CanSeeFour == true || MarkFour.isMarked == true) {
							if (PatrolFour != null)
						ConvisibleFour.HisSight.SetActive(true);
						}
						if (CanSeeFour == false && MarkFour.isMarked == false) {
							if (PatrolFour != null)
						ConvisibleFour.HisSight.SetActive(false);
						}
					}
					//	}

				} else {
					AlerEnnemy [3] = false;
					SuspiciousEnnemy [3] = false;
				}

				if (EnnemyInScene [4] != null) {
					if (PatrolFive != null)
					{
						if (PatrolFive.Alert == true)
							AlerEnnemy [4] = true;
						else
							AlerEnnemy [4] = false;

						if (PatrolFive.Suspicious == true)
							SuspiciousEnnemy [4] = true;
						else
							SuspiciousEnnemy [4] = false;

					}
					else
					{
						AlerEnnemy [4] = false;
						SuspiciousEnnemy[4]=false;
					}
					//			if(EnnmyRay  !=null)
					//			{
					EnnmyRayFive  = Physics2D.Linecast (transform.position, EnnemyInScene [4].position,LayerMaskOne);
					if (EnnmyRayFive.collider != null) {
						if (EnnmyRayFive.collider.tag == "bloc")
							CanSeeFive = false;
						else
							CanSeeFive = true;

						if (PatrolFive != null)
						{
							if (CanSeeFive == true || MarkFive.isMarked==true)
							{
						ConvisibleFive.HisSight.SetActive(true);
							}
							if (CanSeeFive == false && MarkFive.isMarked == false) 
							{
						ConvisibleFive.HisSight.SetActive(false);
							}

							//	}
						}
					}
				}
				else
				{
					AlerEnnemy [4] = false;
					SuspiciousEnnemy[4]=false;
				}


				if (EnnemyInScene [5] != null) {
					if (PatrolSix != null) {
						if (PatrolSix.Alert == true)
							AlerEnnemy [5] = true;
						else
							AlerEnnemy [5] = false;

						if (PatrolSix.Suspicious == true)
							SuspiciousEnnemy [5] = true;
						else
							SuspiciousEnnemy [5] = false;

					}
					else
					{
						AlerEnnemy [5] = false;
						SuspiciousEnnemy[5]=false;
					}
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
						ConvisibleSix.HisSight.SetActive(true);
						}
						if (CanSeeSix == false && MarkSix == false) {
							{
								if (PatrolSix != null)
							ConvisibleSix.HisSight.SetActive(false);
							}
							//	}

						}
					}
				} else
				{
					AlerEnnemy [5] = false;
					SuspiciousEnnemy[5]=false;
				}

			


				if (AlerEnnemy [0] == false && AlerEnnemy [1] == false && AlerEnnemy [2] == false && AlerEnnemy [3] == false && AlerEnnemy [4] == false && AlerEnnemy [5] == false) 
				{

			thereisAnAlert = false;
					pplatformscript.canhideThree = true;
					AlertFeedback.SetActive (false);
			AlertHavePlayer = false;
				}
				else {
			thereisAnAlert = true;
	
			if (AlertHavePlayer==false) {
			
				AkSoundEngine.PostEvent ("Mus_Located", gameObject);
				AlertHavePlayer = true;
				RetrnHavePlayed = false;
				suspiciousHavePlayed = false;
			}

					pplatformscript.canhideThree = false;
					AlertFeedback.SetActive (true);
				}

				if(SuspiciousEnnemy [0] == false && SuspiciousEnnemy [1] == false && SuspiciousEnnemy [2] == false && SuspiciousEnnemy [3] == false && SuspiciousEnnemy [4] == false && SuspiciousEnnemy [5] == false) {
					
				SuspiciousFeedback.SetActive (false);
			ThereisAsuspicious = false;
			}
			 else {
			if (suspiciousHavePlayed==false) {
				AkSoundEngine.PostEvent ("Mus_Alert", gameObject);
				RetrnHavePlayed = true;
				suspiciousHavePlayed = false;
				AlertHavePlayer = false;
			}

			ThereisAsuspicious = true;
					SuspiciousFeedback.SetActive (true);
				}

		if (thereisAnAlert == false && ThereisAsuspicious == false){
			if (RetrnHavePlayed == false) {
				AkSoundEngine.PostEvent ("Mus_Explo", gameObject);
				RetrnHavePlayed = true;
				AlertHavePlayer = false;
				suspiciousHavePlayed = false;
			}		
		}
	}
	void Update () { 
		

	}


}
