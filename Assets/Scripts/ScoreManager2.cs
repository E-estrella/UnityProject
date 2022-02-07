using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager2 : MonoBehaviour
{
    public Text Player2ScoreUI;
    public int Player2Score = 0;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("PickUp"))
        {
            Player2Score++;
        }
        Player2ScoreUI.text = " X " + Player2Score;
    }
}
