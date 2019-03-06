using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerText : MonoBehaviour {
	public float timer = 7.0f;
	private bool timerRunning = true;
	private bool showText = false;
	private bool found = false;
	public TextMesh tm;
	public float dist;
	public float closeRange;
	public float farRange;

	public string situationalText;

	GameController gameController;

	PlayerMovement[] players;

	[SerializeField]
	private string[] textList1;
	private string[] textList2;
	private string[] textList3;
	private string[] textList4;

	void Awake () {
		textList1 = new string[]
		{
			"I'm glad you're my pardner,\n pardner.",
			"We make a good team,\n pardner.",
			"We work great together,\n pardner.",
			"Thanks for being my pardner,\n pardner.",
			"Couldn't do it without ya,\n pardner.",
		};
		textList2 = new string[]
		{
			"Can't do this without ya,\n pardner.",
			"We're better together,\n pardner.",
			"I need mah pardner,\n pardner.",
			"Where'd ya go,\n pardner?",
			"Where'd ya runnin' off to,\n pardner?",
		};
		textList3 = new string[]
		{
			"Wanna be my pardner,\n pardner?",
			"Care to team up,\n pardner?",
		};
		textList4 = new string[]
		{
			"It's sure lonely out here,\n pardner.",
			"Wish I had a pardner,\n pardner.",
			"I could use a pardner,\n pardner.",
		};
	}
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
			if (dist >= closeRange)
            {
				tm.text = textList1[Random.Range(0, textList1.Length)];
                if (!found) found = true;
            }
			else if (dist <= farRange)
            {
				tm.text = textList4[Random.Range(0, textList4.Length)];
            }
            else
            {
                if (!found)
                {
					tm.text = textList3[Random.Range(0, textList3.Length)];
                }
                else
					tm.text = textList2[Random.Range(0, textList2.Length)];
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