using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputField1 : MonoBehaviour
{
    // �÷��̾�1 �̸� ������ ����
    //private PlayerManager Player1;

    // Player1 �̸� �Է�
    public Text p1;

    // Start is called before the first frame update
    void Start()
    {
        //Player1 = FindObjectOfType<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // ����Ű�� ������ �̸� ����
        if(Input.GetKeyDown(KeyCode.Return))
        {
            //Player1.characterName1 = text.p1;
            Debug.Log(p1);
        }
    }
}
