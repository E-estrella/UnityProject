using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Move : MonoBehaviour
{
    // �÷��̾�1 �г��� ����
    string P2Name;

    // text ����
    public Text text2;

    // Start is called before the first frame update
    void Start()
    {
        PlayerManager PM = GameObject.Find("Player2").GetComponent<PlayerManager>();
        P2Name = PM.PlayerName2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
