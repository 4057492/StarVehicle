using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy00 : Vehicle {

//	public float hp = 1;
//
//	public float armour = 1;
//
//	public bool ifInvincible = false;
	//public string[] sounds = {"Fire Fireball Large 01","Fire Fireball Large 02","Fire Fireball Large 03"};

	public string[] hitesSounds;
	public string[] shootSounds;
	public GameObject white;
	public float time;

	private Coroutine shake;

	private CreateBulletFunc cbf;

	public GameObject[] muzzles;

	private Animator animator;

	public string bullet;

	public int shootWait;
	public int count = 0;

	void Start () {
		animator = GetComponent<Animator> ();
		cbf = GetComponent<CreateBulletFunc>();
	}

	void Update () {
		if (animator.GetCurrentAnimatorStateInfo (0).IsName ("Shoot") && animator.GetCurrentAnimatorStateInfo (0).normalizedTime >= 0.95f)
			animator.Play ("Normal");

		if (hp <= 0 && !ifInvincible) {
			cbf.InsBullet ("BulletBag");
			Destroy (gameObject);
		}
		if (count == 0)
			Shoot ();
		count++;
		if (count == shootWait)
			count = 0;
	}

	private void Shoot(){
		animator.Play ("Shoot");
		SoundEffectFunction.Play (gameObject, shootSounds);
		for (int i = 0; i < muzzles.Length; i++)
			muzzles [i].GetComponent<CreateBulletFunc> ().InsBullet (bullet);
	}




	public override void Hited ()
	{
		EventManager.shakeCamera ();
		if (shake == null)
			shake = StartCoroutine (WhiteShake (time));
		SoundEffectFunction.Play (gameObject, hitesSounds);
	}

	IEnumerator WhiteShake(float time){
		white.SetActive (true);
		yield return new WaitForSeconds (time);
		white.SetActive (false);
		shake = null;
		yield return null;

	}


}
