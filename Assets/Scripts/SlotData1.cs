using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SlotData1 : MonoBehaviour
{
    public bool isEmpty;
    public GameObject slotObj;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}


