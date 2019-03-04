using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerText : MonoBehaviour {
	public float timer = 7.0f;
	public bool timerRunning = true;
	public bool showText = false;
	public bool found = false;
	public TextMesh tm;
	public float dist;

    public string situationalText;

	GameController gameController;

	PlayerMovement[] players;
	// Use this for initialization
	void Start () {
		tm = GetComponent<TextMesh>();
		players = GameObject.FindObjectsOfType<PlayerMovement>();
        situationalText = "";
		gameController = FindObjectOfType<GameController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameController.gameState != GameController.GameState.win) {
			if (timerRunning) {
				timer -= Time.deltaTime;
			}

			if (timer <= 0.0f) {
				if (!showText) {
					timerEnded1 ();
				} else {
					timerEnded2 ();
				}
			}
		} else {
			gameObject.SetActive(false);
		}
	}

	void timerEnded1()
	{
		timer = 3.0f;
		showText = true;
		dist = Vector3.Distance(players[0].transform.position, players[1].transform.position);
		dist = (1 / dist);
        if (situationalText == "")
        {
            if (dist >= 0.75)
            {
                tm.text = "Thanks for being my pardner,\n pardner.";
                if (!found) found = true;
            }
            else if (dist <= 0.3)
            {
                tm.text = "It's lonely out here,\n pardner.";
            }
            else
            {
                if (!found)
                {
                    tm.text = "Wanna be my pardner,\n pardner?";
                }
                else
                    tm.text = "Where'd ya go,\n pardner?";
            }
        }
        else
        {
            tm.text = situationalText;
        }
	}

	void timerEnded2()
	{
		timer = 7.0f;
		showText = false;
		tm.text = "";
	}
}
