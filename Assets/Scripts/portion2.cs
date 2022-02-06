using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portion2 : MonoBehaviour
{
    public int Player2;
    // Start is called before the first frame update
    void Start()
    {
        GameObject p2 = GameObject.Find("ScoreManagement");
        Score P2 = p2.GetComponent<Score>();
        Player2 = P2.Player2Score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
