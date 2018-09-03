using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFadeAllChildren : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SpriteFade.FadeInAllChildren (gameObject,100f);
		StartCoroutine (OpenAnimator ());
	}

	void EnableAllChildrenAnimator(){
		for (int i = 0; i < transform.childCount; i++) {
			if (transform.GetChild (i).gameObject.GetComponent<Animator> () != null) {
				transform.GetChild (i).gameObject.GetComponent<Animator> ().enabled = true;
			}
		}
	}

	IEnumerator OpenAnimator(){
		yield return new WaitForSeconds (100f * AllNumControl.waitTime);
		EnableAllChildrenAnimator ();
		yield return null;
	}
}
