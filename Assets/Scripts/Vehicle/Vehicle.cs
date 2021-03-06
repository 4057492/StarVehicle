using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour {
	public float hp = 1;

	public float armour = 1;

	public bool ifInvincible = false;

	public float damage = 1;

	public virtual void Hited(){
	
	}

	public void ChangeHp(float damage){
		hp -= damage * armour;
	}

	public void Crash(Collider other){
		if (other.GetComponent<Vehicle> () != null) {
			other.GetComponent<Vehicle> ().Hited ();
			if (other.GetComponent<Vehicle> ().ifInvincible == false)
				other.GetComponent<Vehicle> ().ChangeHp (damage);
			if (other.GetComponent<Vehicle> ().GetType () == typeof(Border))
				Destroy (gameObject);
			else
				Hited ();
		}
	}
}
