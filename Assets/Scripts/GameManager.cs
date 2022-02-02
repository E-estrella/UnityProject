using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Vector3[] Pointlist;

    public Text timeText;
    public float time;

    //GameObject popup = GameObject.Find("Panel");

    // Start is called before the first frame update
    void Start()
    {
        time = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }

        timeText.text = Mathf.Ceil(time).ToString();

        // 시간이 소진되면 팝업창
        //if (time <= 0)
        //{
        //    Time.timeScale = 0f;
        //    popup.SetActive(true);
        //}
    }
}
