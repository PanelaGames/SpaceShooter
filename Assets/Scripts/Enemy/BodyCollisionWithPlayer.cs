using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCollisionWithPlayer : MonoBehaviour
{
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.CompareTag ("Player")) {
			other.gameObject.SendMessage ("ApplyDamage", 10f);
		}
	}
}
