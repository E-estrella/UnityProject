using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputField1 : MonoBehaviour
{
    // 플레이어1 이름 저장할 변수
    //private PlayerManager Player1;

    // Player1 이름 입력
    public Text p1;

    // Start is called before the first frame update
    void Start()
    {
        //Player1 = FindObjectOfType<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // 엔터키를 누르면 이름 저장
        if(Input.GetKeyDown(KeyCode.Return))
        {
            //Player1.characterName1 = text.p1;
            Debug.Log(p1);
        }
    }
}
