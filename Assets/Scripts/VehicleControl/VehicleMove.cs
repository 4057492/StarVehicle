using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMove : Statem{

	private MoveAnimationControl animaCon;
	private Rigidbody rig;

	public float maxSpeed = 2f;
	public float force = 100f;
	public float stopForce = 2f;



	void Start () {
		animaCon = GetComponent<MoveAnimationControl> ();
		rig = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Anima ();
		Move ();
	}

	void Move(){
		if (Mathf.Abs (rig.velocity.x) <= maxSpeed || rig.velocity.x * Input.GetAxis ("Horizontal") <= 0) {
			rig.AddForce (Input.GetAxis ("Horizontal") * force, 0, 0);
		}
		if (Mathf.Abs (rig.velocity.y) <= maxSpeed || rig.velocity.y * Input.GetAxis ("Vertical") <= 0) {
			rig.AddForce (0, Input.GetAxis ("Vertical") * force, 0);
		}
		if (MoveInput.D [0]) {
			rig.AddForce (-rig.velocity.x * stopForce, -rig.velocity.y * stopForce, 0);
		}
	}

	void Anima(){
		if (MoveInput.D[0]) {
			animaCon.Stay ();
		} else if (MoveInput.D[1]) {
			animaCon.Up ();
		}else if (MoveInput.D[2]) {
			animaCon.Down ();
		}else if (MoveInput.D[3]) {
			animaCon.Left ();
		}else if (MoveInput.D[4]) {
			animaCon.Right ();
		}else if (MoveInput.D[5]) {
			animaCon.UpLeft ();
		}else if (MoveInput.D[6]) {
			animaCon.UpRight ();
		}else if (MoveInput.D[7]) {
			animaCon.DownLeft ();	
		}else if (MoveInput.D[8]) {
			animaCon.DownRight ();
		}
	}


//	class Stay:StateM{
//		public override void Enter (Statem statem)
//		{
//			
//		}
//		public override void Execute (Statem statem)
//		{
//			
//		}
//		public override void Exit (Statem statem)
//		{
//			
//		}
//	}
//
//	class Up:StateM{
//		public override void Enter (Statem statem)
//		{
//
//		}
//		public override void Execute (Statem statem)
//		{
//
//		}
//		public override void Exit (Statem statem)
//		{
//
//		}
//	}
//
//	class Down:StateM{
//		public override void Enter (Statem statem)
//		{
//
//		}
//		public override void Execute (Statem statem)
//		{
//
//		}
//		public override void Exit (Statem statem)
//		{
//
//		}
//	}
//
//	class Left:StateM{
//		public override void Enter (Statem statem)
//		{
//
//		}
//		public override void Execute (Statem statem)
//		{
//
//		}
//		public override void Exit (Statem statem)
//		{
//
//		}
//	}
//
//	class Right:StateM{
//		public override void Enter (Statem statem)
//		{
//
//		}
//		public override void Execute (Statem statem)
//		{
//
//		}
//		public override void Exit (Statem statem)
//		{
//
//		}
//	}
//
//	class UpLeft:StateM{
//		public override void Enter (Statem statem)
//		{
//
//		}
//		public override void Execute (Statem statem)
//		{
//
//		}
//		public override void Exit (Statem statem)
//		{
//
//		}
//	}
//
//	class UpRight:StateM{
//		public override void Enter (Statem statem)
//		{
//
//		}
//		public override void Execute (Statem statem)
//		{
//
//		}
//		public override void Exit (Statem statem)
//		{
//
//		}
//	}
//
//	class DownLeft:StateM{
//		public override void Enter (Statem statem)
//		{
//
//		}
//		public override void Execute (Statem statem)
//		{
//
//		}
//		public override void Exit (Statem statem)
//		{
//
//		}
//	}
//
//	class DownRight:StateM{
//		public override void Enter (Statem statem)
//		{
//
//		}
//		public override void Execute (Statem statem)
//		{
//
//		}
//		public override void Exit (Statem statem)
//		{
//
//		}
//	}
}
