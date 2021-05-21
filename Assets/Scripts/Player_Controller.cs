using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    Rigidbody2D rb;

    public float fuel, maxFuel, speed;
    public int moveSpeed;

    public Vector2 boundaries;


    private void Start()
    {       
        rb = transform.GetComponent<Rigidbody2D>();
        fuel = maxFuel;
    }

    private void Update()
    {
        PlayerMovement();

        fuel -= 0.001f;

        speed += 0.01f;
        if (speed >= 88) speed = 88;
    }

    
    void PlayerMovement()
    {
        Vector2 moveButtons = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;

        if (fuel != 0 && fuel > 0) rb.velocity = moveButtons;


        if (transform.position.x > boundaries.x) transform.position = new Vector3(boundaries.x, transform.position.y, 0);
        if (transform.position.x < -boundaries.x) transform.position = new Vector3(-boundaries.x, transform.position.y, 0);
        if (transform.position.y > boundaries.y) transform.position = new Vector3(transform.position.x, boundaries.y, 0);
        if (transform.position.y < -boundaries.y) transform.position = new Vector3(transform.position.x, -boundaries.y, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Fruit")
        {
            fuel += collision.GetComponent<Fuel_Object>().fuel;
            Destroy(collision.gameObject);
        }

        if (collision.tag == "Obstacle")
        {
            speed -= 5;
            Destroy(collision.gameObject);
        }

        if (collision.tag == "Boost")
        {
            speed += 5;
            Destroy(collision.gameObject);
        }
    }
}
