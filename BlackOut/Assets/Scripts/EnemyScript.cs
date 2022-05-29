using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Pathfinding;

public class EnemyScript : MonoBehaviour
{
	public static Vector3[] vector;
    public Vector3 origem, destino;
    float inicio, comprimento;
    int i = 1;
    int tamanho = 0;
    // Start is called before the first frame update
    void Start()
    {
        Walker walker = new Walker();
        //# = torre
        //. = obstaculo (em vermelho no mapa no jogo)
        //A = inicio
        //B = fim
        List<string> map = new List<string>
		{
		    "    #.   ",
            "A   # .  ",
            ".##      ",
            "..  B    ",
            "    #    ",
            "      .  ",
            "    # .  "
		};
		List<int[]> path = walker.AStar(map);
        tamanho = path.Count;
		vector = new Vector3[path.Count];

		for(int i=0;i < path.Count; i++)
			vector[i] = new Vector3(path[i][0],-1.44f,path[i][1]);

        origem = vector[0];
        destino = vector[1];
        inicio = Time.time;
        comprimento = Vector3.Distance(origem, destino);
    }

    // Update is called once per frame
    void Update()
    {
        float tempo = Time.time - inicio;
        float velocidade = (tempo/comprimento)*3;
        this.transform.position = Vector3.Lerp(origem, destino, velocidade); //caminha a cada update

        if(Vector3.Distance(this.transform.position, destino) <= 0) {
            i++;
            if(i < tamanho) {
                origem = destino;
                destino = vector[i];
                comprimento = Vector3.Distance(origem, destino);
                inicio = Time.time;
                Debug.Log(vector[i]);
            }
        }
    }
}
