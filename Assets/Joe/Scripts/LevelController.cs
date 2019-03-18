using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
	}

	public void LoadNextLevel(string levelName)
	{
		SceneManager.LoadScene (levelName);
		Debug.Log ("clicked");
	}


}