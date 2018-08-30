using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SoundEffectFunction : MonoBehaviour {

	private UnityEngine.Object sound;
	private AudioSource au;
	private GameObject temp;

	// Use this for initialization
	void Start () {
		StartCoroutine (End ());
	}

	public void AddAudioSource(string name,float volume){
		sound = Resources.Load ("Sound Effects/"+name);
		temp = Instantiate (Resources.Load ("Sound Effects/SoundTemp"))as GameObject;
		au = temp.GetComponent<AudioSource> ();
		au.clip = (AudioClip)sound;
		au.volume = volume;
	}

	IEnumerator End(){
		while (au.clip == null)
			yield return null;
		yield return new WaitForSecondsRealtime (au.clip.length);
		Destroy (this);
		yield return null;
	}

	public static void Play(GameObject g,string name,float volume = 1f){
		g.AddComponent<SoundEffectFunction> ().AddAudioSource (name, volume);
	}

	public static void Play(GameObject g,string[] names,float volume = 1f){
		g.AddComponent<SoundEffectFunction> ().AddAudioSource (names [(int)(names.Length * UnityEngine.Random.value)], volume);
	}

	public static void Play(GameObject g,__arglist){
		ArgIterator args = new ArgIterator (__arglist);
		List<String> sounds = new List<String> ();
		while (args.GetRemainingCount () > 0) {
			sounds.Add ((string)TypedReference.ToObject (args.GetNextArg ()));
		}
		String[] soundsName = sounds.ToArray ();
		SoundEffectFunction.Play (g, soundsName);
	}

	public static void Play(GameObject g,float volume,__arglist){
		ArgIterator args = new ArgIterator (__arglist);
		List<String> sounds = new List<String> ();
		while (args.GetRemainingCount () > 0) {
			sounds.Add ((string)TypedReference.ToObject (args.GetNextArg ()));
		}
		String[] soundsName = sounds.ToArray ();
		SoundEffectFunction.Play (g, soundsName, volume);
	}
}
