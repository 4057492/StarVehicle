using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet00 : Bullet {
	public float speed = 0.1f;
	public float damage = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, speed, 0);
	}

	void OnTriggerEnter(Collider other){
		if (other.GetComponent<Enemy> () != null) {
			other.GetComponent<Enemy> ().Hited ();
			other.GetComponent<Enemy> ().ChangeHp (damage);
		}
		ParticleEffectFunction.Show (gameObject, "SmallExplode");
		Destroy (gameObject);
	}
}
