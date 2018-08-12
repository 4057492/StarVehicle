using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFlash : MonoBehaviour {
	private Color origin;
	public Color flash;
	public float lastTime = 0;

	private bool isFlash = false; 

	// Use this for initialization
	void Start () {
		origin = GetComponent<SpriteRenderer> ().color;
	}
	
	public void flashing(){
		if(!isFlash){
			StartCoroutine (FlashCoroutine ());
		}
	}

	IEnumerator FlashCoroutine(){
		isFlash = true;
		GetComponent<SpriteRenderer> ().color = flash;
		yield return new WaitForSecondsRealtime (lastTime);
		GetComponent<SpriteRenderer> ().color = origin;
		isFlash = false;
		yield return null;
	}
}
