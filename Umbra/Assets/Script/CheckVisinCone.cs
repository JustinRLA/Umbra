using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVisinCone : MonoBehaviour {
	public Transform SecondRay;

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

	RaycastHit2D SecondEnnmyRay;
	RaycastHit2D SecondEnnmyRayTwo;
	RaycastHit2D SecondEnnmyRayThree;
	RaycastHit2D SecondEnnmyRayFour;
	RaycastHit2D SecondEnnmyRayFive;
	RaycastHit2D SecondEnnmyRaySix;


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

	public bool SecondCanSee;
	public bool SecondCanSeeTwo;
	public bool SecondCanSeeThree;
	public bool SecondCanSeeFour;
	public bool SecondCanSeeFive;
	public bool SecondCanSeeSix;

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
			SecondEnnmyRay  = Physics2D.Linecast (SecondRay.position, EnnemyInScene [0].position,LayerMaskOne);
			if (EnnmyRay.collider == null)
				CanSee = true;
			if (SecondEnnmyRay.collider == null)
				SecondCanSee = true;
			
					if (EnnmyRay.collider != null) {

						if (EnnmyRay.collider.tag == "bloc")
							CanSee = false;
						else
							CanSee = true;
			}
			if (SecondEnnmyRay.collider != null) {

				if (SecondEnnmyRay.collider.tag == "bloc")
					SecondCanSee = false;
				else
					SecondCanSee = true;
			}
				
				if (CanSee == true || MarkOne.isMarked==true || SecondCanSee==true) {
							if (PatrolOne != null)
						ConvisibleOne.HisSight.SetActive(true);
						}
				if(CanSee == false && MarkOne.isMarked==false && SecondCanSee==false)
						{
							if (PatrolOne != null)
						ConvisibleOne.HisSight.SetActive(false);
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
			SecondEnnmyRayTwo  = Physics2D.Linecast (SecondRay.position, EnnemyInScene [1].position,LayerMaskOne);

					EnnmyRayTwo  = Physics2D.Linecast (transform.position, EnnemyInScene [1].position,LayerMaskOne);
			if (EnnmyRayTwo.collider == null)
				CanSeeTwo = true;
			if (SecondEnnmyRayTwo.collider == null)
				SecondCanSeeTwo = true;
			

					if (EnnmyRayTwo.collider != null) {
						if (EnnmyRayTwo.collider.tag == "bloc")
							CanSeeTwo = false;
						else
							CanSeeTwo = true;
			}
			if (SecondEnnmyRayTwo.collider != null) {
				if (SecondEnnmyRayTwo.collider.tag == "bloc")
					SecondCanSeeTwo = false;
				else
					SecondCanSeeTwo = true;
			}
				if (CanSeeTwo == true || MarkTwo.isMarked==true ||SecondCanSeeTwo == true) {
							if (PatrolTwo != null)
						ConvisibleTwo.HisSight.SetActive(true);
						}
				if(CanSeeTwo == false && MarkTwo.isMarked==false && SecondCanSeeTwo == false)
						{
							if (PatrolTwo != null)
						ConvisibleTwo.HisSight.SetActive(false);
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
			SecondEnnmyRayThree  = Physics2D.Linecast (SecondRay.position, EnnemyInScene [2].position,LayerMaskOne);

					EnnmyRayThree  = Physics2D.Linecast (transform.position, EnnemyInScene [2].position,LayerMaskOne);

			if (EnnmyRayThree.collider == null)
				CanSeeThree = true;
			if (SecondEnnmyRayThree.collider == null)
				SecondCanSeeThree = true;
			
					if (EnnmyRayThree.collider != null) {
						if (EnnmyRayThree.collider.tag == "bloc")
							CanSeeThree = false;
						else
							CanSeeThree = true;
			}

			if (SecondEnnmyRayThree.collider != null) {
				
				if (SecondEnnmyRayThree.collider.tag == "bloc")
					SecondCanSeeThree = false;
				else
					SecondCanSeeThree = true;
			}

				if (CanSeeThree == true || MarkThree.isMarked==true || SecondCanSeeThree == true) {
							if (Patrolthree != null)
						ConvisibleThree.HisSight.SetActive(true);
						}
				if(CanSeeThree == false && MarkThree.isMarked==false && SecondCanSeeThree == false)
						{
							if (Patrolthree != null)
						ConvisibleThree.HisSight.SetActive(false);
						}
						//	}
					
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
			SecondEnnmyRayFour = Physics2D.Linecast (SecondRay.position, EnnemyInScene [3].position, LayerMaskOne);

					EnnmyRayFour = Physics2D.Linecast (transform.position, EnnemyInScene [3].position, LayerMaskOne);
			if (EnnmyRayFour.collider == null)
				CanSeeFour = true;
			if (SecondEnnmyRayFour.collider == null)
				SecondCanSeeFour = true;
			
					if (EnnmyRayFour.collider != null) {
						if (EnnmyRayFour.collider.tag == "bloc")
							CanSeeFour = false;
						else
							CanSeeFour = true;
			}
			if (SecondEnnmyRayFour.collider != null) {
				if (SecondEnnmyRayFour.collider.tag == "bloc")
					SecondCanSeeFour = false;
				else
					SecondCanSeeFour = true;
			}
				if (CanSeeFour == true || MarkFour.isMarked == true  || SecondCanSeeFour==true) {
							if (PatrolFour != null)
						ConvisibleFour.HisSight.SetActive(true);
						}
				if (CanSeeFour == false && MarkFour.isMarked == false && SecondCanSeeFour==false) {
							if (PatrolFour != null)
						ConvisibleFour.HisSight.SetActive(false);
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
			SecondEnnmyRayFive =  Physics2D.Linecast (SecondRay.position, EnnemyInScene [4].position,LayerMaskOne);
					EnnmyRayFive  = Physics2D.Linecast (transform.position, EnnemyInScene [4].position,LayerMaskOne);

			if (EnnmyRayFive.collider == null)
				CanSeeFive = true;
			if (SecondEnnmyRayFive.collider == null)
				SecondCanSeeFive = true;
			
					if (EnnmyRayFive.collider != null) {
						if (EnnmyRayFive.collider.tag == "bloc")
							CanSeeFive = false;
						else
							CanSeeFive = true;
			}
			if (SecondEnnmyRayFive.collider != null) {
				if (SecondEnnmyRayFive.collider.tag == "bloc")
					SecondCanSeeFive = false;
				else
					SecondCanSeeFive = true;
			}
						if (PatrolFive != null)
						{
					if (CanSeeFive == true || MarkFive.isMarked==true || SecondCanSeeFive==true)
							{
						ConvisibleFive.HisSight.SetActive(true);
							}
					if (CanSeeFive == false && MarkFive.isMarked == false && SecondCanSeeFive==false) 
							{
						ConvisibleFive.HisSight.SetActive(false);
							}

							//	}
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
			SecondEnnmyRaySix = Physics2D.Linecast (SecondRay.position, EnnemyInScene [5].position, LayerMaskOne);
					EnnmyRaySix = Physics2D.Linecast (transform.position, EnnemyInScene [5].position, LayerMaskOne);
			if (EnnmyRaySix.collider == null)
				CanSeeSix = true;
			if (SecondEnnmyRaySix.collider == null)
				SecondCanSeeSix = true;
			


					if (EnnmyRaySix.collider != null) {
						if (EnnmyRaySix.collider.tag == "bloc")
							CanSeeSix = false;
						else
							CanSeeSix = true;
			}
			if (SecondEnnmyRaySix.collider != null) {
				if (SecondEnnmyRaySix.collider.tag == "bloc")
					SecondCanSeeSix = false;
				else
					SecondCanSeeSix = true;
			}
				if (CanSeeSix == true || MarkSix == true || SecondCanSeeSix==true) {
							if (PatrolSix != null)
						ConvisibleSix.HisSight.SetActive(true);
						}
				if (CanSeeSix == false && MarkSix == false && SecondCanSeeSix==false) {
							{
								if (PatrolSix != null)
							ConvisibleSix.HisSight.SetActive(false);
							}
							//	}

						}

				}
		else
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
				print ("alert");

				AkSoundEngine.PostEvent ("Mus_Located", gameObject);
				RetrnHavePlayed = false;
				suspiciousHavePlayed = false;
				AlertHavePlayer = true;

			}

					pplatformscript.canhideThree = false;
					AlertFeedback.SetActive (true);
				}

				if(SuspiciousEnnemy [0] == false && SuspiciousEnnemy [1] == false && SuspiciousEnnemy [2] == false && SuspiciousEnnemy [3] == false && SuspiciousEnnemy [4] == false && SuspiciousEnnemy [5] == false) {
					
				SuspiciousFeedback.SetActive (false);
			ThereisAsuspicious = false;
			}
			 else {
			if (suspiciousHavePlayed==false && thereisAnAlert==false) {			
				print ("suspicious");
				

				AkSoundEngine.PostEvent ("Mus_Alert", gameObject);
				RetrnHavePlayed = false;
				AlertHavePlayer = false;
				suspiciousHavePlayed = true;

			}

			ThereisAsuspicious = true;
					SuspiciousFeedback.SetActive (true);
				}

		if (thereisAnAlert == false && ThereisAsuspicious == false){
			if (RetrnHavePlayed == false) {
				print ("explo");
				AkSoundEngine.PostEvent ("Mus_Explo", gameObject);
				AlertHavePlayer = false;
				suspiciousHavePlayed = false;
				RetrnHavePlayed = true;

			}		
		}
	}
	void Update () { 
		

	}


}
