using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public string PlayerName1, PlayerName2;

    // Start is called before the first frame update
    void Start()
    {
        // GameName�� �ִ� ���� �ҷ�����
        GameName gamaname  = GameObject.Find("NameManagement").GetComponent<GameName>();
        PlayerName1 = gamaname.Player1;
        PlayerName2 = gamaname.Player2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
