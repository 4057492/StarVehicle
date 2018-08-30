using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBag : MonoBehaviour {
	public string bulletName;
	public string[] soundsName;
	public int number;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.GetComponent<Arsenal>() != null) {
			other.gameObject.GetComponent<Arsenal> ().Add (bulletName, soundsName, number);
			Destroy (gameObject);
		}
	}
}
