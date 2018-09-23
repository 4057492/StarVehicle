using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalAniCon00 : MonoBehaviour {

	private Animator ani;



	void OnEnable(){
		ExpressionControl.WarningExpression += WarningSignal;
	}

	void OnDisable(){
		ExpressionControl.WarningExpression -= WarningSignal;
	}
		
	// Use this for initialization
	void Start () {
		ani = gameObject.GetComponent<Animator> ();
	}

	public void WarningSignal(){
		StopAllCoroutines ();
		StartCoroutine (Warning ());
	}

	IEnumerator Warning(){
		ani.Play ("WarningSignal");
		yield return new WaitForSeconds ((float)ani.GetCurrentAnimatorClipInfo (0).Length);
		ani.Play ("NormalSignal");
		yield return null;
	}

}
