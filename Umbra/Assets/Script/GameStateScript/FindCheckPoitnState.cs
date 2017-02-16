using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FindCheckPoitnState : MonoBehaviour {
	public int Checkpointstate;
	public GameObject Savesystem;
	public GameObject restartObject;


	// Use this for initialization
	void Start () {
		if(Savesystem != null){

	Savesystem = GameObject.Find ("SaveSystem");
	Checkpointstate = Savesystem.GetComponent<SaveSystem> ().SavePoint;
		}

	}
	
	// Update is called once per frame
	void Update () {

		if (restartObject.GetComponent<RestartGame> ().restart == true)
		{
			if(Savesystem!=null)
			Savesystem.GetComponent<SaveSystem> ().SavePoint = 0;
			SceneManager.LoadScene ("Chapter One");
				
		}
	}
}
