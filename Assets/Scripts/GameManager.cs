using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timeText;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }

        timeText.text = Mathf.Ceil(time).ToString();

        // 게임이 종료되었을 때(보물상자가 소진되었을 때)
        if (time == 0)
        {
            Time.timeScale = 0f;
            //Panel.SetActive(true);
        }
    }
}
