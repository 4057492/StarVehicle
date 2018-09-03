using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy00 : Enemy {

//	public float hp = 1;
//
//	public float armour = 1;
//
//	public bool ifInvincible = false;
	//public string[] sounds = {"Fire Fireball Large 01","Fire Fireball Large 02","Fire Fireball Large 03"};
	public string[] hitesSounds = { "Weapon Axe Hit On Dirt 01", "Weapon Axe Hit On Dirt 02" };

	private CreateBulletFunc muzzle;

	void Start () {
		muzzle = transform.GetChild (0).gameObject.GetComponent<CreateBulletFunc>();
	}

	void Update () {
		if (hp <= 0 && !ifInvincible) {
			muzzle.InsBullet ("BulletBag");
			StartCoroutine (Wait ());
		}
	}

	public override void Hited ()
	{
		EventManager.shakeCamera ();
		//SoundEffectFunction.Play (gameObject, sounds,0.5f);
		SoundEffectFunction.Play (gameObject, hitesSounds);
	}

	IEnumerator Wait(){
		//yield return new WaitForSecondsRealtime (1f);
		Destroy (gameObject);
		yield return null;
	}
}
