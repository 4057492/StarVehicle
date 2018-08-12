using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class CameraNoiseFunc : MonoBehaviour {
	public float maxintensity = 4.0f;
	public float NoiseSpeed = 0.1f;
	public float waitTime = 0.1f;
	private NoiseAndGrain Noise;


	void Start () {
		Noise = GetComponent<NoiseAndGrain> ();
	}

	public void CamNoise(){
		if (!Noise.enabled) {
			if (maxintensity >= 0) 
				StartCoroutine (CameraNoiseCoroutine ());
			 else
				StartCoroutine (CameraBlackNoiseCoroutine ());
		}
	}
	public void CamDisNoise(){
		if (Noise.enabled) {
			if(maxintensity >= 0)
				StartCoroutine (CameraDisNoiseCoroutine ());
			else
				StartCoroutine (CameraDisBlackNoiseCoroutine ());
		}
	}

	IEnumerator CameraNoiseCoroutine(){
		Noise.enabled = true;
		yield return null;
		while (Noise.intensityMultiplier <= maxintensity) {
			Noise.intensityMultiplier += NoiseSpeed;
			yield return new WaitForSecondsRealtime (waitTime);
		}
	}

	IEnumerator CameraDisNoiseCoroutine(){
		while (Noise.intensityMultiplier >= NoiseSpeed) {
			Noise.intensityMultiplier -= NoiseSpeed;
			yield return new WaitForSecondsRealtime (waitTime);
		}
		Noise.enabled = false;
		Noise.intensityMultiplier = 0;
		yield return null;
	}

	IEnumerator CameraBlackNoiseCoroutine(){
		Noise.enabled = true;
		yield return null;
		while (Noise.intensityMultiplier >= maxintensity) {
			Noise.intensityMultiplier -= NoiseSpeed;
			yield return new WaitForSecondsRealtime (waitTime);
		}
	}

	IEnumerator CameraDisBlackNoiseCoroutine(){
		while (Noise.intensityMultiplier <= -NoiseSpeed) {
			Noise.intensityMultiplier += NoiseSpeed;
			yield return new WaitForSecondsRealtime (waitTime);
		}
		Noise.enabled = false;
		Noise.intensityMultiplier = 0;
		yield return null;
	}
}
