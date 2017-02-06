using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRune : MonoBehaviour {
	public int TemporaryOffenseRune;
	public int TemporaryDefRune;
	public int TemporaryTacticRune;
	void Awake()
	{
		DontDestroyOnLoad (gameObject);
	}
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetOffenseRuneMark()
	{
		TemporaryOffenseRune = 2;
	}
	public void SetOffenseRuneTrap()
	{
		TemporaryOffenseRune = 1;
	}
	public void SetDefRuneShadowCreate()
	{
		TemporaryDefRune = 1;
	}
	public void SetDefRuneLure()
	{
		TemporaryDefRune = 2;
	}
	public void setTacticAccrochage()
	{
		TemporaryTacticRune = 1;
	}
	public void setTacticSolid()
	{
		TemporaryTacticRune = 2;
	}


}
