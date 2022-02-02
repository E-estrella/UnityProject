using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Vector3[] Pointlist;

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

        // ?????? ?????????? ??(?????????? ?????????? ??)
        if (time == 0)
        {
            Time.timeScale = 0f;
            //Panel.SetActive(true);
        }
    }
}
