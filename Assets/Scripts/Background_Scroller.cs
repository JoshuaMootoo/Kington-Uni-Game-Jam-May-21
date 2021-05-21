using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Scroller : MonoBehaviour
{
    public BoxCollider2D BGCollider;
    public Rigidbody2D rb;

    private float height;
    public float scrollSpeed = -2f;

    private void Start()
    {
        BGCollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        height = BGCollider.size.y;
        BGCollider.enabled = false;

        rb.velocity = new Vector2(0, scrollSpeed);
    }

    private void Update()
    {
        if (transform.position.y < -height)
        {
            Vector2 resetPosition = new Vector2(0, height * 2f);
            transform.position = (Vector2)transform.position + resetPosition;
        }
    }
}
