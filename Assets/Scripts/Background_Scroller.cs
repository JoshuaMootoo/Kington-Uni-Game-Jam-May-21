using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Scroller : MonoBehaviour
{
    Player_Controller playerController;
    public BoxCollider2D BGCollider;
    public Rigidbody2D rb;
    public float backgroundScale;

    private float height;
    public float scrollSpeed = -2f;

    private void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();
        BGCollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        backgroundScale = transform.localScale.y;

        height = BGCollider.size.y * backgroundScale;
        BGCollider.enabled = false;

        
    }

    private void Update()
    {
        scrollSpeed = -playerController.speed / 4;
        rb.velocity = new Vector2(0, scrollSpeed);
        
        if (transform.position.y < -height)
        {
            Vector2 resetPosition = new Vector2(0, height * 2f);
            transform.position = (Vector2)transform.position + resetPosition;
        }
    }
}
