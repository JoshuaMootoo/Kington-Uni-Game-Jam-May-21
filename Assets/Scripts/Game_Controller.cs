using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Controller : MonoBehaviour
{
    public int level;
    public int score;
    public int totalScore;

    public Sprite timeTravelSprite;

    public Sprite floorSprite;
    public Sprite[] floorSprites;

    public Sprite obsticalSPrite;
    public Sprite[] obsticalSPrites;

    public bool canTimeTravel;

    void PlayerInputs()
    {
        //if (Input.GetButtonDown("Jump") && canTimeTravel)
        //{
        //    NextLevel();
        //}
    }
}
