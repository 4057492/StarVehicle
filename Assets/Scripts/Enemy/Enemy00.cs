using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy00 : Enemy {

//	public float hp = 1;
//
//	public float armour = 1;
//
//	public bool ifInvincible = false;

	void Start () {

	}

	void Update () {
		if (hp <= 0 && !ifInvincible) {
			Destroy (gameObject);
		}
	}

	public override void Hited ()
	{
		EventManager.shakeCamera ();
	}
}
