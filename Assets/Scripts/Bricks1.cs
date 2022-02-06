using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Bricks1 : MonoBehaviour
{
    public GameObject go;
    public Tilemap tilemap;
    GridLayout gridLayout;
    //public int tile1;

    // Start is called before the first frame update
    void Start()
    {
        tilemap = GetComponent<Tilemap>();
        gridLayout = transform.parent.GetComponentInParent<GridLayout>();
    }

    public void MakeColor(Vector3 Pos)
    {
        //this.tilemap.RefreshAllTiles();
        Vector3Int cellPosition = tilemap.WorldToCell(Pos);
        //if (Input.GetKey(KeyCode.W | KeyCode.A | KeyCode.S | KeyCode.D))
        //{
        tilemap.SetTileFlags(cellPosition, TileFlags.None); //타일 색 바꾸기
        tilemap.SetColor(cellPosition, (Color.red));//빨간색
                                                    //}

        // 컬러 계산
        int numRed = 0;
        Vector3Int mapPos = new Vector3Int();

        for (int i = 0; i < tilemap.size.x; i++)
        {
            mapPos.x = tilemap.origin.x + i;

            for (int j = 0; j < tilemap.size.y; j++)
            {
                mapPos.y = tilemap.origin.y + j;

                if (tilemap.GetColor(mapPos) == Color.red)
                {
                    ++numRed;
                }
            }
        }

        print("num red: " + numRed);
    }
    
    
}

