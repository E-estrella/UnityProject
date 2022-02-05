using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class tile : MonoBehaviour
{
    Vector3 PlayerPosition;
    public LayerMask whatisPlatform;
    public GameObject go;
    public Tilemap tilemap;

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(PlayerPosition, 0.2f);
    }
    // Start is called before the first frame update
    void Start()
    {
        tilemap = GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W | KeyCode.A | KeyCode.S | KeyCode.D))
        {
            print("Ű�Է�");

            Collider2D overCollider2d = Physics2D.OverlapCircle(PlayerPosition, 0.01f, whatisPlatform);
            if (overCollider2d != null)
            {
                print("�浹!!");

                overCollider2d.transform.GetComponent<Bricks>().MakeColor(PlayerPosition);
            }
        }
    }
    public void MakeColor(Vector3 Pos)
    {
        this.tilemap.RefreshAllTiles();
        Vector3Int cellPosition = tilemap.WorldToCell(Pos);


        //if (Input.GetKey(KeyCode.W | KeyCode.A | KeyCode.S | KeyCode.D))
        //{
        tilemap.SetTileFlags(cellPosition, TileFlags.None); //Ÿ�� �� �ٲٱ�
        tilemap.SetColor(cellPosition, (Color.red)); //������

        //}



        //if (Input.GetKey(KeyCode.RightArrow | KeyCode.LeftArrow | KeyCode.UpArrow | KeyCode.DownArrow))
        //{
        //    this.tilemap.SetTileFlags(cellPosition, TileFlags.None); //Ÿ�� �� �ٲٱ�
        //    this.tilemap.SetColor(cellPosition, (Color.blue)); //�Ķ��� ��ĥ
        //}


    }
}
