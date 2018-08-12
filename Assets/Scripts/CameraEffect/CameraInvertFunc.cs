using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class CameraInvertFunc : MonoBehaviour {

	public void CamInvert(){
		GetComponent<ScreenOverlay> ().enabled = true;
	}

	public void CamDisInvert(){
		GetComponent<ScreenOverlay> ().enabled = false;
	}
}
