using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleForce : MonoBehaviour {

	private ParticleSystem ps;
	private ParticleSystem.ForceOverLifetimeModule fo;
	public AnimationCurve curve = AnimationCurve.Constant (0, 1f, 0);
	private Rigidbody rig;
	public float i = -1f;
//
//	public AnimationCurve x;
//
//	// Use this for initialization
//	void Start () {
//		par = GetComponent<ParticleSystem> ();
//		rig = transform.parent.gameObject.GetComponent<Rigidbody> ();
//		x = AnimationCurve.Constant (0, 1f, 0f);
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		//x = AnimationCurve.Constant (0, 1f, rig.velocity.x * i);
//		//par.forceOverLifetime.x.constant = rig.velocity.x * i;
//		var temp = par.forceOverLifetime.x;
//		par.forceOverLifetime.x = temp;
//	}
	void Start() {
		rig = transform.parent.gameObject.GetComponent<Rigidbody> ();
        ps = GetComponent<ParticleSystem>();
        fo = ps.forceOverLifetime;
		fo.enabled = true;
    }

	void Update(){
		curve = AnimationCurve.Constant (0, 1f, rig.velocity.x * i);
		fo.x = new ParticleSystem.MinMaxCurve (1, curve);
	
	}

}
