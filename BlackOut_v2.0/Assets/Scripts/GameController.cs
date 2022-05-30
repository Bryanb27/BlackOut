using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public void carregaCena(string nomeCena) 
    {
        SceneManager.LoadScene(nomeCena);
    }
}
