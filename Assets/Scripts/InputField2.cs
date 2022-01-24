using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputField2 : MonoBehaviour
{
    //private PlayerManager Player2;

    public Text p2;

    // Start is called before the first frame update
    void Start()
    {
        //Player2 = FindObjectOfType<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //Player2.characterName2 = text.p2;
            Debug.Log(p2);
        }
    }
}
