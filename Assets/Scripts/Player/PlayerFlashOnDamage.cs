using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlashOnDamage : MonoBehaviour
{
    private Color color = Color.white;
    private SpriteRenderer spriteRenderer;
    public void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void ApplyDamage(float amount)
    {
        color.r += 0.7f;
        color.g += 0.7f;
        color.b += 0.7f;
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
