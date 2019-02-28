using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]

public class Goal : MonoBehaviour {

    GameController gameController;

	// Use this for initialization
	void Start () {
        gameController = GameObject.FindObjectOfType<GameController>();
        BoxCollider2D box = GetComponent<BoxCollider2D>();
        box.isTrigger = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == gameController.players[0])
        {
            gameController.player1Collision = true;
        }
        if (other.gameObject == gameController.players[1])
        {
            gameController.player2Collision = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerMovement>())
        {
            gameController.player1Collision = false;
        }
        if (other.gameObject == gameController.players[1])
        {
            gameController.player2Collision = false;
        }
    }
}
