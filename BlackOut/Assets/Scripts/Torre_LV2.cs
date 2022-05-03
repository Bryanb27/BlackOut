using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre_LV2 : MonoBehaviour
{
    public Transform target; //Alvo
    public float range = 35f; //Alcance da torre 
    public string enemyTag = "Enemy"; //Tag dos inimigos
    public GameObject nearestEnemy; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f); //repetir essa chamada a cada 0.5 frames
    }

    //Pesquisar por alvos
    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag); //Armazenar os inimigos
        float shortestDistance = Mathf.Infinity; //Armazenar a menor distancia do inimigo
        nearestEnemy = null; //Armazenar o inimigo mais perto

        foreach (GameObject enemy in enemies) //Para cada inimigo 
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position); //Distancia entre a posicao da torre e o inimigo
            //Se a distancia do novo inimigo for menor que a do antigo
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy; //armazenar como o inimigo mais perto
            }
        }

        /*
         * Checar se achou um inimigo e ele esta dentro do alcance da torre
         */
        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform; //Indicar que encontramos o alvo
        }
        else
        {
            target = null; //indica que ele nao existe ou saiu do alcance
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;
    }

    /*
     * Desenhar o alcance da torre
     */
    void OnDrawGizmoselected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
