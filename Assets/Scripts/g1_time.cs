using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class g1_time : MonoBehaviour
{
    [SerializeField] float setTime = 60.0f;
    [SerializeField] Text countdownText;

    //GameObject popup = GameObject.Find("Panel");

    // Start is called before the first frame update
    void Start()
    {
        countdownText.text = setTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (setTime > 0)
            setTime -= Time.deltaTime;
        else if (setTime <= 0)
        {
            Time.timeScale = 0.0f;
            //popup.SetActive(true);
        }
            

        countdownText.text = Mathf.Round(setTime).ToString();

        // 시간이 소진되면 팝업창
    }
}
