using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class g2_time : MonoBehaviour
{
    public float setTime;
    public Text countdownText;
    GameObject next;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        countdownText.text = setTime.ToString();

        next = GameObject.Find("Canvas").transform.Find("Panel").gameObject;
        next.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (setTime > 0)
            setTime -= Time.deltaTime;

        else if (setTime <= 0)
        {
            next.SetActive(true);
        }
        countdownText.text = Mathf.Round(setTime).ToString();
    }
}
