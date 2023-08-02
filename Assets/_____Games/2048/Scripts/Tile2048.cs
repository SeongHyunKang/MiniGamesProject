using UnityEngine;

public class Tile2048 : MonoBehaviour
{
    public TileState state { get; private set; }
    public TileCell cell{ get; private set; }
    public int number { get; private set; }
}
