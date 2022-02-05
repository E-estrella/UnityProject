using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory1 : MonoBehaviour
{
    public List<SlotData1> slots = new List<SlotData1>();
    private int maxSlot = 11;
    public GameObject slotPrefab;
    public int Count1;
    // Start is called before the first frame update
    void Start()
    {
        GameObject slotPanel = GameObject.Find("Panel1");
        for (int i = 0; i < maxSlot; i++)
        {
            GameObject go = Instantiate(slotPrefab, slotPanel.transform, false);
            go.name = "Slot_" + i;
            SlotData1 slot = new SlotData1();
            slot.isEmpty = true;
            slot.slotObj = go;
            slots.Add(slot);
        }
    }
}