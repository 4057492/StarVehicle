using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraight : MoveType {

	public float speed = -0.1f;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0, speed, 0));
	}

	public override void Setparament (float parament)
	{
		speed = parament * speed;
	}


}
