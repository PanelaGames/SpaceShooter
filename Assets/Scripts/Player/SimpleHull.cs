using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleHull : MonoBehaviour
{
	public float hitPoints = 200f;

	void LateUpdate ()
	{
		if (hitPoints <= 0f) {
			Destroy (gameObject);
		}
	}

	public void ApplyDamage (float amount)
	{
		hitPoints -= amount;
	}

	public void ApplyHealing (float amount)
	{
		hitPoints += amount;
	}
}
