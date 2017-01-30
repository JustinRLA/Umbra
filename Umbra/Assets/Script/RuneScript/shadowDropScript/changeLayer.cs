using UnityEngine;
using System.Collections;

public class changeLayer : MonoBehaviour {
	public GameObject MyBase;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(MyBase.GetComponent<DragShadow>()==null)
			{
			GetComponent<SpriteRenderer>().sortingOrder=0;
			GetComponent<changeLayer>().enabled=false;
	}
}
}