using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}


public class PlayerMovement : MonoBehaviour
{
    public float speed = 50.0f;

    private Boundary boundary;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Camera mainCamera = Camera.main;
        Vector2 topLeft = mainCamera.ScreenToWorldPoint(new Vector2(0, 0));
        Vector2 bottomRight = mainCamera.ScreenToWorldPoint(
            new Vector2(
                mainCamera.pixelWidth,
                mainCamera.pixelHeight
            )
        );
        boundary = new Boundary();
        boundary.xMin = topLeft.x;
        boundary.xMax = bottomRight.x;
        boundary.yMin = topLeft.y;
        boundary.yMax = bottomRight.y;
    }

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.velocity = speed * movement;
        rb.position = new Vector2(
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax)
        );
    }
}
