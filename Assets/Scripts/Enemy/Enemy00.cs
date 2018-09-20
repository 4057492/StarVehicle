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

	public float prepareTime = 1f;

	private bool ifReady = false;


	void Start () {
		animator = GetComponent<Animator> ();
		cbf = GetComponent<CreateBulletFunc>();
		StartCoroutine (Wait ());
	}

	void Update () {
		if (animator.GetCurrentAnimatorStateInfo (0).IsName ("Shoot") && animator.GetCurrentAnimatorStateInfo (0).normalizedTime >= 0.95f)
			animator.Play ("Normal");

		if (hp <= 0 && !ifInvincible) {
			cbf.InsBullet ("BulletBag");
			Destroy (gameObject);
		}
		if (ifReady) {
			if (count == 0)
				Shoot ();
			count++;
			if (count == shootWait)
				count = 0;
		}
	}

	private void Shoot(){
		animator.Play ("Shoot");
		SoundEffectFunction.Play (gameObject, shootSounds);
		for (int i = 0; i < muzzles.Length; i++)
			muzzles [i].GetComponent<CreateBulletFunc> ().InsBullet (bullet);
	}

//	void OnTriggerEnter(Collider other){
//		if (other.GetComponent<Vehicle> () != null) {
//			other.GetComponent<Vehicle> ().Hited ();
//			if (other.GetComponent<Vehicle> ().ifInvincible == false)
//				other.GetComponent<Vehicle> ().ChangeHp (damage);
//			if (other.GetComponent<Vehicle> ().GetType () == typeof(Border))
//				Destroy (gameObject);
//			else
//				Hited ();
//		}
//	}

	void OnTriggerEnter(Collider other){
		base.Crash (other);
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

	IEnumerator Wait(){
		yield return new WaitForSeconds (prepareTime);
		ifReady = true;
		yield return null;
	}


}
