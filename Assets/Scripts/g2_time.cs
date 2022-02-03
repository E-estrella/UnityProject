using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class g2_time : MonoBehaviour
{
    [SerializeField] float setTime = 180.0f;
    [SerializeField] Text countdownText;

    [SerializeField]
    Text timerText;

    //GameObject popup = GameObject.Find("Panel");

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (setTime > 0)
            setTime -= Time.deltaTime;
        else if (setTime <= 0)
            Time.timeScale = 0.0f;

        countdownText.text = Mathf.Round(setTime).ToString();
    }
}
