using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SimpleHull : MonoBehaviour
{
    public float hitPoints = 200f;
    public GameObject playerExplosionPrefab;

    private GameObject canvas;
    private AudioSource damageAudio;

    void Awake()
    {
        canvas = GameObject.Find("Canvas");
        damageAudio = GetComponent<AudioSource>();
    }

    void LateUpdate()
    {
        if (hitPoints <= 0f)
        {
            Instantiate(playerExplosionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
            GameObject.Find("Stage background music").GetComponent<AudioSource>().Stop();
            canvas.SendMessage("ShowGameOver");
        }
    }

    public void ApplyDamage(float amount)
    {
        damageAudio.Play();
        hitPoints -= amount;
    }

    public void ApplyHealing(float amount)
    {
        hitPoints += amount;
    }
}
