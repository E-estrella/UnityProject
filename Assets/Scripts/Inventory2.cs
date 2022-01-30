using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory2 : MonoBehaviour
{
    public List<SlotData2> slots = new List<SlotData2>();
    private int maxSlot = 11;
    public GameObject SlotPrefab2;

    private void Start()
    {
        GameObject slotPanel = GameObject.Find("Panel");

        for (int i = 0; i < maxSlot; i++)
        {
            GameObject go = Instantiate(SlotPrefab2, slotPanel.transform, false);
            go.name = "Slot_" + i;
            SlotData2 slot = new SlotData2();
            slot.isEmpty = true;
            slot.slotObj = go;
            slots.Add(slot);
        }
    }
}