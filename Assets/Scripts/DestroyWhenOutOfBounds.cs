using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenOutOfBounds : MonoBehaviour
{
    public int padding = 30;

    public void Awake()
    {
        Camera mainCamera = Camera.main;
        Vector2 topLeft = mainCamera.ScreenToWorldPoint(new Vector2(-padding, -padding));
        Vector2 bottomRight = mainCamera.ScreenToWorldPoint(
                                  new Vector2(
                                      mainCamera.pixelWidth + padding,
                                      mainCamera.pixelHeight + padding
                                  )
                              );
        Vector2 size = GetComponent<Renderer>().bounds.size;
        Vector2 rescale = transform.localScale;
        Vector2 diff = bottomRight - topLeft;
        rescale.x = diff.x * rescale.x / size.x;
        rescale.y = diff.y * rescale.y / size.y;
        transform.localScale = rescale;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
