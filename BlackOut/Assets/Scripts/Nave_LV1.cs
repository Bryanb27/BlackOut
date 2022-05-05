using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave_LV1 : MonoBehaviour
{
    Vector3[] path;
    public List<int[]> array;

    // Start is called before the first frame update
    void Start()
    {
        //Transform myTransform = transform;
        for(int i=0; i < array.Count; i++)
            this.path[i] = new Vector3(array[i][0], 1,array[i][1]);
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < array.Count; ++i){
            transform.position = path[i] * Time.deltaTime;
        }
    }
}
