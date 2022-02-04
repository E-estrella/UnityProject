using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class g1_time : MonoBehaviour
{
    [SerializeField] float setTime = 60.0f;
    [SerializeField] Text countdownText;

    GameObject next = GameObject.Find("Canvas").transform.Find("nextbutton").gameObject;

    // Start is called before the first frame update
    void Start()
    {
        countdownText.text = setTime.ToString();
        next.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (setTime > 0)
            setTime -= Time.deltaTime;
        else if (setTime <= 0)
        {
            Time.timeScale = 0.0f;
            next.SetActive(true);
        }
        countdownText.text = Mathf.Round(setTime).ToString();
    }
}
