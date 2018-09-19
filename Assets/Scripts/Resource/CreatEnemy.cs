using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatEnemy : MonoBehaviour {

	// Use this for initializationa
	void Start () {
		CreatSingleEnemy ("Enemy00", 0, 0, 0.2f);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public static void AddMove(GameObject g,int i,float para = 1f){
		MoveType move;
		switch (i) {
		case 0:
			move = g.AddComponent<MoveStraight> ();
			move.Setparament (para);
			break;
		}
	}

	/// <summary>
	/// 0.moovestraight
	/// </summary>
	/// <param name="name">Name.</param>
	/// <param name="moveType">Move type.</param>
	/// <param name="x">The x coordinate.</param>
	/// <param name="para">Para.</param>
	public void CreatSingleEnemy(string name,int moveType,float x = 0,float para = 1f){
		GameObject instance = Instantiate (Resources.Load ("Enemys/" + name, typeof(GameObject)))as GameObject;
		instance.transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		AddMove (instance, moveType, para);
	}


	public void CreatMultiEnemy(string name,int moveType,int number,float para = 1f,float x = 0,float deltaX = 0,float deltaY = 0){
		float posX = x;
		float posY = transform.position.y;
		GameObject instance;
		for (int i = 0; i < number; i++) {
			instance = Instantiate (Resources.Load ("Enemys/" + name, typeof(GameObject)))as GameObject;
			instance.transform.position = new Vector3 (posX, posY, transform.position.z);
			AddMove (instance, moveType, para);
			posX += deltaX;
			posY += deltaY;
		}
	}

}
