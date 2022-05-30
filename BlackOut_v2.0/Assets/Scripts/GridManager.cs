using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;

    [SerializeField] private Tile _tilePrefab;

    private Dictionary<Vector3, Tile> _tiles;

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        _tiles = new Dictionary<Vector3, Tile>();
        for(int x = 0; x*2 < _width*2; x++)
        {
            for(int z = 0; z*2 < _height*2; z++)
            {
                var spawnedTile = Instantiate(_tilePrefab, new Vector3(x*2, -0.4f ,z*2), Quaternion.identity);
                spawnedTile.name = $"Tile {x*2} {-0.4f} {z*2}";

                _tiles[new Vector3(x * 2, -0.4f, z * 2)] = spawnedTile;
            }
        }
    }

    public Tile GetTileAtPosition(Vector3 pos)
    {
        if(_tiles.TryGetValue(pos, out var tile))
        {
            return tile;
        }

        return null;
    }
}
