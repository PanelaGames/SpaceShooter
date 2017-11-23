using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOnClick : MonoBehaviour
{
	public void OpenMainMenu ()
	{
		SceneManager.LoadScene ("Main Menu");
	}
}
