using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Bricks : MonoBehaviour
{
    public GameObject go;
    public Tilemap tilemap;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        tilemap = GetComponent<Tilemap>();
    }

    public void MakeColor (Vector3 Pos)
    {
        //Vector3Int cellPosition = tilemap.WorldToCell(Pos);

        if (Input.GetKey(KeyCode.W & KeyCode.A & KeyCode.S & KeyCode.D))
            sr.material.color = Color.red; //»¡°£»ö

        if (Input.GetKey(KeyCode.RightArrow & KeyCode.LeftArrow & KeyCode.UpArrow & KeyCode.DownArrow))
            sr.material.color = Color.blue; //ÆÄ¶õ»ö »öÄ¥

    }
   

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey("left shift"))
            //sr.material.color = Color.red; //»¡°£»ö

        //if (Input.GetKey("right shift"))
            //sr.material.color = Color.blue; //ÆÄ¶õ»ö »öÄ¥
    }
}
