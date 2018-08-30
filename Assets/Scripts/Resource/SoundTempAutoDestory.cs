using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTempAutoDestory : MonoBehaviour {
	private AudioSource au;
	// Use this for initialization
	void Start () {
		au = GetComponent<AudioSource> ();
		StartCoroutine (Des ());
	}


	IEnumerator Des(){
		while (au.clip == null)
			yield return null;
		au.Play ();
		yield return new WaitForSecondsRealtime (au.clip.length);
		Destroy (gameObject);
		yield return null;
	}
}
