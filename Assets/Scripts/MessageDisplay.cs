using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageDisplay : MonoBehaviour {
	private GameObject gameOverText;

	void Awake ()
	{
		gameOverText = GameObject.Find ("Canvas/Game Over Text");
	}

	void ShowGameOver ()
	{
		gameOverText.GetComponent<Text> ().text = "Game over";
	}
}
