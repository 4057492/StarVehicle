using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedSoundEffect : MonoBehaviour {
	private Rigidbody rig;
	private AudioSource au;
	private float orginPitch;
	public float i = 1;
	// Use this for initialization
	void Start () {
		rig = transform.parent.gameObject.GetComponent<Rigidbody> ();
		au = GetComponent<AudioSource> ();
		orginPitch = au.pitch;
	}
	
	// Update is called once per frame
	void Update () {
		au.pitch = orginPitch + rig.velocity.magnitude * i;
	}
}
