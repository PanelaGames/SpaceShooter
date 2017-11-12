using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{
	public float hitPoints = 10.0f;

	public void ApplyDamage (float amount)
	{
		hitPoints -= amount;
		if (hitPoints <= 0.0f) {
			Destroy (gameObject);
		}
	}
}
