using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectFunction : MonoBehaviour {
	private GameObject instance;
	private ParticleSystem ps;

	void Start () {
		StartCoroutine (End ());
	}
		
	public void InsParticle(string name){
		instance = Instantiate (Resources.Load ("Particle Effects/"+name, typeof(GameObject))) as GameObject;
		instance.transform.position = gameObject.transform.position;
		ps = instance.GetComponent<ParticleSystem> ();
	}

	IEnumerator End(){
		while (ps == null)
			yield return null;
		while (ps.isPlaying)
			yield return null;
		Destroy (instance);
		Destroy (this);
		yield return null;
	}

	public static void Show(GameObject g , string name){
		g.AddComponent<ParticleEffectFunction> ().InsParticle (name);
	}

}
