using UnityEngine;
using System.Collections;

public enum TileType { Ocean, Hit, Miss}

public class Tile 
{
    public TileType TileType { get; set; }
}
