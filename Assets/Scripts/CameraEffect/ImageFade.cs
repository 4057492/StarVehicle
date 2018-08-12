using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFade : MonoBehaviour {
	private float waitTime = AllNumControl.waitTime;
	private float Time = AllNumControl.Time;

	public static void FadeIn(GameObject g){
		g.AddComponent<ImageFade> ().StartFadeIn();

	}

	public static void FadeIn(GameObject g,float time){
		g.AddComponent<ImageFade> ().StartFadeIn(time);

	}

	public static void FadeOut(GameObject g){
		g.AddComponent<ImageFade> ().StartFadeOut();

	}

	public static void FadeOut(GameObject g,float time){
		g.AddComponent<ImageFade> ().StartFadeOut(time);

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
		Image image = GetComponent<Image> ();
		if (image != null) {
			float speed = 1 / time;
			Color color = image.color;
			color.a = 0;
			image.color = color;
			yield return null;
			while (color.a < 1) {
				color.a += speed;
				if (color.a > 1)
					color.a = 1;
				image.color = color;
				yield return new WaitForSecondsRealtime (waitTime);
			}
			Destroy (this);
		}
		yield return null;
	}

	IEnumerator FadeOutCoroutine(float time){
		Image image = GetComponent<Image> ();
		if (image != null) {
			float speed = 1 / time;
			Color color = image.color;
			image.color = color;
			yield return null;
			while (color.a > 0) {
				color.a -= speed;
				if (color.a < 0)
					color.a = 0;
				image.color = color;
				yield return new WaitForSecondsRealtime (waitTime);
			}
			Destroy (this);
		}
		yield return null;
	}
}
