using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    private int default_life = 3;
    public Text life;
    private int default_energy = 1000;
    public Text energy_num;
    public GameObject selectedTower;
    public Image win, gameover;
    public static UIManager ui_manager;

    void Start()
    {
        ui_manager = this;
    }

    public void selectTower(GameObject tower)
    {
        selectedTower = tower;
        Debug.Log(tower);
    }

    public void updateLife()
    {
        default_life = default_life - 1;
        life.text = default_life.ToString();
    }

    public void winEnergy(int value)
    {
        default_energy += value;
        energy_num.text = default_energy.ToString();
    }

    public void loseEnergy(int value)
    {
        default_energy -= value;
        energy_num.text = default_energy.ToString();
    }

    public void gameWin()
    {
        gameObject.SetActive(win);
    }

    public void gameOver()
    {
        gameObject.SetActive(gameover);
    }
}