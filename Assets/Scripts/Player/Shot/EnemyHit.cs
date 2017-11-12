using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
	void OnTriggerEnter2D (Collider2D target)
	{
		if (target.gameObject.CompareTag ("Baddie")) {
			target.gameObject.SendMessage ("ApplyDamage", 10.0f);
			Destroy (gameObject);
		}
	}
}
