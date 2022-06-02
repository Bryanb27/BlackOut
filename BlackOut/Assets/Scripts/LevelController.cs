using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public int wave;
    public int life;
    public int energy;
    public static LevelController level;

    public void energyByEnemy(int value)
    {
        energy += value;
        UIManager.ui_manager.winEnergy(value);
    }

    public void energyCostTower(int value)
    {
        energy -= value;
        UIManager.ui_manager.loseEnergy(value);
    }

    public void updateLife()
    {
        life = life - 1;
        UIManager.ui_manager.updateLife();
        
        if(life == 0)
        {
            gameOver();
        }
    }

    public void gameOver()
    {
        UIManager.ui_manager.gameOver();
    }

    void Start()
    {
        level = this;
    }
}
