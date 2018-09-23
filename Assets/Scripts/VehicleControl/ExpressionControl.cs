using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpressionControl : MonoBehaviour {

	public static int current = 0;

	public delegate void Normal ();
	public static event Normal NormalExpression;

	public delegate void Warning ();
	public static event Warning WarningExpression;


	public static void ChangeToNormal(){
		int level = 0;
		if (level > current && NormalExpression != null)
			NormalExpression ();
	}

	public static void ChangeToWarning(){
		int level = 1;
		if (level > current && WarningExpression != null)
			WarningExpression ();
	}

}
