using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g1_time : MonoBehaviour
{
    GameManager gm = GameObject.Find("MainCamera").GetComponent<GameManager>();

    GameObject popup = GameObject.Find("Panel");

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �ð��� �����Ǹ� �˾�â
        if (gm.time <= 0)
        {
            Time.timeScale = 0f;
            popup.SetActive(true);
        }
    }
}
