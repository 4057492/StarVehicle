using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectFunction : MonoBehaviour {

	private Object sound;
	private AudioSource au;

	// Use this for initialization
	void Start () {
		StartCoroutine (End ());
	}

	public void AddAudioSource(string name){
		sound = Resources.Load ("Sound Effects/"+name);
		au = gameObject.AddComponent<AudioSource> ();
		au.clip = (AudioClip)sound;
	}

	IEnumerator End(){
		while (au.clip == null)
			yield return null;
		au.Play ();
		yield return new WaitForSecondsRealtime (au.clip.length);
		Destroy (au);
		Destroy (this);
		yield return null;
	}

	public static void Play(GameObject g,string name){
		g.AddComponent<SoundEffectFunction> ().AddAudioSource (name);
	}

	public static void Play(GameObject g,string[] names){
		g.AddComponent<SoundEffectFunction>().AddAudioSource(names[(int)(names.Length*Random.value)]);
	}

	
}
