using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    //public string PlayerName1, PlayerName2;

    public Text PlayerName;

    // Start is called before the first frame update
    void Start()
    {
        // GameName에 있는 변수 불러오기
        GameName gamaname  = GameObject.Find("NameManagement").GetComponent<GameName>();
        //PlayerName1 = gamaname.Player1;
        //PlayerName2 = gamaname.Player2;

        if (gameObject.name == "Player1")
        {
            PlayerName.text = gamaname.Player1;
        }
        else if (gameObject.name == "Player2")
        {
            PlayerName.text = gamaname.Player2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
