using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreadOutMovement : MonoBehaviour
{
	public float speed = 3.0f;

	void Start ()
	{
		Rigidbody2D rb = GetComponent <Rigidbody2D> ();

		Vector2 bottomLeft = Camera.main.ScreenToWorldPoint (new Vector3 (0, 0, 0));
		Vector2 topLeft = Camera.main.ScreenToWorldPoint (new Vector3 (0, Screen.height, 0));
		Vector2 destination = new Vector2 (bottomLeft.x, Random.Range (bottomLeft.y, topLeft.y));
		Vector2 direction = destination - rb.position;
		direction.Normalize ();

		rb.velocity = speed * direction;
	}
}
