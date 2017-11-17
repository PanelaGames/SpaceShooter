using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightSMovement : MonoBehaviour
{
	public float speed = 5.0f;

	private Rigidbody2D rb;
	private int phase = 0;

	public void Start ()
	{
		rb = GetComponent <Rigidbody2D> ();
		rb.velocity = Vector2.left * speed;
	}

	public void FixedUpdate ()
	{
		Vector2 currentPostition = transform.position;
		if (phase == 0 && currentPostition.x <= 1f) {
			rb.velocity = Vector2.down * speed;
			phase += 1;
		}
		if (phase == 1 && currentPostition.y <= -3.5f) {
			rb.velocity = Vector2.left * speed;
			phase += 1;
		}
	}
}
