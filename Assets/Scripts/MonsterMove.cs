using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    public Rigidbody Monster;


    void Start()
    {
        StartCoroutine(MoveObject());

    }
    IEnumerator MoveObject()
    {

        while(true)
        {
            float dir1 = Random.Range(-1f, 1f);
            float dir2 = Random.Range(-1f, 1f);

            yield return new WaitForSeconds(2);
            Monster.velocity = new Vector3(dir1, 3, dir2);

        }
    }


   
    void Update()
    {
        
    }
}
