using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //private void Awake()
    //{
    //    DontDestroyOnLoad(gameObject);
    //}

    private int Count1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //PickUp1 p1 = GameObject.Find("Treasure2").GetComponent<PickUp1>();
        //g1_time time = GameObject.Find("Main Camera").GetComponent<g1_time>();
        //if (time.setTime == 0)
        //{
        //    Count1 = p1.Count;
        //    Debug.Log(Count1);
        //}
    }

    public void Plus()
    {
        g1_time time = GameObject.Find("Main Camera").GetComponent<g1_time>();
        if(time.setTime <= 0)
        {
            PickUp1 p1 = GameObject.Find("Treasure2").GetComponent<PickUp1>();
            Count1 = p1.Count1;
            Debug.Log(1);
            print(1);
            Debug.Log(Count1);
        }
    }
}
