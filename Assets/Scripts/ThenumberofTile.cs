using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThenumberofTile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject tile1 = GameObject.Find("Tilemap");
        Bricks1 b1 = tile1.GetComponent<Bricks1>();

        GameObject tile2 = GameObject.Find("Tilemap");
        Bricks2 b2 = tile2.GetComponent<Bricks2>();

        
    }
}
