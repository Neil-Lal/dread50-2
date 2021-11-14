using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MazeCounter : MonoBehaviour {

	public static int level = 0;
	private static Text txt;

	// Use this for initialization
	void Start () {

		// Increment on call
		level++;

		// Change Level text
		txt = gameObject.GetComponent<Text>();
		txt.text = string.Concat("Level: ", level);
	}

	public static void Reset() {

		// Reset the level counter
		level = 0;
	}
}
