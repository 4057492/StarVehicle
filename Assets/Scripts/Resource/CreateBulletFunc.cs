using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBulletFunc : MonoBehaviour {
	private GameObject instance;
	[Tooltip("0.bullet 1.enemy bullet 2.drop things")]
	public int creation = 0;
	private string creationString;

	void Start(){
		Change ();
	}

	private void Change(){
		switch (creation) {
		case 0:
			creationString = "Bullets/";
			break;
		case 1:
			creationString = "EnemyBullets/";
			break;
		case 2:
			creationString = "EnemyDrop/";
			break;
		}
	}

	public void InsBullet(string name){
		instance = Instantiate (Resources.Load (creationString+name, typeof(GameObject))) as GameObject;
		instance.transform.position = gameObject.transform.position;
	}

	public void TempInsBullet(string name){
		instance = Instantiate (Resources.Load (creationString+name, typeof(GameObject))) as GameObject;
		instance.transform.position = gameObject.transform.position;
		Destroy (this);
	}

	public void TempInsBullet(string name,int i){
		creation = i;
		Change ();
		instance = Instantiate (Resources.Load (creationString+name, typeof(GameObject))) as GameObject;
		instance.transform.position = gameObject.transform.position;
		Destroy (this);
	}

	public static void Create(GameObject g,string name){
		g.AddComponent<CreateBulletFunc> ().TempInsBullet (name);
	}

	public static void Create(GameObject g,string name,int creation){
		g.AddComponent<CreateBulletFunc> ().TempInsBullet (name,creation);
	}
}
