using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy00 : Enemy {

//	public float hp = 1;
//
//	public float armour = 1;
//
//	public bool ifInvincible = false;
	public string[] sounds = {"Fire Fireball Large 01","Fire Fireball Large 02","Fire Fireball Large 03"};

	void Start () {

	}

	void Update () {
		if (hp <= 0 && !ifInvincible) {
			StartCoroutine (Wait ());
		}
	}

	public override void Hited ()
	{
		EventManager.shakeCamera ();
		SoundEffectFunction.Play (gameObject, sounds,0.5f);
	}

	IEnumerator Wait(){
		yield return new WaitForSecondsRealtime (1f);
		Destroy (gameObject);
		yield return null;
	}
}
