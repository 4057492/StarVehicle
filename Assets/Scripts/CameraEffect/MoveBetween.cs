using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBetween : MonoBehaviour {
	public float range = 1f;
	public float speed = 0.1f;
	public bool ifY = true;

	private float x;
	private float y;

	private int i = 1;

	void Start(){
		x = transform.localPosition.x;
		y = transform.localPosition.y;
	}

	void Update () {
		if (ifY) {
			transform.Translate (0, speed * i, 0);
			if (transform.localPosition.y > y + range || transform.localPosition.y < y - range) {
				i *= -1;
			}
		}
		else{
			transform.Translate (speed * i, 0, 0);
			if (transform.localPosition.x > x + range || transform.localPosition.x < x - range) {
				i *= -1;
			}
			
		}
	}
}
