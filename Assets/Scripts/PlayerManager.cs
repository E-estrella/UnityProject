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

        GameObject nm = GameObject.Find("NameManagement");
        if (nm != null)

        {
            GameName gamename = nm.GetComponent<GameName>();
            if (gamename != null)
            {
                if (gameObject.name == "Player1")
                {
                    PlayerName.text = gamename.Player1;
                }
                else if (gameObject.name == "Player2")
                {
                    PlayerName.text = gamename.Player2;
                }
            }
        }
    }
}
