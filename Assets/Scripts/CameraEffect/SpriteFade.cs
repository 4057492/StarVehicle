using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFade : MonoBehaviour {
	private float waitTime = AllNumControl.waitTime;
	private float Time = AllNumControl.Time;

	public static void FadeIn(GameObject g){
		g.AddComponent<SpriteFade> ().StartFadeIn();

	}

	public static void FadeIn(GameObject g,float time){
		g.AddComponent<SpriteFade> ().StartFadeIn(time);

	}

	public static void FadeOut(GameObject g){
		g.AddComponent<SpriteFade> ().StartFadeOut();

	}

	public static void FadeOut(GameObject g,float time){
		g.AddComponent<SpriteFade> ().StartFadeOut(time);

	}

	public static void FadeInAllChildren(GameObject g){
		for (int i = 0; i < g.transform.childCount; i++) {
			g.transform.GetChild(i).gameObject.AddComponent<SpriteFade> ().StartFadeIn();
		}
	}

	public static void FadeInAllChildren(GameObject g,float time){
		for (int i = 0; i < g.transform.childCount; i++) {
			g.transform.GetChild(i).gameObject.AddComponent<SpriteFade> ().StartFadeIn(time);
		}
	}

	public static void FadeOutAllChildren(GameObject g){
		for (int i = 0; i < g.transform.childCount; i++) {
			g.transform.GetChild(i).gameObject.AddComponent<SpriteFade> ().StartFadeOut();
		}
	}

	public static void FadeOutAllChildren(GameObject g,float time){
		for (int i = 0; i < g.transform.childCount; i++) {
			g.transform.GetChild(i).gameObject.AddComponent<SpriteFade> ().StartFadeOut(time);
		}
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
		SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer> ();
		if (renderer != null) {
			float speed = 1 / time;
			Color color = renderer.color;
			float oriA = renderer.color.a;
			color.a = 0;
			renderer.color = color;
			yield return null;
			while (color.a < oriA) {
				color.a += speed;
				if (color.a > oriA)
					color.a = oriA;
				renderer.color = color;
				yield return new WaitForSecondsRealtime (waitTime);
			}
			Destroy (this);
		}
		yield return null;
	}

	IEnumerator FadeOutCoroutine(float time){
		SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer> ();
		if (renderer != null) {
			float speed = 1 / time;
			Color color = renderer.color;
			renderer.color = color;
			yield return null;
			while (color.a > 0) {
				color.a -= speed;
				if (color.a < 0)
					color.a = 0;
				renderer.color = color;
				yield return new WaitForSecondsRealtime (waitTime);
			}
			Destroy (this);
		}
		yield return null;
	}
}
