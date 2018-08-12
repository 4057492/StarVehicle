using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeFunc : MonoBehaviour {
	public float speed = 1f;
	public float range = 1f;
	public float waitTime = 0.1f;

	private int time = 0;

	private bool isShaking = false;

	void OnEnable(){
		EventManager.shaking += CamShake;
	}

	void OnDisable(){
		EventManager.shaking -= CamShake;
	}

	public void CamShake(){
		if (!isShaking) {
			StartCoroutine (CameraShakeCoroutine ());
		}
	}


	IEnumerator CameraShakeCoroutine(){
		isShaking = true;
		time = (int)(range / speed);
		for(int i = 0;i<time;i++){
			transform.Translate (speed, 0, 0);
			yield return new WaitForSecondsRealtime (waitTime);
		}
		for(int i = 0;i<time;i++){
			transform.Translate (-speed, -speed, 0);
			yield return new WaitForSecondsRealtime (waitTime);
		}
		for(int i = 0;i<time;i++){
			transform.Translate (-speed, speed, 0);
			yield return new WaitForSecondsRealtime (waitTime);
		}
		for(int i = 0;i<time;i++){
			transform.Translate (speed, speed, 0);
			yield return new WaitForSecondsRealtime (waitTime);
		}
		for(int i = 0;i<time;i++){
			transform.Translate (0, -speed, 0);
			yield return new WaitForSecondsRealtime (waitTime);
		}
		isShaking = false;
		yield return null;
	}
}
