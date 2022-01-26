using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameName : MonoBehaviour
{
    // 플레이어 이름 변수 선언
    public InputField PlayerName1;
    public InputField PlayerName2;

    public string Player1, Player2;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // 버튼 누르면 작동
    public void GameStart()
    {
        // PlayerPrefs는 변수를 담고 저장해 불러올 수 있는 함수
        // .SetString은 지정한 키로 String 타입의 값을 저장
        // "PlayerName1"이라는 이름으로 PlayerName1 텍스트 값을 저장
        PlayerPrefs.SetString("PlayerName1", PlayerName1.text);
        PlayerPrefs.SetString("PlayerName2", PlayerName2.text);
        //PlayerPrefs.Save();
    }

    // Start is called before the first frame update
    void Start()
    {
        // PlayerPrefs에 데이터 있으면 불러와 각 변수에 데이터 저장
        if (PlayerPrefs.HasKey("PlayerName1"))
        {
            Player1 = PlayerPrefs.GetString("PlayerName1");

            // Player1이 있는 경우에만 Player2 확인
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
