using UnityEngine;
using System.Collections;

[SerializeField]
public class SaveSystem : MonoBehaviour {
	public int SavePoint;
	public float timer = 2;
	// Use this for initialization
	void Start () {
		SavePoint = PlayerPrefs.GetInt ("Save_Point");
		DontDestroyOnLoad(transform.gameObject);
		InvokeRepeating ("CheckPointInstance",1f,1f);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void CheckPointInstance()
	{
		PlayerPrefs.SetInt ("Save_Point",SavePoint);
	}
}
