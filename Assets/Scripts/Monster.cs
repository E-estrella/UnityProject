using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public GameObject slotItem;
    public GameObject slotItem2;
    
     
    // Start is called before the first frame update
    void Start()
    {
    GameObject p1Score = GameObject.Find("ScoreManagner");
    Score p1score = p1Score.GetComponent<Score>();

    GameObject p2Score = GameObject.Find("ScoreManagner");
    Score p2score = p2Score.GetComponent<Score>();

    Inventory3 inven3 = GetComponent<Inventory3>();



 
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
