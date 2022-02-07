using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portion2 : MonoBehaviour
{
    public int Player2;
    public GameObject slotItem;

    // Start is called before the first frame update
    void Start()
    {
        GameObject p2 = GameObject.Find("ScoreManager");
        Score P2 = p2.GetComponent<Score>();
        Player2 = P2.Player2Score;
    }

    // Update is called once per frame
    void Update()
    {
        Inventory4 inven4 = GetComponent<Inventory4>();
        //for (int i = Player2 - 1; i >= 0; i--)
        for (int i = Player2; i >= 0; i--)
        {
            int slotIndex = inven4.slots.Count - i;

            Instantiate(slotItem, inven4.slots[slotIndex].slotObj4.transform, false);
            inven4.slots[slotIndex].isEmpty = false;
        }
    }
}
;