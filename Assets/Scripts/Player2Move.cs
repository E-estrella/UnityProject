using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Move : MonoBehaviour
{
    // 플레이어1 닉네임 변수
    string P2Name;

    // text 변수
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
