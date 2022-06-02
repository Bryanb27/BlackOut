using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{

    public Color hoverColor;
    private Renderer rend;
    private Color startColor;

    private GameObject tower;
    private GameObject tiles;
    public bool buildable = true;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseEnter ()
    {
        if(buildable == true && tower == null)
        {
            rend.material.color = hoverColor;
        }
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    void OnMouseDown()
    {
        createTower();
    }

    private bool towerBuilding()
    {
        bool build = false;
        if(buildable == true && tower == null)
        {
            build = true;
        }

        return build;
    }

    private bool energyControl()
    {
        bool haveEnergy = false;
        if(((LevelController.level.energy - TowerManager.tower2Cost) >= 0) 
            || ((LevelController.level.energy - TowerManager.tower1Cost) >= 0))
        {
            haveEnergy = true;
        }

        return haveEnergy;
    }

    private void createTower()
    {
        if(towerBuilding() && energyControl())
        {
            GameObject towerToBuild = UIManager.ui_manager.selectedTower;
            tower = (GameObject)Instantiate(towerToBuild, transform.position, transform.rotation);
            if(tower.tag == "Torre1")
            {
                LevelController.level.energyCostTower(TowerManager.tower1Cost);
            } else
            {
                LevelController.level.energyCostTower(TowerManager.tower2Cost);
            }
        } else
        {
            Debug.Log("Erro: 1- Voce esta sem energia\n2- Nao pode construir aqui\n3- A wave ja iniciou\n");
        }
    }
}
