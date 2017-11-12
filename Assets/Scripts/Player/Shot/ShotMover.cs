using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMover : MonoBehaviour
{
	public float speed = 5.0f;

	void Start ()
	{
		GetComponent<Rigidbody2D> ().velocity = Vector2.right * speed;
	}
}
