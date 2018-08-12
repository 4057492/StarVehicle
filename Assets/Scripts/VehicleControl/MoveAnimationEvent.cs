using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimationEvent : MonoBehaviour {

	public delegate void delegateStay ();
	public static event delegateStay staying;

	public delegate void delegateUp ();
	public static event delegateUp uping;

	public delegate void delegateDown ();
	public static event delegateDown downing;

	public delegate void delegateLeft ();
	public static event delegateLeft lefting;

	public delegate void delegateRight ();
	public static event delegateRight righting;

	public delegate void delegateUpLeft ();
	public static event delegateUpLeft upLefting;

	public delegate void delegateUpRight ();
	public static event delegateUpRight upRighting;

	public delegate void delegateDownLeft ();
	public static event delegateDownLeft downLefting;

	public delegate void delegateDownRight ();
	public static event delegateDownRight downRighting;


	public static void stay(){
		if (staying != null) {
			staying ();
		}
	}

	public static void up(){
		if (uping != null) {
			uping ();
		}
	}

	public static void down(){
		if (downing != null) {
			downing ();
		}
	}

	public static void left(){
		if (lefting != null) {
			lefting ();
		}
	}

	public static void right(){
		if (righting != null) {
			righting ();
		}
	}

	public static void upLeft(){
		if (upLefting != null) {
			upLefting ();
		}
	}

	public static void upRight(){
		if (upRighting != null) {
			upRighting ();
		}
	}

	public static void downLeft(){
		if (downLefting != null) {
			downLeft ();
		}
	}

	public static void downRight(){
		if (downRighting != null) {
			downLefting ();
		}
	}

}
