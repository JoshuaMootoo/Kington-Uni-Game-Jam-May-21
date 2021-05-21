using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Controller : MonoBehaviour
{
    Player_Controller playerController;
    Background_Scroller backgroundScroller;

    public int level;
    public int score;
    public int totalScore;

    GameObject warpObj;

    public Sprite currentSprites;
    public Sprite level1Sprites;
    public Sprite level2Sprites;
    public Sprite level3Sprites;

    public GameObject backgroundObj;

    public bool canTimeTravel;


    private void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").transform.GetComponent<Player_Controller>();
        backgroundScroller = GameObject.FindGameObjectWithTag("Background").transform.GetComponent<Background_Scroller>();
    }

    private void Update()
    {
        if (level == 1)
        {
                currentSprites = level1Sprites;
        }
        if (level == 2)
        {
                currentSprites = level2Sprites;
        }
        if (level == 3)
        {
                currentSprites = level3Sprites;
        }


        backgroundObj.transform.GetComponent<SpriteRenderer>().sprite = currentSprites;
        backgroundObj.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = currentSprites;
        backgroundObj.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = currentSprites;

        if (playerController.fuel > 50 && playerController.speed == 88) canTimeTravel = true;
        if (Input.GetKeyDown(KeyCode.Space) && canTimeTravel) LevelChange();
    }

    void LevelChange()
    {
        warpObj.SetActive(true);
        float countdownTimer = 5;
        countdownTimer -= 0.1f;
        if (countdownTimer <= 0)
        {
            level += 1;
            playerController.fuel -= 50;
            warpObj.SetActive(false);
        }
    }
}
