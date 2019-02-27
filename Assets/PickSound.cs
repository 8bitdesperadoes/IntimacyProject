using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickSound : MonoBehaviour {
	AudioSource audio;

	public AudioClip[] pickSounds;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		ChangeAudioClip ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
	{
		audio.Stop ();
		audio.Play ();
		ChangeAudioClip ();

	}

	void ChangeAudioClip()
	{
		int n = Random.Range (0, pickSounds.Length-1);
		audio.clip = pickSounds [n];
	}
}
