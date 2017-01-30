using UnityEngine;
using System.Collections;

public class DestroyContinueButton : MonoBehaviour {
	public GameObject checkPointChecker;
	public int MaxNumber;
	public int MinNumber;
	public GameObject Thisgameobject;

	// Use this for initialization
	void Start () {
		if (checkPointChecker.GetComponent<FindCheckPoitnState> ().Checkpointstate < MaxNumber && checkPointChecker.GetComponent<FindCheckPoitnState> ().Checkpointstate >= MinNumber)
			Destroy (Thisgameobject);
	}
	
	// Update is called once per frame
	void Update () {
		if (checkPointChecker.GetComponent<FindCheckPoitnState> ().Checkpointstate < MaxNumber && checkPointChecker.GetComponent<FindCheckPoitnState> ().Checkpointstate >= MinNumber||checkPointChecker.GetComponent<FindCheckPoitnState> ().Checkpointstate==0)
		{
			Destroy (Thisgameobject);
		}
		}
}
