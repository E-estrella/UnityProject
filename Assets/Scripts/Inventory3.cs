using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory3 : MonoBehaviour
{
    public List<SlotData3> slots = new List<SlotData3>();
    private int maxSlot = 11;
    public GameObject slotPrefab3;
    // Start is called before the first frame update
    void Start()
    {
        GameObject slotPanel3 = GameObject.Find("Panel1");
        for (int i = 0; i < maxSlot; i++)
        {
            GameObject go = Instantiate(slotPrefab3, slotPanel3.transform, false);
            go.name = "Slot_" + i;
            SlotData3 slot = new SlotData3();
            slot.isEmpty = true;
            slot.slotObj3 = go;
            slots.Add(slot);
        }
    }

}