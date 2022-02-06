using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class Bricks1 : MonoBehaviour
{
    public GameObject go;
    public Tilemap tilemap;
    GridLayout gridLayout;
    public Text Player1ScoreUI;
    public int Player1Score = 0;
    public Bricks2 Player2score;
    public g2_time settime;
    GameObject player1;
    //public int tile1;

    // Start is called before the first frame update
    void Start()
    {
        tilemap = GetComponent<Tilemap>();
        settime = GameObject.Find("Main Camera").GetComponent<g2_time>();
        gridLayout = transform.parent.GetComponentInParent<GridLayout>();
        Player2score = GameObject.Find("Tilemap").GetComponent<Bricks2>();

        player1 = GameObject.Find("Canvas").transform.Find("Panel").transform.Find("winnerP1").gameObject;
        player1.SetActive(false);
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
            if (settime.setTime > 0)
            {
                mapPos.x = tilemap.origin.x + i;

                for (int j = 0; j < tilemap.size.y; j++)
                {
                    mapPos.y = tilemap.origin.y + j;


                    if (tilemap.GetColor(mapPos) == Color.red)
                    {
                        ++numRed;
                        Player1Score = numRed;
                    }
                }
            }
            if (settime.setTime <= 0)
            {
                //print("num clear: " + numRed);

                Player1ScoreUI.text = " X " + Player1Score;


            }
        }

        print("num red: " + numRed);
        Debug.Log(Player1Score);
        if (Player1Score > Player2score.Player2Score)
        {
            player1.SetActive(true);
        }
        Player1ScoreUI.text = " X " + Player1Score;

    }


}