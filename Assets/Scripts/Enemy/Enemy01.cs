using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy01 : Vehicle {

	//	public float hp = 1;
	//
	//	public float armour = 1;
	//
	//	public bool ifInvincible = false;

	// Use this for initialization

	private int i = 0;
	private int count = 20;
	private CreateBulletFunc cbf;


	void Start () {
		cbf = GetComponent<CreateBulletFunc> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (i == 0) {
			cbf.InsBullet ("00");
		}
		i++;
		if (i >= count)
			i = 0;
	}
}
