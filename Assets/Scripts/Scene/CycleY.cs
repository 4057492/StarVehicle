using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleY : MonoBehaviour {

	public float up;
	public float down;

	public bool ifDown = true;


	// Update is called once per frame
	void Update () {
		if (ifDown) {
			if (transform.position.y <= down)
				transform.position = new Vector3 (transform.position.x, up, transform.position.z);
		} else {
			if (transform.position.y >= up)
				transform.position = new Vector3 (transform.position.x, down, transform.position.z);
		}
	}
}
