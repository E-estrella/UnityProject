using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public Text PlayerName;

    // Start is called before the first frame update
    void Start()
    {
        // GameName에 있는 변수 불러오기
        GameName gamename  = GameObject.Find("NameManagement").GetComponent<GameName>();
        
        if (gameObject.name == "Player1")
        {
            PlayerName.text = gamename.Player1;
        }
        else if (gameObject.name == "Player2")
        {
            PlayerName.text = gamename.Player2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
