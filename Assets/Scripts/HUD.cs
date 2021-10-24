using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Image LifeImg, EnergyImg;
    public int points = 0;
    public Text PointsTxt;
    public Player player;
    void Start()
    {
        PointsTxt.text = "0";
    }
    void Update()
    {
        UpdateLife();
        UpdateEnergy();
        UpdatePoints();
    }
    public void UpdateLife()
    {
        LifeImg.fillAmount = player.life; 
    }
    public void UpdateEnergy()
    {
        EnergyImg.fillAmount = player.energy; 
    }

    public void UpdatePoints()
    {
        PointsTxt.text = points.ToString();
    }
}
