using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMap : MonoBehaviour {

    public GameObject oceanTile;
    public GameObject hitTile;
    public GameObject missTile;
    public int size;
    private Map map;

	// Use this for initialization
	void Start () {

        CreateMap();
        Display();
		
    }
	
	// Update is called once per frame
	void Update () {
        GameObject[] gameObjects =  GameObject.FindGameObjectsWithTag ("tile");
 
        foreach(GameObject g in gameObjects) 
        {
            Destroy(g);
        }

        Display();
	}

    void CreateMap()
    {
        map = new Map(size);
    }

    void Display()
    {
        for (int x = 0; x < size; x++)
        {
            for (int z = 0; z < size; z++)
            {
                switch (map.TileMap[x, z].TileType)
                {
                    case TileType.OceanEmpty:
                        Instantiate(oceanTile, new Vector3(x, 0, z), Quaternion.identity);
                        break;
                    case TileType.OceanShip: {
                        Instantiate(oceanTile, new Vector3(x, 0, z), Quaternion.identity);
                        break;
                        }
                    case TileType.Hit:
                        if(map.TileMap[x, z].Orientation == Orientation.Vertical) {
                            Instantiate(hitTile, new Vector3(x, 0, z), Quaternion.identity);
                            break; 
                        }
                        else
                        {
                            Instantiate(hitTile, new Vector3(x, 0, z), Quaternion.Euler(0,90,0));
                            break; 
                        }
                    case TileType.Miss:
                        Instantiate(missTile, new Vector3(x, 0, z), Quaternion.identity);
                        break;
                }
            }
        }
    }

    public void Hit(int x, int y)
    {
        if(map.TileMap[x, y].TileType == TileType.OceanShip) {
            map.TileMap[x, y].TileType = TileType.Hit;
        }
        else
        {
            map.TileMap[x, y].TileType = TileType.Miss;
        }
    }

}
