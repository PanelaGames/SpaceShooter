using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashOnDamage : MonoBehaviour
{
    private Color color = Color.white;
    private SpriteRenderer spriteRenderer;
    private float hitPoints;
    public void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        hitPoints = GetComponent<EnemyState>().hitPoints;
    }
    public void ApplyDamage(float amount)
    {
        color.r += amount / hitPoints;
        color.g += amount / hitPoints;
        color.b += amount / hitPoints;
    }

    public void LateUpdate()
    {
        spriteRenderer.material.color = color;
        if (color.r >= 1f)
        {
            color.r -= 0.1f;
            color.g -= 0.1f;
            color.b -= 0.1f;
        }
        if (color.r < 1f)
        {
            color.r = 1f;
            color.g = 1f;
            color.b = 1f;
        }
    }
}
