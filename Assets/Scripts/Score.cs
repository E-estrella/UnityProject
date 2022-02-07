using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int Player1Score;
    public int Player2Score;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject p1 = GameObject.Find("player1_outter");
        ScoreManager1 P1 = p1.GetComponent<ScoreManager1>();

        GameObject p2 = GameObject.Find("player2_outter");
        ScoreManager2 P2 = p2.GetComponent<ScoreManager2>();

        if (P1)
        {
            Player1Score = P1.Player1Score;
        }

        //if (P2 != null)
        if (P2)
        {
            Player2Score = P2.Player2Score;
        }
            

        //Debug.Log(Player1Score);
        //Debug.Log(Player2Score);
    }
}
