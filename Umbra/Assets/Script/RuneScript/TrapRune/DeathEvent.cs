using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEvent : MonoBehaviour {
	public GameObject[] PossibleSprite;
	public bool EventTriggered=false;
	public int number;
	public GameObject ActualCadre;
	public Transform rightTransform;
	public Transform LeftTransform;
	public Transform Center;
	Vector3 dir;
	public int tempoKill;
	float timerEvent;
	float xNumber;
	public GameObject BloodRight;
	public GameObject BloodLeft;
	GameObject un;

	public Transform EnnemyPos;
	public GameObject Ennemy;

	public GameObject AssassinTrigger;
	// Use this for initialization
	void Start () {
		AssassinTrigger = GameObject.Find ("AssassinTrigger");
		patate ();
		un.GetComponent<DeathEvent>().patate();
	}
	public void patate()
	{
		print ("im stupid");
	}
	// Update is called once per frame
	void Update () {
//		dir=new Vector3(ActualCadre.transform.position.x-Center.position.x, ActualCadre.transform.position.y-Center.position.y,0);
		//
//		if(EventTriggered)
//		{
//			dir=new Vector3(ActualCadre.transform.position.x-Center.position.x, ActualCadre.transform.position.y-Center.position.y,0);
//
//			timerEvent -= Time.deltaTime;
//			ActualCadre.transform.position += dir * Time.deltaTime*20;
//			xNumber -= Time.deltaTime;
////			if (timerEvent < 3)
////				PossibleSprite [number].GetComponent<Animator> ().SetBool ("Play", true);
//			
//		
//
//
//		}
	}

	public void chooseSprite()
	{
		GetComponent<PlatformerCharacter2D> ().CanTurn = false;

		GetComponent<PlatformerCharacter2D> ().m_MaxSpeed = 0;
			
		AkSoundEngine.PostEvent ("PC_Action_Kill", gameObject);
        //GetComponent<Animator>().SetBool("Ation", true);
        tempoKill++;
		number=Random.Range(0,4);
		ActualCadre = PossibleSprite [number];
		Ennemy = AssassinTrigger.GetComponent<checkIfAssassination> ().ActualEnnemy;

		rightTransform.position = new Vector3 (Ennemy.transform.position.x-10, Ennemy.transform.position.y+0.5f, 0);
		LeftTransform.position  = new Vector3 (Ennemy.transform.position.x+10, Ennemy.transform.position.y+0.5f, 0);
		Center.position= new Vector3 (transform.position.x , transform.position.y+0.5f, 0);
		EnnemyPos.position = new Vector3 (Ennemy.transform.position.x, Ennemy.transform.position.y+0.5f, 0);
		Time.timeScale = 0.3f;
		if (GetComponent<PlatformerCharacter2D> ().m_FacingRight == true) {
			BloodRight = (GameObject)Resources.Load ("BloodRightEpic",typeof (GameObject));
			Instantiate(BloodRight, new Vector3(EnnemyPos.position.x+0.5f,EnnemyPos.position.y,EnnemyPos.position.z), Quaternion.Euler(0,90,-90) );
			StartCoroutine(StartRightAnim());

		}

		if (GetComponent<PlatformerCharacter2D> ().m_FacingRight == false)
		{
			BloodLeft = (GameObject)Resources.Load ("BloodEffectFacingLeft",typeof (GameObject));
			Instantiate(BloodLeft, new Vector3(EnnemyPos.position.x-3f,EnnemyPos.position.y-1.2f,EnnemyPos.position.z),Quaternion.Euler(0,180,0) );
			StartCoroutine(StartLeftAnim()); 

		}
		EventTriggered=true;
        //GetComponent<Animator>().SetBool("Ation", false);
        timerEvent = 5;
}

	IEnumerator StartRightAnim()
	{
		yield return new WaitForSeconds (0.2f);
		Instantiate (ActualCadre,rightTransform.position, transform.rotation);


	}
	IEnumerator StartLeftAnim()
	{
		yield return new WaitForSeconds (0.2f);
		Instantiate (ActualCadre,LeftTransform.position, transform.rotation);


	}

}