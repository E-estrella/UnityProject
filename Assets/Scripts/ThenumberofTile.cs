using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThenumberofTile : MonoBehaviour
{
    public GameObject colorObj1;
    Vector3 pos1;
    public int tile1_count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject tile1 = GameObject.Find("player1_outter");
        ColorInput1 Input1 = tile1.GetComponent<ColorInput1>();
        pos1 = Input1.PlayerPosition;
        
        //GameObject tile2 = GameObject.Find("Tilemap");
        //Bricks2 b2 = tile2.GetComponent<Bricks2>();

        //GameObject[] tiles1 = GameObject.FindGameObjectsWithTag("tile");
        //tile1_count = tiles1.Length;
        //tile1_count = Input1.tile1;
        //Debug.Log(tile1_count);
    }

    IEnumerator Spoid()
    {
        Texture2D tex = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        yield return new WaitForEndOfFrame();
        tex.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        tex.Apply();

        Color color = tex.GetPixel((int)pos1.x, (int)pos1.y);

        colorObj1.GetComponent<Renderer>().material.color = color;

        //tile1_count = colorObj1.Find;
    }
}
