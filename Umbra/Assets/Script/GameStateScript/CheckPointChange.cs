using UnityEngine;
using System.Collections;

public class CheckPointChange : MonoBehaviour {
	public int AssignCheckpoint;
	public GameObject PlayerOne;
	int actualKill;
	int saveNumber;
	public GameObject initialializer;


	// Use this for initialization
	void Start () {
		initialializer=GameObject.Find("Initialiser");

		//DeathManager=GameObject.Find("deathManager");
		PlayerOne=GameObject.Find("2DCharacter(Clone)");
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		//print ("Check");

		if (col.tag == "Player")
		{
			actualKill = PlayerPrefs.GetInt ("Kill") + PlayerOne.GetComponent<DeathEvent> ().tempoKill;
			PlayerPrefs.SetInt ("Kill", actualKill);
//			CheckPointManager.GetComponent<CheckPointState> ().CheckpointState = AssignCheckpoint;
			//print ("Check");
			//DeathManager.GetComponent<DeathManagerScript>().CheckPointState=CheckPointManager.GetComponent<CheckPointState> ().CheckpointState = AssignCheckpoint;
			PlayerPrefs.SetInt ("SaveSystem", AssignCheckpoint);
			saveNumber=PlayerPrefs.GetInt ("SaveSystem");
			initialializer.GetComponent<InitializeLevel> ().BackGround [saveNumber].SetActive (true);
			if(saveNumber>1)
			initialializer.GetComponent<InitializeLevel> ().BackGround [saveNumber-2].SetActive (false);
			
			initialializer.GetComponent<InitializeLevel> ().BackGround [saveNumber+1].SetActive (true);
			initialializer.GetComponent<InitializeLevel> ().BackGround [saveNumber-1].SetActive (true);


		}

	}
}
