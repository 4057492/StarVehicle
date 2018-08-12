using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInput : MonoBehaviour {

//	public static bool stay = true;//0
//	public static bool up = false;//1
//	public static bool down = false;//2
//	public static bool left = false;//3
//	public static bool right = false;//4
//	public static bool upLeft = false;//5
//	public static bool upRight = false;//6
//	public static bool downLeft = false;//7
//	public static bool downRight = false;//8

	public static bool[] D = { true, false, false, false, false, false, false, false, false };
	public bool[] d = D;


	// Update is called once per frame
	void Update () {
		if (!Input.GetButton ("Horizontal") && !Input.GetButton ("Vertical")) {
			Set (0);
		}
		else if (!Input.GetButton ("Horizontal") && Input.GetButton ("Vertical")) {
			if (Input.GetAxis ("Vertical") > 0)
				Set (1);
			else
				Set (2);
		}
		else if (Input.GetButton ("Horizontal") && !Input.GetButton ("Vertical")) {
			if (Input.GetAxis ("Horizontal") > 0)
				Set (4);
			else
				Set (3);
		}
		else if (Input.GetButton ("Horizontal") && Input.GetButton ("Vertical")) {
			if (Input.GetAxis ("Horizontal") > 0 && Input.GetAxis ("Vertical") > 0)
				Set (6);
			else if (Input.GetAxis ("Horizontal") < 0 && Input.GetAxis ("Vertical") > 0)
				Set (5);
			else if (Input.GetAxis ("Horizontal") > 0 && Input.GetAxis ("Vertical") < 0)
				Set (8);
			else if (Input.GetAxis ("Horizontal") < 0 && Input.GetAxis ("Vertical") < 0)
				Set (7);
		}
		d = D;

	}

	void Set(int i){
		for (int n = 0; n < D.Length; n++) {
			D [n] = false;
		}
		D [i] = true;
	}
}
