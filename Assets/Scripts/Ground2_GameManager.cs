using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ground2_GameManager : MonoBehaviour
{
    public Text timeText;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 180f;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }

        timeText.text = Mathf.Ceil(time).ToString();
    }
}
