using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class CameraBloomFunc : MonoBehaviour {
	[Range(0.0f, 2.5f)]
	public float maxintensity = 1.0f;
	[Range(0.0f, 2.5f)]
	public float BloomSpeed = 0.1f;
	public float waitTime = 0.1f;
	private BloomOptimized Bloom;

	void Start () {
		Bloom = GetComponent<BloomOptimized> ();
	}

	public void CamBloom(){
		if (!Bloom.enabled) {
			StartCoroutine (CameraBloomCoroutine ());
		}
	}
	public void CamDisBloom(){
		if (Bloom.enabled) {
			StartCoroutine (CameraDisBloomCoroutine ());
		}
	}

	IEnumerator CameraBloomCoroutine(){
		Bloom.enabled = true;
		yield return null;
		while (Bloom.intensity <= maxintensity) {
			Bloom.intensity += BloomSpeed;
			yield return new WaitForSecondsRealtime (waitTime);
		}
	}

	IEnumerator CameraDisBloomCoroutine(){
		while (Bloom.intensity >= BloomSpeed) {
			Bloom.intensity -= BloomSpeed;
			yield return new WaitForSecondsRealtime (waitTime);
		}
		Bloom.intensity = 0;
		Bloom.enabled = false;
		yield return null;
	}
}
