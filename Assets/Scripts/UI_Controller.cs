using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    public Game_Controller gameController;
    public Player_Controller playerController;

    [Header("Health Bar")]
    [SerializeField] Slider fuelSlider;
    [SerializeField] Text speedText;


    private void Start()
    {
        fuelSlider.minValue = 0;
        fuelSlider.maxValue = playerController.maxFuel;
    }

    private void Update()
    {
        fuelSlider.value = playerController.fuel;
        speedText.text = playerController.speed.ToString();
    }
}
