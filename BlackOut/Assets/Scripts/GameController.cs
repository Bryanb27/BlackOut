using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public void carregaCena(string Fase1)
    {
        List<string> map = new List<string>
        {
            "    #.   ",
            "A   # .  ",
            ".        ",
            ".. #B    ",
            "    #    ",
            "      .  ",
            "    # .  "
        };

        List<int[]> path = PathFinder(map);
        Transform[] walker = new Transform[path.Count];



        //Nave_LV1 nave;
        
        SceneManager.LoadScene(Fase1);
    }
}
