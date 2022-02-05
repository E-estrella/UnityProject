using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //private void Awake()
    //{
    //    DontDestroyOnLoad(gameObject);
    //}

    public int Count1;
    //GameObject p1 = GameObject.Find("player1_outter");
    //Inventory1 inven1 = p1.GetComponent<Inventory1>();
    // Start is called before the first frame update
    void Start()
    {
        PickUp1 p1 = GameObject.Find("Treasure2").GetComponent<PickUp1>();
        Count1 = p1.Count;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void input()
    {
        
    }
}
