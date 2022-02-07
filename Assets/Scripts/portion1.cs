using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portion1 : MonoBehaviour
{
    public int Player1;
    public GameObject slotItem;

    // Start is called before the first frame update
    void Start()
    {
        GameObject p1 = GameObject.Find("ScoreManager");
        Score P1 = p1.GetComponent<Score>();
        Player1 = P1.Player1Score;

        Inventory3 inven3 = GetComponent<Inventory3>();
        for(int i = 0; i < Player1; i++)
        {
            GameObject go = Instantiate(slotItem, inven3.slots[i].slotObj3.transform, false);
            inven3.slots[i].isEmpty = false;
            inven3.slots[i].potionObj = go;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
