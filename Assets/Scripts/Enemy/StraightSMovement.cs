using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightSMovement : MonoBehaviour
{
	public float speed = 5.0f;

	private Rigidbody2D rb;
	private Vector2 direction = Vector2.left;
	private int phase = 0;

	public void Start ()
	{
		rb = GetComponent <Rigidbody2D> ();
	}

	public void FixedUpdate ()
	{
		Vector2 currentPostition = transform.position;
		rb.velocity = direction * speed;
		if (phase == 0 && currentPostition.x <= 1f) {
			direction = Vector2.down;
			phase += 1;
		}
		if (phase == 1 && currentPostition.y <= -3.5f) {
			direction = Vector2.left;
			phase += 1;
		}
	}
}
