using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private GameObject _highlight;

    void onMouseEnter()
    {
        _highlight.SetActive(true);
    }

    void onMouseExit()
    {
        _highlight.SetActive(false);
    }
}
