using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Bricks2 : MonoBehaviour
{
    public GameObject go;
    public Tilemap tilemap;
    GridLayout gridLayout;

    // Start is called before the first frame update
    void Start()
    {
        tilemap = GetComponent<Tilemap>();
        gridLayout = transform.parent.GetComponentInParent<GridLayout>();
    }

    public void MakeColor(Vector3 Pos)
    {
        Vector3Int cellPosition = tilemap.WorldToCell(Pos);

        tilemap.SetTileFlags(cellPosition, TileFlags.None); //?? ? ???
        tilemap.SetColor(cellPosition, (Color.clear)); //???? ?? ? ????
    }
}