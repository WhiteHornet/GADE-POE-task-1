using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public GameObject oceanTile;
    public GameObject hitTile;
    public GameObject missTile;
    public int size;
    private Tile[,] map;

	// Use this for initialization
	void Start () {

        CreateMap();
        DisplayMap();
		
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void CreateMap()
    {
        map = new Tile[size, size];
        for (int x = 0; x < size; x++)
        {
            for (int z = 0; z < size; z++)
            {
                Tile t = new Tile();
                if (Random.Range(0, 100) > 80)
                {
                    t.TileType = TileType.Hit;
                }
                else
                {
                    t.TileType = TileType.Ocean;
                }
                map[x, z] = t;
            }
        }
    }

    void DisplayMap()
    {
        for (int x = 0; x < size; x++)
        {
            for (int z = 0; z < size; z++)
            {
                switch (map[x, z].TileType)
                {
                    case TileType.Ocean:
                        Instantiate(oceanTile, new Vector3(x, 0, z), Quaternion.identity);
                        break;
                    case TileType.Hit:
                        Instantiate(hitTile, new Vector3(x, 0, z), Quaternion.identity);
                        break;
                    case TileType.Miss:
                        Instantiate(missTile, new Vector3(x, 0, z), Quaternion.identity);
                        break;
                }
            }
        }
    }
}
