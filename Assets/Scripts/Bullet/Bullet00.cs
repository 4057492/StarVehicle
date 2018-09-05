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
		if (other.GetComponent<Vehicle> () != null) {
			other.GetComponent<Vehicle> ().Hited ();
			if(other.GetComponent<Vehicle> ().ifInvincible==false)
				other.GetComponent<Vehicle> ().ChangeHp (damage);
			if (other.GetComponent<Vehicle> ().GetType () != typeof(Border))
				ParticleEffectFunction.Show (gameObject, "SmallExplode");
		}
		Destroy (gameObject);
	}
}
