using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory4 : MonoBehaviour
{
    public List<SlotData4> slots = new List<SlotData4>();
    private int maxSlot = 11;
    public GameObject slotPrefab4;
    // Start is called before the first frame update
    void Start()
    {
        GameObject slotPanel4 = GameObject.Find("Panel2");
        for (int i = maxSlot - 1; i >= 0; i--)
        {
            GameObject go = Instantiate(slotPrefab4, slotPanel4.transform, false);
            go.name = "Slot_" + i;
            SlotData4 slot = new SlotData4();
            slot.isEmpty = true;
            slot.slotObj4 = go;
            slots.Add(slot);
        }
    }

}
