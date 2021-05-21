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

    public Sprite boost;
    public GameObject[] fruits;

    GameObject warpObj;

    public Sprite[] currentSprites;
    public Sprite[] level1Sprites;
    public Sprite[] level2Sprites;
    public Sprite[] level3Sprites;

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
            for (int i = 0; i < level1Sprites.Length; i++)
            {
                currentSprites[i] = level1Sprites[i];
            }
        }
        if (level == 2)
        {
            for (int i = 0; i < level2Sprites.Length; i++)
            {
                currentSprites[i] = level2Sprites[i];
            }
        }
        if (level == 3)
        {
            for (int i = 0; i < level3Sprites.Length; i++)
            {
                currentSprites[i] = level3Sprites[i];
            }
        }


        backgroundObj.transform.GetComponent<SpriteRenderer>().sprite = currentSprites[0];
        backgroundObj.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = currentSprites[0];
        backgroundObj.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = currentSprites[0];

        if (playerController.fuel > 50 && playerController.speed == 88) canTimeTravel = true;
        if (Input.GetButtonDown("Jump") && canTimeTravel && level != 3) LevelChange();
    }

    void LevelChange()
    {
        warpObj.SetActive(true);
        float countdownTimer = 5;
        countdownTimer -= 0.1f;
        if (countdownTimer <= 0)
        {
            level += 1;
            warpObj.SetActive(false);
        }
    }
}
