using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    Game_Controller gameController;

    Rigidbody2D rb;

    public float fuel;
    public int moveSpeed;

    private void Start()
    {
        //gameController = GameObject.FindObjectOfType<Game_Controller>().GetComponent<Game_Controller>();

        rb = transform.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float moveLR = Input.GetAxis("Horizontal") * moveSpeed;
        float moveUD = Input.GetAxis("Vertical") * moveSpeed;

        rb.velocity = new Vector2(moveLR, moveUD);
    }
}
