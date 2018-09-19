using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle00 : Vehicle {

	//	public float hp = 1;
	//
	//	public float armour = 1;
	//
	//	public bool ifInvincible = false;
	public float damage;

	public string[] hitesSounds;

	public override void Hited ()
	{
		EventManager.shakeCamera ();
		//SoundEffectFunction.Play (gameObject, sounds,0.5f);
		SoundEffectFunction.Play (gameObject, hitesSounds);
	}
	// Use this for initialization
	void Start () {
		hp = 100;
	}

	void OnTriggerEnter(Collider other){
		if (other.GetComponent<Vehicle> () != null) {
			other.GetComponent<Vehicle> ().Hited ();
			if (other.GetComponent<Vehicle> ().ifInvincible == false)
				other.GetComponent<Vehicle> ().ChangeHp (damage);
			if (other.GetComponent<Vehicle> ().GetType () == typeof(Border))
				Destroy (gameObject);
			else
				Hited ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
