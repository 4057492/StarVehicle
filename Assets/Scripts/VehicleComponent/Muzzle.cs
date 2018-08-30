using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muzzle : MonoBehaviour {

	private CreateBulletFunc createBullet;
	public int pauseTime = 100;
	public string bullet;
	public int count = 0;
	private Arsenal arsenal;

	// Use this for initialization
	void Start () {
		createBullet = GetComponent<CreateBulletFunc> ();
		arsenal = transform.parent.gameObject.GetComponent<Arsenal> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (count == pauseTime)
			count = 0;

		if (count != 0)
			count++;
		
		if (count == 0) {
			if (Input.GetButton ("Fire1")) {
				//SoundEffectFunction.Play (gameObject, __arglist("bullet0", "bullet1", "bullet2"));
				SoundEffectFunction.Play(gameObject,arsenal.bullets[0].sounds);
				createBullet.InsBullet (arsenal.bullets[0].bullet);
				if (arsenal.bullets [0].number > 0)
					arsenal.Consume ();
				count++;
			}
			
		}
	}
}
