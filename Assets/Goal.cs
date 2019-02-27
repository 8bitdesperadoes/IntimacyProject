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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerMovement>())
        {
            gameController.playerCollisions++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerMovement>())
        {
            gameController.playerCollisions--;
        }
    }
}
