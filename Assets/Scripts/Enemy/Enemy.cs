using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public float hp = 1;

	public float armour = 1;

	public bool ifInvincible = false;

	public virtual void Hited(){
	
	}

	public void ChangeHp(float damage){
		hp -= damage * armour;
	}
}
