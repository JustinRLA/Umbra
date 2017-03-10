using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timerLure : MonoBehaviour {
	Image image;
	float ratio;
	public float fraction=7;

	// Use this for initialization
	void Start () {
		image = GetComponent<Image> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		fraction-= Time.deltaTime;

		ratio = 1 * (fraction/7);

	//	print (ratio);
		image.rectTransform.localScale=new Vector3(0.035f*ratio, 0.007f, 0.6f);
	}
}
