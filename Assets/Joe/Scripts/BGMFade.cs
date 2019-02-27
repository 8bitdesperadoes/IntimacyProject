using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMFade : MonoBehaviour {

	public float volume = 0.5f;
	AudioSource bgm;

	PlayerMovement[] players;
	// Use this for initialization
	void Start () {
		bgm = GetComponent<AudioSource> ();
		bgm.volume = volume;
		players = GameObject.FindObjectsOfType<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		setVolume ();
	}

	void setVolume () {
		float dist = Vector3.Distance(players[0].transform.position, players[1].transform.position);
		volume = (1 / dist / 8);
		bgm.volume = volume;
	}
}
