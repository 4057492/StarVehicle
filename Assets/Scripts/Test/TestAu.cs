using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//SoundEffectFunction.Play (gameObject, "helicopter");
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		test ();
	}

	public void test(){
		string[] names = { "bullet0", "bullet1" };
		SoundEffectFunction.Play (gameObject, names);
	}
}
