using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Bricks : MonoBehaviour
{
    public GameObject go;
    public Tilemap tilemap;
    GridLayout gridLayout;
    Vector3Int cellPosition;
  
    // Start is called before the first frame update
    void Start()
    {
        tilemap = GetComponent<Tilemap>();
        gridLayout = transform.parent.GetComponentInParent<GridLayout>();
    }




    public void MakeColor(Vector3 Pos)
    {
        this.tilemap.RefreshAllTiles();
        Vector3Int cellPosition = tilemap.WorldToCell(Pos);

        if (Input.GetKey(KeyCode.W | KeyCode.A | KeyCode.S | KeyCode.D))
        {
            tilemap.SetTileFlags(cellPosition, TileFlags.None); //???? ?? ??????
            tilemap.SetColor(cellPosition, (Color.red)); //??????

        }
          
            

        //if (Input.GetKey(KeyCode.RightArrow | KeyCode.LeftArrow | KeyCode.UpArrow | KeyCode.DownArrow))
        //{
        //    this.tilemap.SetTileFlags(cellPosition, TileFlags.None); //???? ?? ??????
        //    this.tilemap.SetColor(cellPosition, (Color.blue)); //?????? ????
        //}
            

    }
   

    // Update is called once per frame
    void Update()
    {
       
        //if (Input.GetKey("left shift"))
        //sr.material.color = Color.red; //??????

        //if (Input.GetKey("right shift"))
        //sr.material.color = Color.blue; //?????? ????
    }

}
