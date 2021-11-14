using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnOnHeight : MonoBehaviour {

	private GameObject audioObj;

	// Use this for initialization
	void Start () {

		// Hold audio object to destroy
		audioObj = GameObject.FindGameObjectsWithTag("Audio")[0];
	}
	
	// Update is called once per frame
	void Update () {
		
		if (transform.position.y < -5) {
			// Player died, Game over steps
			Destroy(audioObj);
			MazeCounter.Reset();
			SceneManager.LoadScene("GameOver");
		}
	}
}
