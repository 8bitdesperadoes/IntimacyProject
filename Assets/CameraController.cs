using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Vector3 winPosition;
    public float winSize;

    GameController gameController;

	// Use this for initialization
	void Start () {
        gameController = FindObjectOfType<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (gameController.gameState == GameController.GameState.win)
        {
            transform.position = Vector3.Lerp(transform.position, winPosition,.005f);
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, winSize,.005f);
        }
	}
}
