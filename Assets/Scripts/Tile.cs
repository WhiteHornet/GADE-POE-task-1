using UnityEngine;
using System.Collections;

public enum TileType { OceanEmpty, OceanShip, Hit, Miss}
public enum Orientation { Horizational, Vertical }

public class Tile 
{
    public TileType TileType { get; set; }
    public Orientation Orientation { get; set; }
}
