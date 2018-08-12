using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {
	//在此处声明新的事件 
	public delegate void ChangeCursorToAttack ();
	public static event ChangeCursorToAttack changingToAttack;

	public delegate void DisactiveCurrentHero ();
	public static event DisactiveCurrentHero disactiving;

	public delegate void ActiveCurrentHero ();
	public static event ActiveCurrentHero activing;

	public delegate void CameraShake ();
	public static event CameraShake shaking;

	public delegate void CameraBlur();
	public static event CameraBlur bluring;


	public delegate void CameraDisBlur();
	public static event CameraBlur disBluring;


	//在此处写静态函数
	public static void changeCursorToAttack(){
		if (changingToAttack != null) {
			changingToAttack ();
		}
	}

	public static void changeCursorToDefault(){
		Cursor.SetCursor (null, Vector2.zero, CursorMode.Auto);
	}

	public static void disactiveCurrentHero(){
		if (disactiving != null) {
			disactiving ();
		}
	}

	public static void activeCurrentHero(){
		if (activing != null) {
			activing ();
		}
	}
		
	public static void shakeCamera(){
		if (shaking != null) {
			shaking ();
		}
	}

	public static void blurCamera(){
		if (bluring != null) {
			bluring ();
		}
	}
		
	public static void disBlurCamera(){
		if (bluring != null) {
			disBluring ();
		}
	}

}
