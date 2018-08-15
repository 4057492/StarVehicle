using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBulletFunc : MonoBehaviour {
	private GameObject instance;

	public void InsBullet(string name){
		instance = Instantiate (Resources.Load ("Bullets/"+name, typeof(GameObject))) as GameObject;
		instance.transform.position = gameObject.transform.position;
	}

	public void TempInsBullet(string name){
		instance = Instantiate (Resources.Load ("Bullets/"+name, typeof(GameObject))) as GameObject;
		instance.transform.position = gameObject.transform.position;
		Destroy (this);
	}

	public static void Create(GameObject g,string name){
		g.AddComponent<CreateBulletFunc> ().TempInsBullet (name);


	}
}
