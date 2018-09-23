using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle00 : Vehicle {

	//	public float hp = 1;
	//
	//	public float armour = 1;
	//
	//	public bool ifInvincible = false;

	public string[] hitesSounds;

	public override void Hited ()
	{
		EventManager.shakeCamera ();
		//SoundEffectFunction.Play (gameObject, sounds,0.5f);
		SoundEffectFunction.Play (gameObject, hitesSounds);
		ExpressionControl.ChangeToWarning ();
	}
	// Use this for initialization
	void Start () {
		hp = 100;
	}

	void OnTriggerEnter(Collider other){
		base.Crash (other);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
