using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaserWeapon : MonoBehaviour
{
	public GameObject shot;
	public float fireRate;
	public float damage = 1f;
	private float nextFire;

	void Update ()
	{
		if (Input.GetAxis ("Fire1") != 0.0f && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			GameObject shotInstance = Instantiate (shot, transform.position, transform.rotation) as GameObject;
			shotInstance.SendMessage ("SetDamage", damage);
		}
	}
}
