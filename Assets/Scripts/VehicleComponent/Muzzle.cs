using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muzzle : MonoBehaviour {

	private CreateBulletFunc createBullet;
	public int pauseTime = 100;
	public string bullet;
	public int count = 0;

	// Use this for initialization
	void Start () {
		createBullet = GetComponent<CreateBulletFunc> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (count == pauseTime)
			count = 0;

		if (count != 0)
			count++;
		
		if (count == 0) {
			if (Input.GetButton ("Fire1")) {
				createBullet.InsBullet (bullet);
				count++;
			}
			
		}
	}
}
