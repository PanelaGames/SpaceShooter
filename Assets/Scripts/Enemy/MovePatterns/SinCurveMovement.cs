using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinCurveMovement : MonoBehaviour
{
	public float speed = 3.0f;

	private Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent <Rigidbody2D> ();
		rb.velocity = Vector2.left * speed;
	}

	void FixedUpdate ()
	{
		rb.position = new Vector2 (rb.position.x, Mathf.Sin (rb.position.x) * 4);
	}
}
