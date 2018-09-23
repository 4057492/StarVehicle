using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedlightAniCon00 : MonoBehaviour {

	private Animator ani;



	void OnEnable(){
		ExpressionControl.WarningExpression += RedLight;
	}

	void OnDisable(){
		ExpressionControl.WarningExpression -= RedLight;
	}

	// Use this for initialization
	void Start () {
		ani = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RedLight(){
		StopAllCoroutines ();
		StartCoroutine (Lighting ());
	}

	IEnumerator Lighting(){
		ani.Play ("WarningLight");
		yield return new WaitForSeconds ((float)ani.GetCurrentAnimatorClipInfo (0).Length);
		ani.Play ("NormalLight");
		yield return null;
	
	}

}
