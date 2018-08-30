using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBag : MonoBehaviour {
	public string bulletName;
	public string[] soundsName;
	public int number;
	public string sound;

	public float speed = 0;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.GetComponent<Arsenal>() != null) {
			SoundEffectFunction.Play (gameObject, sound);
			other.gameObject.GetComponent<Arsenal> ().Add (bulletName, soundsName, number);
			Destroy (gameObject);
		}
	}

	void Start(){
		StartCoroutine (Move ());
	}

	IEnumerator Move(){
		float temp = Random.value > 0.5f ? 1 : -1;
		while (true) {
			transform.Translate (new Vector3 (temp * speed, -1 * speed, 0));
			yield return null;
		}
	}
}
