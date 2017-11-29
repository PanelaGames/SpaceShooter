using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleHull : MonoBehaviour
{
    public float hitPoints = 200f;
    public GameObject playerExplosionPrefab;

    private GameObject canvas;

    void Awake()
    {
        canvas = GameObject.Find("Canvas");
    }

    void LateUpdate()
    {
        if (hitPoints <= 0f)
        {
            Instantiate(playerExplosionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
            canvas.SendMessage("ShowGameOver");
        }
    }

    public void ApplyDamage(float amount)
    {
        hitPoints -= amount;
    }

    public void ApplyHealing(float amount)
    {
        hitPoints += amount;
    }
}
