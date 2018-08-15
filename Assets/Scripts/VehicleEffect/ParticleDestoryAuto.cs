using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestoryAuto : MonoBehaviour {

	private ParticleSystem ps;

	void Start () {
		ps = GetComponent<ParticleSystem> ();
		StartCoroutine (End ());
	}
	
	IEnumerator End(){
		yield return new WaitForSecondsRealtime (ps.main.duration);
		Destroy (gameObject);
		yield return null;
	}
}
