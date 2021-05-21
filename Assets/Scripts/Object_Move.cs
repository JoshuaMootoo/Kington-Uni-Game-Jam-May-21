using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Move : MonoBehaviour
{
    Player_Controller playerController;
    Rigidbody2D rb;
    public float moveSpeed;

    private void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        rb.velocity = new Vector2(0, -moveSpeed);

        if (transform.position.y < -6) transform.position = new Vector3(transform.position.x, 6, 0);
    }
}
