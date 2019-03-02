using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Vector3 winPosition;
    public float winSize;

	Background background;
    GameController gameController;

	// Use this for initialization
	void Start () {
        gameController = FindObjectOfType<GameController>();
		background = FindObjectOfType<Background> ();
	}
	
	// Update is called once per frame
	void Update () {
        if (gameController.gameState == GameController.GameState.win)
        {
			if (Vector3.Distance (transform.position, winPosition) > .1f) {
				background.transform.position = Vector2.Lerp (background.transform.position, winPosition/1.5f, .005f);
				transform.position = Vector3.Lerp (transform.position, winPosition, .005f);
				Camera.main.orthographicSize = Mathf.Lerp (Camera.main.orthographicSize, winSize, .005f);
			}
        }
	}
}
