using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave_LV1 : MonoBehaviour
{
    public int health = 100; //Pontos de vida
    GameObject Torre;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CheckTowerClose", 0f, 1f);        
    }

    // Update is called once per frame
    void Update()
    {
        if (Torre != null && Torre.GetComponent<Torre_LV1>().target == this)
        {
            InvokeRepeating("LowerHealth", 0f, 1f);
        }
    }

    void CheckTowerClose()
    {
        Torre = GameObject.FindGameObjectWithTag("Torre");
    }

    void LowerHealth()
    {
        
        if (health >= 0)
        {
            health -= 10;
        }

        if (health < 0)
        {
            Destroy(gameObject);
        }
    }
}
