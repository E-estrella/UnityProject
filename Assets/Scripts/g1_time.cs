using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class g1_time : MonoBehaviour
{
    public float setTime;
    public Text countdownText;
    public AudioClip timesup;

    GameObject next;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
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
            Time.timeScale = 0;
            next.SetActive(true);
            AudioSource.PlayClipAtPoint(timesup, transform.position); // 오디오할당
            
        }
        countdownText.text = Mathf.Round(setTime).ToString();
    }
}
