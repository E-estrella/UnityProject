using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class Bricks2 : MonoBehaviour
{
    public GameObject go;
    public Tilemap tilemap;
    GridLayout gridLayout;
    public Text Player2ScoreUI;
    public int Player2Score = 0;
    public Bricks1 Player1score;
    public g2_time settime;
    GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        tilemap = GetComponent<Tilemap>();
        settime = GameObject.Find("Main Camera").GetComponent<g2_time>();
        gridLayout = transform.parent.GetComponentInParent<GridLayout>();
        Player1score = GameObject.Find("Tilemap").GetComponent<Bricks1>();

        player2 = GameObject.Find("Canvas").transform.Find("Panel").transform.Find("winnerP2").gameObject;
        player2.SetActive(false);
    }

    public void MakeColor(Vector3 Pos)
    {
        Vector3Int cellPosition = tilemap.WorldToCell(Pos);
        tilemap.SetTileFlags(cellPosition, TileFlags.None); //타일 색 바꾸기
        tilemap.SetColor(cellPosition, (Color.clear)); //파란색

        // 컬러 계산
        int numRed = 0;
        Vector3Int mapPos = new Vector3Int();

        //if (settime.setTime > 0)
        //{

        for (int i = 0; i < tilemap.size.x; i++)
        {
            if (settime.setTime > 0)
            {
                mapPos.x = tilemap.origin.x + i;

                for (int j = 0; j < tilemap.size.y; j++)
                {
                    mapPos.y = tilemap.origin.y + j;

                    if (tilemap.GetColor(mapPos) == Color.clear)
                    {
                        ++numRed;
                        Player2Score = numRed;
                    }
                }
            }
            if (settime.setTime <= 0)
            {
                Player2ScoreUI.text = " X " + Player2Score;
            }
        }
        if (Player2Score > Player1score.Player1Score)
        {
            player2.SetActive(true);
        }
        Player2ScoreUI.text = " X " + Player2Score;
    }
}