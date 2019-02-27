using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public int playerCollisions;

    public enum GameState
    {
        active,
        win,
        lose
    };

    public GameState gameState;

	// Use this for initialization
	void Start () {
        playerCollisions = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (playerCollisions == 2)
        {
            ChangeGameState(GameState.win);
        }
    }

    void ChangeGameState(GameState state)
    {
        gameState = state;
    }
}
