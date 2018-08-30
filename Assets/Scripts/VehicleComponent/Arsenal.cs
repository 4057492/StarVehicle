using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Arsenal : MonoBehaviour {

	//private Muzzle muzzle1;
	//private Muzzle muzzle2;
	public string showBullet;
	public string[] showSounds;
	public int showNumber;


	public List<BulletString> bullets = new List<BulletString>();

	public struct BulletString{
		public string bullet;
		public string[] sounds;
		public int number;
	}
		

	// Use this for initialization
	void Start () {
		string[] tempsound = { "bullet0", "bullet1", "bullet2" };
		Add ("00", tempsound, -1);
		//muzzle1 = transform.GetChild (0).gameObject.GetComponent<Muzzle> ();
		//muzzle2 = transform.GetChild (1).gameObject.GetComponent<Muzzle> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		showBullet = bullets [0].bullet;
		showSounds = bullets [0].sounds;
		showNumber = bullets [0].number;
		if (bullets [0].number == 0)
			bullets.RemoveAt (0);
	}

//	public void Add(string bulletName,__arglist){
//		ArgIterator args = new ArgIterator (__arglist);
//		List<String> sounds = new List<String> ();
//		while (args.GetRemainingCount () > 0) {
//			sounds.Add ((string)TypedReference.ToObject (args.GetNextArg ()));
//		}
//		String[] soundsName = sounds.ToArray ();
//	}

	public void Add(string bulletName,string[] soundsName,int number){
		BulletString bullet;
		bullet.bullet = bulletName;
		bullet.sounds = soundsName;
		bullet.number = number;
		bullets.Insert (0, bullet);
	}

	public void Consume(){
		BulletString temp = bullets [0];
		temp.number--;
		bullets [0] = temp;
	}
}
