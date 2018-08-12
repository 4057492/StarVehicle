using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour {	
	private float waitTime = AllNumControl.waitTime;
	private float Time = AllNumControl.Time;

	public static void FadeIn(GameObject g){
		g.AddComponent<TextFade> ().StartFadeIn();

	}

	public static void FadeIn(GameObject g,float time){
		g.AddComponent<TextFade> ().StartFadeIn(time);

	}

	public static void FadeOut(GameObject g){
		g.AddComponent<TextFade> ().StartFadeOut();

	}

	public static void FadeOut(GameObject g,float time){
		g.AddComponent<TextFade> ().StartFadeOut(time);

	}

	public void StartFadeIn(){
		StartCoroutine (FadeInCoroutine (Time));
	}

	public void StartFadeIn(float time){
		StartCoroutine (FadeInCoroutine (time));
	}

	public void StartFadeOut(){
		StartCoroutine (FadeOutCoroutine (Time));
	}

	public void StartFadeOut(float time){
		StartCoroutine (FadeOutCoroutine (time));
	}


	IEnumerator FadeInCoroutine(float time){
		Text text = GetComponent<Text> ();
		if (text != null) {
			float speed = 1 / time;
			Color color = text.color;
			color.a = 0;
			text.color = color;
			yield return null;
			while (color.a < 1) {
				color.a += speed;
				if (color.a > 1)
					color.a = 1;
				text.color = color;
				yield return new WaitForSecondsRealtime (waitTime);
			}
			Destroy (this);
		}
		yield return null;
	}

	IEnumerator FadeOutCoroutine(float time){
		Text text = GetComponent<Text> ();
		if (text != null) {
			float speed = 1 / time;
			Color color = text.color;
			text.color = color;
			yield return null;
			while (color.a > 0) {
				color.a -= speed;
				if (color.a < 0)
					color.a = 0;
				text.color = color;
				yield return new WaitForSecondsRealtime (waitTime);
			}
			Destroy (this);
		}
		yield return null;
	}
}

