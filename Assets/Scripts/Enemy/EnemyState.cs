using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{
    public float hitPoints = 10.0f;
    public GameObject explosionPrefab;
    private AudioSource damageAudio;
    public void Awake()
    {
        damageAudio = GetComponent<AudioSource>();
    }

    public void ApplyDamage(float amount)
    {
        hitPoints -= amount;
        damageAudio.Play();
        if (hitPoints <= 0.0f)
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
