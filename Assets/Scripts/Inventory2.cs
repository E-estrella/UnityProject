using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory2 : MonoBehaviour
{
    // 플레이어 포션1 저장
    //private void Awake()
    //{
    //    DontDestroyOnLoad(gameObject);
    //}

    public List<SlotData2> slots = new List<SlotData2>();
    private int maxSlot = 11;
    public GameObject slotPrefab2;
    // Start is called before the first frame update
    void Start()
    {
        GameObject slotPanel2 = GameObject.Find("Panel2");
        for (int i = 0; i < maxSlot; i++)
        {
            GameObject go = Instantiate(slotPrefab2, slotPanel2.transform, false);
            go.name = "Slot_" + i;
            SlotData2 slot = new SlotData2();
            slot.isEmpty = true;
            slot.slotObj2 = go;
            slots.Add(slot);
        }
    }

}