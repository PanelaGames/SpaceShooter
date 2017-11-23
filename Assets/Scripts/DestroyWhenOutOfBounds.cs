using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenOutOfBounds : MonoBehaviour
{
	public void Awake ()
	{
		Camera mainCamera = Camera.main;
		Vector2 topLeft = mainCamera.ScreenToWorldPoint (new Vector2 (0, 0));
		Vector2 bottomRight = mainCamera.ScreenToWorldPoint (
			                      new Vector2 (
				                      mainCamera.pixelWidth,
				                      mainCamera.pixelHeight
			                      )
		                      );
		Debug.Log (topLeft);
		Debug.Log (bottomRight);
		transform.localScale = (bottomRight - topLeft) / 2;
	}

	public void OnTriggerExit2D (Collider2D other)
	{
		Destroy (other.gameObject);
	}
}
