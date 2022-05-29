using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;
public class GridManager : MonoBehaviour
{
    public int columnLength, rowLenght;
    public float x_Space, y_Space, z_Space;
    public GameObject normal;
    public GameObject impossible;
    public GameObject boost;
   
    private int x;
    // Start is called before the first frame update
    void Start()
    {
        Random rnd = new  Random();
        for (int i = 0; i < columnLength * rowLenght; i++)
        {
            
            x = (int)rnd.Next(0,11);
            Debug.Log(x);
            if ((int)x <= 8)
            {
                Instantiate(normal, new Vector3(x_Space * (i % columnLength), y_Space * (i / columnLength), z_Space * (i / columnLength)), Quaternion.identity);
            }
            if ((int)x == 9)
            {
                Instantiate(impossible, new Vector3(x_Space * (i % columnLength), y_Space * (i / columnLength), z_Space * (i / columnLength)), Quaternion.identity);
            }
            if ((int)x >= 10)
            {
                Instantiate(boost, new Vector3(x_Space * (i % columnLength), y_Space * (i / columnLength), z_Space * (i / columnLength)), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
