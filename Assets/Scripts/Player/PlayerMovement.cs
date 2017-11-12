using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
}


public class PlayerMovement : MonoBehaviour
{
	public float speed = 50.0f;
	public Boundary boundary;

	private Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate ()
	{
		Vector2 movement = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
		rb.velocity = speed * movement;
		rb.position = new Vector2 (
			Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax),
			Mathf.Clamp (rb.position.y, boundary.yMin, boundary.yMax)
		);
	}
}
