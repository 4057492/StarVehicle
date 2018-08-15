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
		instance.AddComponent<ParticleDestoryAuto> ();
		ps = instance.GetComponent<ParticleSystem> ();
	}

	IEnumerator End(){
		while (ps == null)
			yield return null;
		yield return new WaitForSecondsRealtime (ps.main.duration);
		if(instance!=null)
			Destroy (instance);
		Destroy (this);
		yield return null;
	}

	public static void Show(GameObject g , string name){
		g.AddComponent<ParticleEffectFunction> ().InsParticle (name);
	}

}
