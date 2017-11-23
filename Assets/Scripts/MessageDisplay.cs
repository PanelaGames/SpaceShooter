using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageDisplay : MonoBehaviour
{
	private GameObject gameOverText;

	void ShowGameOver ()
	{
		gameObject.GetComponentInChildren<ActivateOnCommand> (true).Activate ();
	}
}
