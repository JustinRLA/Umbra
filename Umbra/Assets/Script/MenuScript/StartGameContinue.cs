using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartGameContinue : MonoBehaviour {
	public GameObject Scriptmanager;

	public GameObject start;


	// Use this for initialization
	void Start () {
		if (Scriptmanager.GetComponent<FindCheckPoitnState> ().Checkpointstate != 0)
		start.SetActive(false);
		

	}
	
	// Update is called once per frame
	void Update () {
		if (Scriptmanager.GetComponent<FindCheckPoitnState> ().Checkpointstate != 0)
			start.SetActive(false);

	}


}
