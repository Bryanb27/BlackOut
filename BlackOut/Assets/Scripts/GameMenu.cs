using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    public void carregaCena(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
