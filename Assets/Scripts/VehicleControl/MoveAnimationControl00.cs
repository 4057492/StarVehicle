using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimationControl00 : MoveAnimationControl {

	public Animator animator;
	private Vector3 scale1 = Vector3.zero;
	private Vector3 scale2 = Vector3.zero;
	private int state = 0;

	void OnEnable(){
//		MoveAnimationEvent.staying += Stay;
//		MoveAnimationEvent.uping += Up;
//		MoveAnimationEvent.downing += Down;
//		MoveAnimationEvent.lefting += Left;
//		MoveAnimationEvent.righting += Right;
//		MoveAnimationEvent.upLefting += UpLeft;
//		MoveAnimationEvent.upRighting += UpRight;
//		MoveAnimationEvent.downLefting += DownLeft;
//		MoveAnimationEvent.downRighting += DownRight;
	}

	void OnDisable(){
//		MoveAnimationEvent.staying -= Stay;
//		MoveAnimationEvent.uping -= Up;
//		MoveAnimationEvent.downing -= Down;
//		MoveAnimationEvent.lefting -= Left;
//		MoveAnimationEvent.righting -= Right;
//		MoveAnimationEvent.upLefting -= UpLeft;
//		MoveAnimationEvent.upRighting -= UpRight;
//		MoveAnimationEvent.downLefting -= DownLeft;
//		MoveAnimationEvent.downRighting -= DownRight;
	}

	void Start(){
		animator = GetComponent<Animator> ();
		scale1 = transform.localScale;
		scale2 = new Vector3 (-transform.localScale.x, transform.localScale.y, transform.localScale.z);
	}

	public override void Stay(){
		if (state != 0) {
			transform.localScale = scale1;
			animator.Play ("stay");
			state = 0;
		}
	}
		
	public override void Up(){
		if (state != 1) {
			transform.localScale = scale1;
			animator.Play ("up");
			state = 1;
		}
	}

	public override void Down(){
		if (state != 2) {
			transform.localScale = scale1;
			animator.Play ("down");
			state = 2;
		}
	}

	public override void Left(){
		if (state != 3) {
			transform.localScale = scale1;
			animator.Play ("left");
			state = 3;
		}
	}

	public override void Right(){
		if (state != 4) {
			transform.localScale = scale2;
			animator.Play ("left");
			state = 4;
		}
	}

	public override void UpLeft(){
		if (state != 5) {
		transform.localScale = scale1;
			animator.Play ("upLeft");
			state = 5;
		}
	}

	public override void UpRight(){
		if (state != 6) {
			transform.localScale = scale2;
			animator.Play ("upLeft");
			state = 6;
		}
	}

	public override void DownLeft(){
		if (state != 7) {
			transform.localScale = scale1;
			animator.Play ("downLeft");
			state = 7;
		}
	}

	public override void DownRight(){
		if (state != 8) {
			transform.localScale = scale2;
			animator.Play ("downLeft");
			state = 8;
		}
	}

}
