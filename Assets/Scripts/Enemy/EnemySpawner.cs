using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	public GameObject simpleUfo;

	private int enemiesSpawn = 0;

	void FixedUpdate ()
	{
		if (enemiesSpawn == 0 && Time.time >= 2f) {
			Instantiate (simpleUfo, new Vector2 (14f, 3.5f), Quaternion.identity);
			Instantiate (simpleUfo, new Vector2 (15.25f, 3.5f), Quaternion.identity);
			Instantiate (simpleUfo, new Vector2 (16.5f, 3.5f), Quaternion.identity);
			Instantiate (simpleUfo, new Vector2 (17.75f, 3.5f), Quaternion.identity);
			Instantiate (simpleUfo, new Vector2 (19f, 3.5f), Quaternion.identity);
			enemiesSpawn += 5;
		}
	}
}
