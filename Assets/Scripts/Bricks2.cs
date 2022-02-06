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
        tilemap.SetTileFlags(cellPosition, TileFlags.None); //타일 색 바꾸기
        tilemap.SetColor(cellPosition, (Color.clear)); //파란색

        // 컬러 계산
        int numRed = 0;
        Vector3Int mapPos = new Vector3Int();

        for (int i = 0; i < tilemap.size.x; i++)
        {
            mapPos.x = tilemap.origin.x + i;

            for (int j = 0; j < tilemap.size.y; j++)
            {
                mapPos.y = tilemap.origin.y + j;

                if (tilemap.GetColor(mapPos) == Color.clear)
                {
                    ++numRed;
                }
            }
        }

        print("num clear: " + numRed);
    }
}