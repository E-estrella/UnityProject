using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager1 : MonoBehaviour
{
    public Text Player1ScoreUI;
    public int Player1Score = 0;

    // ���� ���ڸ� �� ������ ���� ǥ��
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickUp"))
        {
            Player1Score++;
        }
        Debug.Log(Player1Score);
        Player1ScoreUI.text = " X " + Player1Score;
    }
}
