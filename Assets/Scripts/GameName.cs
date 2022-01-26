using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameName : MonoBehaviour
{
    // �÷��̾� �̸� ���� ����
    public InputField PlayerName1;
    public InputField PlayerName2;

    public string Player1, Player2;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // ��ư ������ �۵�
    public void GameStart()
    {
        // PlayerPrefs�� ������ ��� ������ �ҷ��� �� �ִ� �Լ�
        // .SetString�� ������ Ű�� String Ÿ���� ���� ����
        // "PlayerName1"�̶�� �̸����� PlayerName1 �ؽ�Ʈ ���� ����
        PlayerPrefs.SetString("PlayerName1", PlayerName1.text);
        PlayerPrefs.SetString("PlayerName2", PlayerName2.text);
        //PlayerPrefs.Save();
    }

    // Start is called before the first frame update
    void Start()
    {
        // PlayerPrefs�� ������ ������ �ҷ��� �� ������ ������ ����
        if (PlayerPrefs.HasKey("PlayerName1"))
        {
            Player1 = PlayerPrefs.GetString("PlayerName1");

            // Player1�� �ִ� ��쿡�� Player2 Ȯ��
            if (PlayerPrefs.HasKey("PlayerName2"))
            {
                Player2 = PlayerPrefs.GetString("PlayerName2");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
