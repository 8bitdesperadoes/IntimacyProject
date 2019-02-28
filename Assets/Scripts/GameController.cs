using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public int playerCollisions;

    public GameObject[] players;

    public bool player1Collision;
    public bool player2Collision;

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
        if (player1Collision && player2Collision)
        {
            ChangeGameState(GameState.win);
        }


    }

    void ChangeGameState(GameState state)
    {
        gameState = state;

        switch (gameState)
        {
            case GameState.win:
                foreach (GameObject player in players)
                {
                    player.GetComponent<Rigidbody2D>().simulated = false;
                }
                break;
        }
    }
}
