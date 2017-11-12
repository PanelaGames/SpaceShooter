using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
	public GameObject shot;
	public float fireRate;
	private float nextFire;

	void Update ()
	{
		if (Input.GetAxis ("Fire1") != 0.0f && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (shot, transform.position, transform.rotation);
		}
	}
}
