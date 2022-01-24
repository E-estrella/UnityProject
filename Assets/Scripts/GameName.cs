using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameName : MonoBehaviour
{
    public Text PlayerName1;
    public Text PlayerName2;

    public void GameStart()
    {
        PlayerPrefs.SetString("PlayerName1", PlayerName1.text);
        PlayerPrefs.SetString("PlayerName2", PlayerName2.text);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
