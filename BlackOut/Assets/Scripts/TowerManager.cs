using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public float towerRange, towerFrequency;
    public int towerValue;
    public GameObject bullet;
    public Transform towerRotation;
    public Collider[] enemies;
    public static int tower1Cost = 250;
    public static int tower2Cost = 300;

    private void shoot()
    {
        this.transform.LookAt(enemies[0].transform);
        Instantiate(bullet, towerRotation.transform.position, towerRotation.transform.rotation);
    }

    private void searchTarget()
    {
        enemies = null;
        int numLayer = LayerMask.GetMask("enemie");
        enemies = Physics.OverlapSphere(this.transform.position, towerRange, numLayer);

        if(enemies.Length > 0)
        {
            shoot();
        }
    }

    void Start()
    {
        InvokeRepeating("searchTarget", 0, towerFrequency);
    }
}
