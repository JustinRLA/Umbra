using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEvent : MonoBehaviour {
	public GameObject[] PossibleSprite;
	public bool EventTriggered=false;
	int number;
	public GameObject ActualCadre;
	public Transform rightTransform;
	public Transform LeftTransform;
	public Transform Center;
	Vector3 dir;
	float timerEvent;
	float xNumber;
	public Transform EnnemyPos;
	public GameObject Ennemy;

	public GameObject AssassinTrigger;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		dir=new Vector3(ActualCadre.transform.position.x-Center.position.x, ActualCadre.transform.position.y-Center.position.y,0);

		if(EventTriggered)
		{
			dir=new Vector3(ActualCadre.transform.position.x-Center.position.x, ActualCadre.transform.position.y-Center.position.y,0);

			timerEvent -= Time.deltaTime;
			ActualCadre.transform.position += dir * Time.deltaTime*20;
			xNumber -= Time.deltaTime;
//			if (timerEvent < 3)
//				PossibleSprite [number].GetComponent<Animator> ().SetBool ("Play", true);
			
			if (timerEvent<=2)
			{
				dir=new Vector3(Ennemy.transform.position.x-ActualCadre.transform.position.x, Ennemy.transform.position.y-ActualCadre.transform.position.y,0);

			}


		}
	}

	public void chooseSprite()
	{
		number=Random.Range(0,4);
		ActualCadre = PossibleSprite [number];
		rightTransform.position = new Vector3(transform.position.x + 10, transform.position.y, 0);
		LeftTransform.position  = new Vector3 (transform.position.x - 10, transform.position.y, 0);
		Center.position= new Vector3 (transform.position.x , transform.position.y, 0);
		//Ennemy = AssassinTrigger.GetComponent<checkIfAssassination> ().ActualEnnemy;
		EnnemyPos.position = new Vector3 (Ennemy.transform.position.x, Ennemy.transform.position.y + 10, 0);
		if (GetComponent<PlatformerCharacter2D> ().m_FacingRight == true)
			Instantiate (ActualCadre,rightTransform.position, transform.rotation);

		if (GetComponent<PlatformerCharacter2D> ().m_FacingRight == false)
			Instantiate (ActualCadre, LeftTransform.position ,transform.rotation);


		EventTriggered=true;
		timerEvent = 5;
}
}