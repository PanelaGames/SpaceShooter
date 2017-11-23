using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	public GameObject simpleUfo;
	public List<GameObject> enemyList = new List<GameObject> ();

	private float nextWaveSpawnTimer = 2f;

	void Update ()
	{
		if (Time.time >= nextWaveSpawnTimer) {
			switch (Time.frameCount % 3) {
			case 0:
				CreateUfoSinCurveWave ();
				break;
			case 1:
				CreateUfoStraightSWave ();
				break;
			case 2:
				CreateRfoSpreadOutWave ();
				break;
			}
			nextWaveSpawnTimer += 2f;
		}
	}

	private void CreateUfoStraightSWave ()
	{
		for (int i = 0; i <= 4; i += 1) {
			GameObject ufo = Instantiate (
				                 simpleUfo,
				                 new Vector2 (14f + 1.25f * i, 3.5f),
				                 Quaternion.identity
			                 ) as GameObject;
			ufo.AddComponent<StraightSMovement> ();
		}
	}

	private void CreateUfoSinCurveWave ()
	{
		for (int i = 0; i <= 4; i += 1) {
			GameObject ufo = Instantiate (
				                 simpleUfo,
				                 new Vector2 (14f + 1.25f * i, 3.5f),
				                 Quaternion.identity
			                 ) as GameObject;
			ufo.AddComponent<SinCurveMovement> ();
		}
	}

	private void CreateRfoSpreadOutWave ()
	{
		Vector2 bottomLeft = Camera.main.ScreenToWorldPoint (new Vector3 (0, 0, 0));
		Vector2 topLeft = Camera.main.ScreenToWorldPoint (new Vector3 (0, Screen.height, 0));
		Vector2 startPosition = new Vector2 (bottomLeft.x, Random.Range (bottomLeft.y, topLeft.y));
		for (int i = 0; i <= 4; i += 1) {
			GameObject ufo = Instantiate (
				                 simpleUfo,
				                 new Vector2 (14f + 1.25f * i, startPosition.y),
				                 Quaternion.identity
			                 ) as GameObject;
			ufo.AddComponent<SpreadOutMovement> ();
		}
	}
}
