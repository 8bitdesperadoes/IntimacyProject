using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SituationalText : MonoBehaviour {

    public string text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            PlayerText playerText = other.transform.GetChild(1).GetComponent<PlayerText>();
            playerText.situationalText = text;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            PlayerText playerText = other.transform.GetChild(1).GetComponent<PlayerText>();
            playerText.situationalText = "";
        }
    }
}
