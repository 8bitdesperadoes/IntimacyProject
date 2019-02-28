using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayers : MonoBehaviour {
    public GameObject[] players;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = new Vector3 (0,0,0);
        foreach (GameObject player in players)
        {
            pos += player.transform.position;
        }
        pos = pos / players.Length;
        transform.position = pos;
	}
}
