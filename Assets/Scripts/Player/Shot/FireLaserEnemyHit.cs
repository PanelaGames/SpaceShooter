using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaserEnemyHit : MonoBehaviour
{
	public float damage = 1f;

	void SetDamage (float newDamageValue)
	{
		damage = newDamageValue;
	}

	void OnTriggerEnter2D (Collider2D target)
	{
		if (target.gameObject.CompareTag ("Baddie")) {
			target.gameObject.SendMessage ("ApplyDamage", damage);
			Destroy (gameObject);
		}
	}
}
